using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DKK_PolyLearning.DAL;
using DKK_PolyLearning.BLL;// Cần thiết cho GraphicsPath
using DKK_PolyLearning.DTO;

namespace DKK_PolyLearning.UI
{
    public partial class Form1 : Form
    {
        // Giảm bán kính bo tròn để góc ít cong hơn
        private const int BUTTON_CORNER_RADIUS = 8; // Thay đổi từ 15 xuống 8 hoặc 10

        // Biến lưu màu nền gốc của nút cho hiệu ứng hover
        private Color btnDangNhapOriginalBackColor;
        private Color btnDangKyOriginalBackColor;


        public Form1()
        {
            InitializeComponent();

            // Lưu màu nền gốc của các nút ngay sau khi InitializeComponent()
            // Điều này đảm bảo chúng ta có màu cơ sở để tính toán màu hover
            btnDangNhapOriginalBackColor = btn_DangNhap.BackColor;
            btnDangKyOriginalBackColor = btn_DangKy.BackColor;

            // --- Cấu hình cho nút Đăng nhập ---
            ConfigureRoundedButton(btn_DangNhap, btnDangNhapOriginalBackColor);
            // --- Cấu hình cho nút Đăng ký ---
            ConfigureRoundedButton(btn_DangKy, btnDangKyOriginalBackColor);

            // Đặt vị trí khởi tạo của Form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // --- Hàm cấu hình chung cho một nút ---
        // Thêm tham số originalBackColor để đảm bảo chúng ta dùng đúng màu gốc
        private void ConfigureRoundedButton(Button btn, Color originalBackColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            // ÉP BUỘC màu viền trùng với màu nền gốc của nút
            // Đây là chìa khóa để loại bỏ viền không mong muốn.
            btn.FlatAppearance.BorderColor = originalBackColor;

            // Cấu hình hiệu ứng HOVER bằng sự kiện MouseEnter và MouseLeave
            btn.MouseEnter += Button_MouseEnter_Custom;
            btn.MouseLeave += Button_MouseLeave_Custom;

            // Gán sự kiện Paint để vẽ tùy chỉnh
            btn.Paint += Button_Paint_Rounded;
            // Gán sự kiện SizeChanged để cập nhật Region
            btn.SizeChanged += Button_SizeChanged_SetRegion;
            // Thiết lập Region ban đầu
            SetRoundedButtonRegion(btn, BUTTON_CORNER_RADIUS);
        }

        // --- Sự kiện MouseEnter: Xử lý khi chuột di chuyển vào khu vực nút ---
        private void Button_MouseEnter_Custom(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Làm màu nút sáng/tối hơn khi hover
            if (btn.Name == "btn_DangNhap")
            {
                // Làm sáng màu đen của nút Đăng nhập một chút (0.05f là mức độ sáng nhỏ)
                btn.BackColor = ControlPaint.Light(btnDangNhapOriginalBackColor, 0.05f);
            }
            else if (btn.Name == "btn_DangKy")
            {
                // Làm tối màu trắng/xám của nút Đăng ký một chút (0.02f là mức độ tối nhỏ)
                btn.BackColor = ControlPaint.Dark(btnDangKyOriginalBackColor, 0.02f);
            }
            btn.Invalidate(); // Yêu cầu nút vẽ lại ngay lập tức
        }

        // --- Sự kiện MouseLeave: Xử lý khi chuột rời khỏi khu vực nút ---
        private void Button_MouseLeave_Custom(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Đặt lại màu nền về màu gốc khi chuột rời đi
            if (btn.Name == "btn_DangNhap")
            {
                btn.BackColor = btnDangNhapOriginalBackColor;
            }
            else if (btn.Name == "btn_DangKy")
            {
                btn.BackColor = btnDangKyOriginalBackColor;
            }
            btn.Invalidate(); // Yêu cầu nút vẽ lại ngay lập tức
        }

        // --- Phương thức Paint: Vẽ bo tròn và nội dung nút ---
        private void Button_Paint_Rounded(object sender, PaintEventArgs pe)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Bật chế độ Anti-aliasing (khử răng cưa) để các đường cong mượt mà hơn
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Bật TextRenderingHint để văn bản được render rõ nét hơn
            pe.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;


            RectangleF rectSurface = new RectangleF(0, 0, btn.Width, btn.Height);
            GraphicsPath pathSurface = GetRoundedRectPath(rectSurface, BUTTON_CORNER_RADIUS);

            // Vẽ nền của nút bằng màu BackColor hiện tại
            using (SolidBrush brush = new SolidBrush(btn.BackColor))
            {
                pe.Graphics.FillPath(brush, pathSurface);
            }

            // Vẽ chữ của nút
            // Sử dụng TextRenderer.DrawText để căn giữa và render văn bản
            TextRenderer.DrawText(pe.Graphics, btn.Text, btn.Font, pe.ClipRectangle, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // --- Phương thức thiết lập Region của nút ---
        private void SetRoundedButtonRegion(Button btn, int radius)
        {
            if (btn.Region != null)
            {
                btn.Region.Dispose();
            }
            if (btn.Width > 0 && btn.Height > 0)
            {
                btn.Region = new Region(GetRoundedRectPath(new RectangleF(0, 0, btn.Width, btn.Height), radius));
            }
        }

        // --- Sự kiện SizeChanged: Cập nhật Region khi kích thước nút thay đổi ---
        private void Button_SizeChanged_SetRegion(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                SetRoundedButtonRegion(btn, BUTTON_CORNER_RADIUS);
            }
        }

        // --- Hàm trợ giúp để tạo GraphicsPath cho hình chữ nhật bo tròn ---
        private GraphicsPath GetRoundedRectPath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        // --- Các sự kiện click và TextChanged mặc định của các control khác (giữ nguyên) ---
        private void label1_Click(object sender, EventArgs e) { }
        private void lb_DangNhap_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click_3(object sender, EventArgs e) { }
        private void txt_TK_TextChanged(object sender, EventArgs e) { }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string TenDN = txt_TK.Text.Trim();
            string MatKhau = txt_MK.Text.Trim();

            if (string.IsNullOrEmpty(TenDN) || string.IsNullOrEmpty(MatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.");
                return;
            }

            try
            {
                UserBLL userBLL = new UserBLL();
                var user = userBLL.Login(TenDN, MatKhau);

                if (user != null)
                {
                    MessageBox.Show($"Đăng nhập thành công!\nXin chào {user.TenDN} - Vai trò: {user.VaiTro}", "Thông báo");

                    Form2 form2 = new Form2(user.VaiTro); // truyền vai trò vào Form2
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
            }
        }
        private void btn_DangKy_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
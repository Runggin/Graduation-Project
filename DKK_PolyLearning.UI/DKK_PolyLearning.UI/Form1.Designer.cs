namespace DKK_PolyLearning.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.lb_taiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.lb_DangKy = new System.Windows.Forms.Label();
            this.lb_QuenMK = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DangNhap.Location = new System.Drawing.Point(52, 94);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(248, 51);
            this.lb_DangNhap.TabIndex = 0;
            this.lb_DangNhap.Text = "Đăng Nhập";
            this.lb_DangNhap.Click += new System.EventHandler(this.lb_DangNhap_Click);
            // 
            // lb_taiKhoan
            // 
            this.lb_taiKhoan.AutoSize = true;
            this.lb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taiKhoan.Location = new System.Drawing.Point(384, 158);
            this.lb_taiKhoan.Name = "lb_taiKhoan";
            this.lb_taiKhoan.Size = new System.Drawing.Size(105, 25);
            this.lb_taiKhoan.TabIndex = 1;
            this.lb_taiKhoan.Text = "Tài khoản:";
            this.lb_taiKhoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MatKhau.Location = new System.Drawing.Point(384, 223);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(99, 25);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật khẩu:";
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(509, 160);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(211, 22);
            this.txt_TK.TabIndex = 3;
            this.txt_TK.Text = "nhập tên tài khoản";
            this.txt_TK.TextChanged += new System.EventHandler(this.txt_TK_TextChanged);
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(509, 226);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(211, 22);
            this.txt_MK.TabIndex = 4;
            this.txt_MK.Text = "nhập mật khẩu";
            // 
            // lb_DangKy
            // 
            this.lb_DangKy.AutoSize = true;
            this.lb_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DangKy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_DangKy.Location = new System.Drawing.Point(507, 185);
            this.lb_DangKy.Name = "lb_DangKy";
            this.lb_DangKy.Size = new System.Drawing.Size(56, 16);
            this.lb_DangKy.TabIndex = 5;
            this.lb_DangKy.Text = "Đăng ký";
            this.lb_DangKy.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lb_QuenMK
            // 
            this.lb_QuenMK.AutoSize = true;
            this.lb_QuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_QuenMK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_QuenMK.Location = new System.Drawing.Point(507, 252);
            this.lb_QuenMK.Name = "lb_QuenMK";
            this.lb_QuenMK.Size = new System.Drawing.Size(103, 16);
            this.lb_QuenMK.TabIndex = 6;
            this.lb_QuenMK.Text = "Quên mật khẩu?";
            this.lb_QuenMK.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DangNhap.Location = new System.Drawing.Point(531, 309);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(116, 39);
            this.btn_DangNhap.TabIndex = 7;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_DangKy.Location = new System.Drawing.Point(411, 309);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(113, 39);
            this.btn_DangKy.TabIndex = 8;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tiếp tục với\nDKK PolyLearning";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(689, 412);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(99, 26);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lb_QuenMK);
            this.Controls.Add(this.lb_DangKy);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb_taiKhoan);
            this.Controls.Add(this.lb_DangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DKK PolyLearning - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.Label lb_taiKhoan;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label lb_DangKy;
        private System.Windows.Forms.Label lb_QuenMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        public System.Windows.Forms.Button btn_DangNhap;
        public System.Windows.Forms.Button btn_DangKy;
    }
}


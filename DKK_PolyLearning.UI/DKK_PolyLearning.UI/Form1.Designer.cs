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
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.lb_taiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.lb_DangKy = new System.Windows.Forms.Label();
            this.lb_QuenMK = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lb_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DangNhap.Location = new System.Drawing.Point(465, 111);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(217, 42);
            this.lb_DangNhap.TabIndex = 0;
            this.lb_DangNhap.Text = "Đăng Nhập";
            this.lb_DangNhap.Click += new System.EventHandler(this.lb_DangNhap_Click);
            // 
            // lb_taiKhoan
            // 
            this.lb_taiKhoan.AutoSize = true;
            this.lb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taiKhoan.Location = new System.Drawing.Point(403, 175);
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
            this.lb_MatKhau.Location = new System.Drawing.Point(403, 235);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(99, 25);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật khẩu:";
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(521, 179);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(211, 22);
            this.txt_TK.TabIndex = 3;
            this.txt_TK.Text = "Tài khoản";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(521, 239);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(211, 22);
            this.txt_MK.TabIndex = 4;
            this.txt_MK.Text = "Mật khẩu";
            // 
            // lb_DangKy
            // 
            this.lb_DangKy.AutoSize = true;
            this.lb_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DangKy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_DangKy.Location = new System.Drawing.Point(518, 275);
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
            this.lb_QuenMK.Location = new System.Drawing.Point(629, 275);
            this.lb_QuenMK.Name = "lb_QuenMK";
            this.lb_QuenMK.Size = new System.Drawing.Size(103, 16);
            this.lb_QuenMK.TabIndex = 6;
            this.lb_QuenMK.Text = "Quên mật khẩu?";
            this.lb_QuenMK.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(510, 320);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(99, 26);
            this.btn_DangNhap.TabIndex = 7;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // lb_Thoat
            // 
            this.lb_Thoat.Location = new System.Drawing.Point(632, 320);
            this.lb_Thoat.Name = "lb_Thoat";
            this.lb_Thoat.Size = new System.Drawing.Size(99, 26);
            this.lb_Thoat.TabIndex = 8;
            this.lb_Thoat.Text = "Thoát";
            this.lb_Thoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lb_QuenMK);
            this.Controls.Add(this.lb_DangKy);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb_taiKhoan);
            this.Controls.Add(this.lb_DangNhap);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button lb_Thoat;
    }
}


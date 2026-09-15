namespace Lab01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblHoTen = new Label();
            lblNamSinh = new Label();
            lblEmail = new Label();
            lblKhoa = new Label();
            lblKetQua = new Label();
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            txtEmail = new TextBox();
            grpGioiTinh = new GroupBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(207, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(812, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN SINH VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Times New Roman", 14F);
            lblHoTen.Location = new Point(150, 130);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(130, 35);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            lblHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNamSinh
            // 
            lblNamSinh.Font = new Font("Times New Roman", 14F);
            lblNamSinh.Location = new Point(150, 200);
            lblNamSinh.Name = "lblNamSinh";
            lblNamSinh.Size = new Size(130, 35);
            lblNamSinh.TabIndex = 2;
            lblNamSinh.Text = "Năm sinh:";
            lblNamSinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Times New Roman", 14F);
            lblEmail.Location = new Point(150, 270);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(130, 35);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKhoa
            // 
            lblKhoa.Font = new Font("Times New Roman", 14F);
            lblKhoa.Location = new Point(150, 460);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(130, 35);
            lblKhoa.TabIndex = 5;
            lblKhoa.Text = "Khoa/Lớp:";
            lblKhoa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKetQua
            // 
            lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            lblKetQua.Font = new Font("Times New Roman", 13F);
            lblKetQua.Location = new Point(150, 617);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Padding = new Padding(15);
            lblKetQua.Size = new Size(950, 200);
            lblKetQua.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 13F);
            txtHoTen.Location = new Point(300, 125);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(800, 47);
            txtHoTen.TabIndex = 1;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Times New Roman", 13F);
            txtNamSinh.Location = new Point(300, 195);
            txtNamSinh.MaxLength = 4;
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(300, 47);
            txtNamSinh.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 13F);
            txtEmail.Location = new Point(300, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(800, 47);
            txtEmail.TabIndex = 3;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(radNam);
            grpGioiTinh.Controls.Add(radNu);
            grpGioiTinh.Font = new Font("Times New Roman", 14F);
            grpGioiTinh.Location = new Point(150, 335);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(950, 85);
            grpGioiTinh.TabIndex = 4;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Font = new Font("Times New Roman", 13F);
            radNam.Location = new Point(40, 35);
            radNam.Name = "radNam";
            radNam.Size = new Size(116, 44);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Font = new Font("Times New Roman", 13F);
            radNu.Location = new Point(180, 35);
            radNu.Name = "radNu";
            radNu.Size = new Size(92, 44);
            radNu.TabIndex = 1;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Font = new Font("Times New Roman", 13F);
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(300, 455);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(800, 48);
            cboKhoa.TabIndex = 4;
            // 
            // btnHienThi
            // 
            btnHienThi.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            btnHienThi.Location = new Point(300, 525);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(186, 55);
            btnHienThi.TabIndex = 6;
            btnHienThi.Text = "HIỂN THỊ";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            btnXoa.Location = new Point(608, 525);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(186, 55);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            btnThoat.Location = new Point(914, 525);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(186, 55);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1250, 850);
            Controls.Add(lblTitle);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblNamSinh);
            Controls.Add(txtNamSinh);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(grpGioiTinh);
            Controls.Add(lblKhoa);
            Controls.Add(cboKhoa);
            Controls.Add(btnHienThi);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(lblKetQua);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ỨNG DỤNG THÔNG TIN CÁ NHÂN";
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;

        private System.Windows.Forms.ComboBox cboKhoa;

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}
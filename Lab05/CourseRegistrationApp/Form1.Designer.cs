
namespace CourseRegistrationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpHocVien = new GroupBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            chkNhanEmail = new CheckBox();
            grpKhoaHoc = new GroupBox();
            lblTenKhoaHoc = new Label();
            cboKhoaHoc = new ComboBox();
            lblHinhThucHoc = new Label();
            radOnline = new RadioButton();
            radOffline = new RadioButton();
            lblSoThang = new Label();
            numSoThang = new NumericUpDown();
            lblTongTienTitle = new Label();
            lblTongTien = new Label();
            btnDangKy = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            grpHocVien.SuspendLayout();
            grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            SuspendLayout();
            // 
            // grpHocVien
            // 
            grpHocVien.Controls.Add(lblHoTen);
            grpHocVien.Controls.Add(txtHoTen);
            grpHocVien.Controls.Add(lblSoDienThoai);
            grpHocVien.Controls.Add(txtSoDienThoai);
            grpHocVien.Controls.Add(lblNgaySinh);
            grpHocVien.Controls.Add(dtpNgaySinh);
            grpHocVien.Controls.Add(chkNhanEmail);
            grpHocVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpHocVien.Location = new Point(56, 64);
            grpHocVien.Margin = new Padding(6, 6, 6, 6);
            grpHocVien.Name = "grpHocVien";
            grpHocVien.Padding = new Padding(6, 6, 6, 6);
            grpHocVien.Size = new Size(1709, 523);
            grpHocVien.TabIndex = 0;
            grpHocVien.TabStop = false;
            grpHocVien.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(56, 96);
            lblHoTen.Margin = new Padding(6, 0, 6, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(137, 37);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(353, 90);
            txtHoTen.Margin = new Padding(6, 6, 6, 6);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(1222, 43);
            txtHoTen.TabIndex = 0;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            lblSoDienThoai.Location = new Point(56, 192);
            lblSoDienThoai.Margin = new Padding(6, 0, 6, 0);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(180, 37);
            lblSoDienThoai.TabIndex = 1;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(353, 186);
            txtSoDienThoai.Margin = new Padding(6, 6, 6, 6);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(554, 43);
            txtSoDienThoai.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.Location = new Point(56, 288);
            lblNgaySinh.Margin = new Padding(6, 0, 6, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(141, 37);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(353, 282);
            dtpNgaySinh.Margin = new Padding(6, 6, 6, 6);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(554, 43);
            dtpNgaySinh.TabIndex = 2;
            // 
            // chkNhanEmail
            // 
            chkNhanEmail.AutoSize = true;
            chkNhanEmail.Font = new Font("Segoe UI", 10F);
            chkNhanEmail.Location = new Point(353, 384);
            chkNhanEmail.Margin = new Padding(6, 6, 6, 6);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(316, 41);
            chkNhanEmail.TabIndex = 3;
            chkNhanEmail.Text = "Nhận email thông báo";
            chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // grpKhoaHoc
            // 
            grpKhoaHoc.Controls.Add(lblTenKhoaHoc);
            grpKhoaHoc.Controls.Add(cboKhoaHoc);
            grpKhoaHoc.Controls.Add(lblHinhThucHoc);
            grpKhoaHoc.Controls.Add(radOnline);
            grpKhoaHoc.Controls.Add(radOffline);
            grpKhoaHoc.Controls.Add(lblSoThang);
            grpKhoaHoc.Controls.Add(numSoThang);
            grpKhoaHoc.Controls.Add(lblTongTienTitle);
            grpKhoaHoc.Controls.Add(lblTongTien);
            grpKhoaHoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpKhoaHoc.Location = new Point(56, 629);
            grpKhoaHoc.Margin = new Padding(6, 6, 6, 6);
            grpKhoaHoc.Name = "grpKhoaHoc";
            grpKhoaHoc.Padding = new Padding(6, 6, 6, 6);
            grpKhoaHoc.Size = new Size(1709, 576);
            grpKhoaHoc.TabIndex = 1;
            grpKhoaHoc.TabStop = false;
            grpKhoaHoc.Text = "THÔNG TIN KHÓA HỌC";
            // 
            // lblTenKhoaHoc
            // 
            lblTenKhoaHoc.AutoSize = true;
            lblTenKhoaHoc.Font = new Font("Segoe UI", 10F);
            lblTenKhoaHoc.Location = new Point(56, 96);
            lblTenKhoaHoc.Margin = new Padding(6, 0, 6, 0);
            lblTenKhoaHoc.Name = "lblTenKhoaHoc";
            lblTenKhoaHoc.Size = new Size(134, 37);
            lblTenKhoaHoc.TabIndex = 0;
            lblTenKhoaHoc.Text = "Khóa học:";
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoaHoc.Font = new Font("Segoe UI", 10F);
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(353, 90);
            cboKhoaHoc.Margin = new Padding(6, 6, 6, 6);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(1222, 45);
            cboKhoaHoc.TabIndex = 0;
            // 
            // lblHinhThucHoc
            // 
            lblHinhThucHoc.AutoSize = true;
            lblHinhThucHoc.Font = new Font("Segoe UI", 10F);
            lblHinhThucHoc.Location = new Point(56, 203);
            lblHinhThucHoc.Margin = new Padding(6, 0, 6, 0);
            lblHinhThucHoc.Name = "lblHinhThucHoc";
            lblHinhThucHoc.Size = new Size(188, 37);
            lblHinhThucHoc.TabIndex = 1;
            lblHinhThucHoc.Text = "Hình thức học:";
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Font = new Font("Segoe UI", 10F);
            radOnline.Location = new Point(353, 198);
            radOnline.Margin = new Padding(6, 6, 6, 6);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(126, 41);
            radOnline.TabIndex = 1;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            // 
            // radOffline
            // 
            radOffline.AutoSize = true;
            radOffline.Font = new Font("Segoe UI", 10F);
            radOffline.Location = new Point(594, 198);
            radOffline.Margin = new Padding(6, 6, 6, 6);
            radOffline.Name = "radOffline";
            radOffline.Size = new Size(150, 41);
            radOffline.TabIndex = 2;
            radOffline.TabStop = true;
            radOffline.Text = "Trực tiếp";
            radOffline.UseVisualStyleBackColor = true;
            // 
            // lblSoThang
            // 
            lblSoThang.AutoSize = true;
            lblSoThang.Font = new Font("Segoe UI", 10F);
            lblSoThang.Location = new Point(56, 309);
            lblSoThang.Margin = new Padding(6, 0, 6, 0);
            lblSoThang.Name = "lblSoThang";
            lblSoThang.Size = new Size(230, 37);
            lblSoThang.TabIndex = 3;
            lblSoThang.Text = "Số tháng đăng ký:";
            // 
            // numSoThang
            // 
            numSoThang.Font = new Font("Segoe UI", 10F);
            numSoThang.Location = new Point(353, 303);
            numSoThang.Margin = new Padding(6, 6, 6, 6);
            numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "numSoThang";
            numSoThang.Size = new Size(279, 43);
            numSoThang.TabIndex = 3;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTongTienTitle
            // 
            lblTongTienTitle.AutoSize = true;
            lblTongTienTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTienTitle.Location = new Point(56, 427);
            lblTongTienTitle.Margin = new Padding(6, 0, 6, 0);
            lblTongTienTitle.Name = "lblTongTienTitle";
            lblTongTienTitle.Size = new Size(244, 41);
            lblTongTienTitle.TabIndex = 4;
            lblTongTienTitle.Text = "TỔNG HỌC PHÍ:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongTien.Location = new Point(353, 420);
            lblTongTien.Margin = new Padding(6, 0, 6, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(127, 47);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = "0 VNĐ";
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.Location = new Point(288, 1259);
            btnDangKy.Margin = new Padding(6, 6, 6, 6);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(334, 102);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.Location = new Point(743, 1259);
            btnLamMoi.Margin = new Padding(6, 6, 6, 6);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(334, 102);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.Location = new Point(1198, 1259);
            btnThoat.Margin = new Padding(6, 6, 6, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(334, 102);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1453);
            Controls.Add(btnDangKy);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);
            Controls.Add(grpKhoaHoc);
            Controls.Add(grpHocVien);
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(1649, 1306);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG KÝ KHÓA HỌC";
            grpHocVien.ResumeLayout(false);
            grpHocVien.PerformLayout();
            grpKhoaHoc.ResumeLayout(false);
            grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpHocVien;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private CheckBox chkNhanEmail;

        private GroupBox grpKhoaHoc;
        private Label lblTenKhoaHoc;
        private ComboBox cboKhoaHoc;
        private Label lblHinhThucHoc;
        private RadioButton radOnline;
        private RadioButton radOffline;
        private Label lblSoThang;
        private NumericUpDown numSoThang;
        private Label lblTongTienTitle;
        private Label lblTongTien;

        private Button btnDangKy;
        private Button btnLamMoi;
        private Button btnThoat;
    }
}
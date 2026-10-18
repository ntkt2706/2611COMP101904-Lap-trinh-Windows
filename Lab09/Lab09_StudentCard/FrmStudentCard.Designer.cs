namespace Lab09_StudentCard
{
    partial class FrmStudentCard
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.btnPreviewPrint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSavePNG = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKhoaHoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnChooseImg);
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sinh viên";
            // 
            // Các Label và Textbox
            // 
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(20, 40); this.label1.Name = "label1"; this.label1.Text = "Mã SV:";
            this.txtMaSV.Location = new System.Drawing.Point(100, 37); this.txtMaSV.Size = new System.Drawing.Size(160, 20);

            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(20, 75); this.label2.Text = "Họ Tên:";
            this.txtHoTen.Location = new System.Drawing.Point(100, 72); this.txtHoTen.Size = new System.Drawing.Size(160, 20);

            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(20, 110); this.label3.Text = "Ngày sinh:";
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 107); this.dtpNgaySinh.Size = new System.Drawing.Size(160, 20); this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(20, 145); this.label4.Text = "Giới tính:";
            this.cboGioiTinh.Location = new System.Drawing.Point(100, 142); this.cboGioiTinh.Size = new System.Drawing.Size(160, 21); this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });

            this.label5.AutoSize = true; this.label5.Location = new System.Drawing.Point(20, 180); this.label5.Text = "Lớp:";
            this.cboLop.Location = new System.Drawing.Point(100, 177); this.cboLop.Size = new System.Drawing.Size(160, 21); this.cboLop.Items.AddRange(new object[] { "51.CNTT.A", "51.CNTT.B", "51.CNTT.C" });

            this.label6.AutoSize = true; this.label6.Location = new System.Drawing.Point(20, 215); this.label6.Text = "Khoa:";
            this.cboKhoa.Location = new System.Drawing.Point(100, 212); this.cboKhoa.Size = new System.Drawing.Size(160, 21); this.cboKhoa.Items.AddRange(new object[] { "Công nghệ Thông tin", "Toán - Tin học" });

            this.label7.AutoSize = true; this.label7.Location = new System.Drawing.Point(20, 250); this.label7.Text = "Khóa học:";
            this.txtKhoaHoc.Location = new System.Drawing.Point(100, 247); this.txtKhoaHoc.Size = new System.Drawing.Size(160, 20);

            // 
            // Avatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(290, 37);
            this.picAvatar.Size = new System.Drawing.Size(140, 180);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseImg.Location = new System.Drawing.Point(290, 235);
            this.btnChooseImg.Size = new System.Drawing.Size(140, 35);
            this.btnChooseImg.Text = "Chọn Ảnh";

            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.White;
            this.pnlPreview.Location = new System.Drawing.Point(500, 30);
            this.pnlPreview.Size = new System.Drawing.Size(460, 280);

            // 
            // Buttons dưới cùng
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 330); this.btnRefresh.Size = new System.Drawing.Size(100, 40); this.btnRefresh.Text = "Làm mới";

            this.btnExit.Location = new System.Drawing.Point(130, 330); this.btnExit.Size = new System.Drawing.Size(100, 40); this.btnExit.Text = "Thoát";

            this.btnPreviewPrint.Location = new System.Drawing.Point(500, 330); this.btnPreviewPrint.Size = new System.Drawing.Size(110, 40); this.btnPreviewPrint.Text = "Xem trước In";

            this.btnPrint.Location = new System.Drawing.Point(620, 330); this.btnPrint.Size = new System.Drawing.Size(100, 40); this.btnPrint.Text = "In thẻ";

            this.btnSavePNG.Location = new System.Drawing.Point(730, 330); this.btnSavePNG.Size = new System.Drawing.Size(100, 40); this.btnSavePNG.Text = "Lưu PNG";

            this.btnColor.Location = new System.Drawing.Point(840, 330); this.btnColor.Size = new System.Drawing.Size(120, 40); this.btnColor.Text = "Đổi màu nền thẻ";

            // 
            // Print Dialogs
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;

            // 
            // FrmStudentCard
            // 
            this.ClientSize = new System.Drawing.Size(980, 400);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSavePNG);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreviewPrint);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudentCard";
            this.Text = "Thiết kế và In Thẻ Sinh Viên - COMP1019";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKhoaHoc; private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChooseImg; private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.ComboBox cboKhoa; private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLop; private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGioiTinh; private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh; private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen; private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV; private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Button btnPreviewPrint; private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSavePNG; private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit; private System.Windows.Forms.Button btnColor;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}
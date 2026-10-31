namespace QLSinhVienLab12.Forms
{
    partial class FrmNhapDiemTheoLop
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLop = new Label();
            cboLop = new ComboBox();
            lblMonHoc = new Label();
            cboMonHoc = new ComboBox();
            btnTaiDanhSach = new Button();
            dgvKetQua = new DataGridView();
            btnLuuTatCa = new Button();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // lblLop
            lblLop.AutoSize = true;
            lblLop.Location = new Point(20, 23);
            lblLop.Name = "lblLop";
            lblLop.Text = "Lớp:";

            // cboLop
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(70, 20);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(200, 28);

            // lblMonHoc
            lblMonHoc.AutoSize = true;
            lblMonHoc.Location = new Point(290, 23);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Text = "Môn học:";

            // cboMonHoc
            cboMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(370, 20);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(220, 28);

            // btnTaiDanhSach
            btnTaiDanhSach.Location = new Point(610, 18);
            btnTaiDanhSach.Name = "btnTaiDanhSach";
            btnTaiDanhSach.Size = new Size(150, 32);
            btnTaiDanhSach.Text = "Tải danh sách";
            btnTaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiDanhSach.Click += btnTaiDanhSach_Click;

            // dgvKetQua
            dgvKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AllowUserToDeleteRows = false;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(20, 65);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.Size = new Size(740, 320);
            dgvKetQua.DataError += dgvKetQua_DataError;

            // btnLuuTatCa
            btnLuuTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLuuTatCa.Location = new Point(20, 397);
            btnLuuTatCa.Name = "btnLuuTatCa";
            btnLuuTatCa.Size = new Size(150, 36);
            btnLuuTatCa.Text = "Lưu tất cả";
            btnLuuTatCa.UseVisualStyleBackColor = true;
            btnLuuTatCa.Click += btnLuuTatCa_Click;

            // statusStrip1
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip1.Name = "statusStrip1";

            // lblTrangThai
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Text = "Sẵn sàng";

            // FrmNhapDiemTheoLop
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(lblLop);
            Controls.Add(cboLop);
            Controls.Add(lblMonHoc);
            Controls.Add(cboMonHoc);
            Controls.Add(btnTaiDanhSach);
            Controls.Add(dgvKetQua);
            Controls.Add(btnLuuTatCa);
            Controls.Add(statusStrip1);
            Name = "FrmNhapDiemTheoLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập điểm theo lớp";
            Load += FrmNhapDiemTheoLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblLop;
        private ComboBox cboLop;
        private Label lblMonHoc;
        private ComboBox cboMonHoc;
        private Button btnTaiDanhSach;
        private DataGridView dgvKetQua;
        private Button btnLuuTatCa;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
    }
}
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StudentReportDemo.Forms
{
    partial class FrmBaoCaoSinhVien
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
            lblKetQua = new Label();
            cboKetQua = new ComboBox();
            lblTuKhoa = new Label();
            txtTuKhoa = new TextBox();
            btnXemBaoCao = new Button();
            btnThongKe = new Button();
            btnXuatFile = new Button();
            dgvBaoCao = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblThongKe = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
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
            cboLop.Size = new Size(180, 28);

            // lblKetQua
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(270, 23);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Text = "Kết quả:";

            // cboKetQua
            cboKetQua.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKetQua.FormattingEnabled = true;
            cboKetQua.Location = new Point(340, 20);
            cboKetQua.Name = "cboKetQua";
            cboKetQua.Size = new Size(140, 28);

            // lblTuKhoa
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Location = new Point(500, 23);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Text = "Từ khóa:";

            // txtTuKhoa
            txtTuKhoa.Location = new Point(575, 20);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(180, 27);

            // btnXemBaoCao
            btnXemBaoCao.Location = new Point(20, 62);
            btnXemBaoCao.Name = "btnXemBaoCao";
            btnXemBaoCao.Size = new Size(140, 34);
            btnXemBaoCao.Text = "Xem báo cáo";
            btnXemBaoCao.UseVisualStyleBackColor = true;
            btnXemBaoCao.Click += btnXemBaoCao_Click;

            // btnThongKe
            btnThongKe.Location = new Point(175, 62);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(140, 34);
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;

            // btnXuatFile
            btnXuatFile.Location = new Point(330, 62);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(140, 34);
            btnXuatFile.Text = "Xuất file";
            btnXuatFile.UseVisualStyleBackColor = true;
            btnXuatFile.Click += btnXuatFile_Click;

            // dgvBaoCao
            dgvBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToDeleteRows = false;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(20, 110);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.Size = new Size(840, 330);

            // statusStrip1
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongKe });
            statusStrip1.Name = "statusStrip1";

            // lblThongKe
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Text = "Sẵn sàng";

            // FrmBaoCaoSinhVien
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 501);
            Controls.Add(lblLop);
            Controls.Add(cboLop);
            Controls.Add(lblKetQua);
            Controls.Add(cboKetQua);
            Controls.Add(lblTuKhoa);
            Controls.Add(txtTuKhoa);
            Controls.Add(btnXemBaoCao);
            Controls.Add(btnThongKe);
            Controls.Add(btnXuatFile);
            Controls.Add(dgvBaoCao);
            Controls.Add(statusStrip1);
            Name = "FrmBaoCaoSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo sinh viên";
            Load += FrmBaoCaoSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblLop;
        private ComboBox cboLop;
        private Label lblKetQua;
        private ComboBox cboKetQua;
        private Label lblTuKhoa;
        private TextBox txtTuKhoa;
        private Button btnXemBaoCao;
        private Button btnThongKe;
        private Button btnXuatFile;
        private DataGridView dgvBaoCao;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongKe;
    }
}
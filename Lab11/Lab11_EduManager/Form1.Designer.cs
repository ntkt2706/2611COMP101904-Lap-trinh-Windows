namespace Lab11_EduManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaLop, lblTenLop;
        private System.Windows.Forms.TextBox txtMaLop, txtTenLop, txtTimKiem;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi, btnTimKiem;
        private System.Windows.Forms.DataGridView dgvLop;

        // Thêm các Panel động để tự động dàn trang
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.FlowLayoutPanel searchPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchPanel = new System.Windows.Forms.FlowLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.topPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.Text = "Quản lý Lớp Học - Lab 11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Font = new System.Drawing.Font("Segoe UI", 10F); // Đặt font chuẩn chung

            // CẤU HÌNH LƯỚI ĐỘNG (Bảo vệ khỏi Scale 300%)
            this.topPanel.ColumnCount = 3;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize)); // Cột 1 ôm trọn nhãn
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F)); // Cột 2 co giãn TextBox
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize)); // Cột 3 ôm trọn nút bấm
            this.topPanel.RowCount = 2;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top; // Đẩy toàn bộ lên sát mép trên
            this.topPanel.AutoSize = true;
            this.topPanel.Padding = new System.Windows.Forms.Padding(10);

            // Labels (Tự động co giãn theo text)
            this.lblMaLop.Text = "Mã lớp:";
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Anchor = System.Windows.Forms.AnchorStyles.Left;

            this.lblTenLop.Text = "Tên lớp:";
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Anchor = System.Windows.Forms.AnchorStyles.Left;

            // TextBoxes (Neo tự động tràn khung)
            this.txtMaLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            this.txtTimKiem.Width = 250;
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;

            // Buttons (Tự động bung rộng nếu font chữ to ra)
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            this.btnThem.Text = "Thêm";
            this.btnThem.AutoSize = true;
            this.btnThem.Padding = new System.Windows.Forms.Padding(5);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.AutoSize = true;
            this.btnSua.Padding = new System.Windows.Forms.Padding(5);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.AutoSize = true;
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.AutoSize = true;
            this.btnLamMoi.Padding = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // Gom các nút Thêm, Sửa, Xóa vào chung 1 nhóm ngang
            this.buttonPanel.AutoSize = true;
            this.buttonPanel.Controls.Add(this.btnThem);
            this.buttonPanel.Controls.Add(this.btnSua);
            this.buttonPanel.Controls.Add(this.btnXoa);
            this.buttonPanel.Controls.Add(this.btnLamMoi);

            // Gom ô Tìm kiếm và nút Tìm vào nhóm ngang
            this.searchPanel.AutoSize = true;
            this.searchPanel.Controls.Add(this.txtTimKiem);
            this.searchPanel.Controls.Add(this.btnTimKiem);

            // Nạp dữ liệu vào Lưới Động
            this.topPanel.Controls.Add(this.lblMaLop, 0, 0);
            this.topPanel.Controls.Add(this.txtMaLop, 1, 0);
            this.topPanel.Controls.Add(this.searchPanel, 2, 0);

            this.topPanel.Controls.Add(this.lblTenLop, 0, 1);
            this.topPanel.Controls.Add(this.txtTenLop, 1, 1);
            this.topPanel.Controls.Add(this.buttonPanel, 2, 1);

            // DataGridView (Tự động lấp đầy phần khoảng trống còn lại bên dưới)
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.ReadOnly = true;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);

            // Thêm các mảng lớn vào Form
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.topPanel);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
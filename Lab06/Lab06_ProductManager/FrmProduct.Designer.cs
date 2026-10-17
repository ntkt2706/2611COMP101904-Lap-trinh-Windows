namespace Lab06_ProductManager
{
    partial class FrmProduct
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            troGiupToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnRefresh = new ToolStripButton();
            txtSearch = new ToolStripTextBox();
            btnSearch = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCount = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            btnSelectImage = new Button();
            picProduct = new PictureBox();
            chkConKinhDoanh = new CheckBox();
            dtpNgayNhap = new DateTimePicker();
            label6 = new Label();
            numSoLuong = new NumericUpDown();
            label5 = new Label();
            numDonGia = new NumericUpDown();
            label4 = new Label();
            cboLoaiSP = new ComboBox();
            label3 = new Label();
            txtTenSP = new TextBox();
            label2 = new Label();
            txtMaSP = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            contextMenuDgv = new ContextMenuStrip(components);
            mnuSua = new ToolStripMenuItem();
            mnuXoa = new ToolStripMenuItem();
            errProvider = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            contextMenuDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, quanLyToolStripMenuItem, troGiupToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(13, 5, 0, 5);
            menuStrip1.Size = new Size(2058, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(117, 36);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // troGiupToolStripMenuItem
            // 
            troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            troGiupToolStripMenuItem.Size = new Size(122, 36);
            troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRefresh, txtSearch, btnSearch });
            toolStrip1.Location = new Point(0, 46);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 4, 0);
            toolStrip1.Size = new Size(2058, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 36);
            btnRefresh.Text = "Làm mới";
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(429, 42);
            // 
            // btnSearch
            // 
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 36);
            btnSearch.Text = "Tìm kiếm";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCount });
            statusStrip1.Location = new Point(0, 1391);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 30, 0);
            statusStrip1.Size = new Size(2058, 42);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(110, 32);
            lblStatus.Text = "Sẵn sàng";
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(127, 32);
            lblCount.Text = "Tổng SP: 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSelectImage);
            groupBox1.Controls.Add(picProduct);
            groupBox1.Controls.Add(chkConKinhDoanh);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboLoaiSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 148);
            groupBox1.Margin = new Padding(6, 7, 6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 7, 6, 7);
            groupBox1.Size = new Size(693, 1083);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(217, 972);
            btnSelectImage.Margin = new Padding(6, 7, 6, 7);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(260, 74);
            btnSelectImage.TabIndex = 14;
            btnSelectImage.Text = "Chọn ảnh";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // picProduct
            // 
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(217, 640);
            picProduct.Margin = new Padding(6, 7, 6, 7);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(258, 292);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 13;
            picProduct.TabStop = false;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Checked = true;
            chkConKinhDoanh.CheckState = CheckState.Checked;
            chkConKinhDoanh.Location = new Point(217, 554);
            chkConKinhDoanh.Margin = new Padding(6, 7, 6, 7);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(217, 36);
            chkConKinhDoanh.TabIndex = 12;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(217, 468);
            dtpNgayNhap.Margin = new Padding(6, 7, 6, 7);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(429, 39);
            dtpNgayNhap.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 478);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 10;
            label6.Text = "Ngày nhập:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(217, 382);
            numSoLuong.Margin = new Padding(6, 7, 6, 7);
            numSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(433, 39);
            numSoLuong.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 391);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 8;
            label5.Text = "Số lượng:";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(217, 295);
            numDonGia.Margin = new Padding(6, 7, 6, 7);
            numDonGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(433, 39);
            numDonGia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 305);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá:";
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.Location = new Point(217, 209);
            cboLoaiSP.Margin = new Padding(6, 7, 6, 7);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(429, 40);
            cboLoaiSP.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 219);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 4;
            label3.Text = "Loại SP:";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(217, 123);
            txtTenSP.Margin = new Padding(6, 7, 6, 7);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(429, 39);
            txtTenSP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 133);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 2;
            label2.Text = "Tên SP:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(217, 37);
            txtMaSP.Margin = new Padding(6, 7, 6, 7);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(429, 39);
            txtMaSP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 47);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã SP:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(26, 1268);
            btnAdd.Margin = new Padding(6, 7, 6, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 74);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(249, 1268);
            btnEdit.Margin = new Padding(6, 7, 6, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(195, 74);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(472, 1268);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 74);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ContextMenuStrip = contextMenuDgv;
            dgvProducts.Location = new Point(748, 148);
            dgvProducts.Margin = new Padding(6, 7, 6, 7);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1285, 1194);
            dgvProducts.TabIndex = 7;
            // 
            // contextMenuDgv
            // 
            contextMenuDgv.ImageScalingSize = new Size(32, 32);
            contextMenuDgv.Items.AddRange(new ToolStripItem[] { mnuSua, mnuXoa });
            contextMenuDgv.Name = "contextMenuDgv";
            contextMenuDgv.Size = new Size(129, 80);
            // 
            // mnuSua
            // 
            mnuSua.Name = "mnuSua";
            mnuSua.Size = new Size(128, 38);
            mnuSua.Text = "Sửa";
            // 
            // mnuXoa
            // 
            mnuXoa.Name = "mnuXoa";
            mnuXoa.Size = new Size(128, 38);
            mnuXoa.Text = "Xóa";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2058, 1433);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "FrmProduct";
            Text = "Quản lý sản phẩm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            contextMenuDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuDgv;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}
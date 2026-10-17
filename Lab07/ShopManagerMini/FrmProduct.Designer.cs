namespace ShopManagerMini
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();

            this.txtMaSP.Location = new System.Drawing.Point(20, 20); this.txtMaSP.Name = "txtMaSP"; this.txtMaSP.Size = new System.Drawing.Size(120, 20);
            this.txtTenSP.Location = new System.Drawing.Point(150, 20); this.txtTenSP.Name = "txtTenSP"; this.txtTenSP.Size = new System.Drawing.Size(150, 20);

            this.cboLoai.FormattingEnabled = true; this.cboLoai.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng" });
            this.cboLoai.Location = new System.Drawing.Point(310, 20); this.cboLoai.Name = "cboLoai"; this.cboLoai.Size = new System.Drawing.Size(120, 21); this.cboLoai.SelectedIndex = 0;

            this.numGia.Location = new System.Drawing.Point(440, 20); this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 }); this.numGia.Name = "numGia"; this.numGia.Size = new System.Drawing.Size(100, 20);
            this.numSL.Location = new System.Drawing.Point(550, 20); this.numSL.Maximum = new decimal(new int[] { 10000, 0, 0, 0 }); this.numSL.Name = "numSL"; this.numSL.Size = new System.Drawing.Size(80, 20);

            this.btnAdd.Location = new System.Drawing.Point(640, 18); this.btnAdd.Name = "btnAdd"; this.btnAdd.Size = new System.Drawing.Size(75, 25); this.btnAdd.Text = "Thêm"; this.btnAdd.UseVisualStyleBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(725, 18); this.btnDelete.Name = "btnDelete"; this.btnDelete.Size = new System.Drawing.Size(75, 25); this.btnDelete.Text = "Xóa"; this.btnDelete.UseVisualStyleBackColor = true;

            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 60); this.dgvProducts.Name = "dgvProducts"; this.dgvProducts.Size = new System.Drawing.Size(780, 320); this.dgvProducts.TabIndex = 7;

            this.ClientSize = new System.Drawing.Size(820, 400);
            this.Controls.Add(this.dgvProducts); this.Controls.Add(this.btnDelete); this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numSL); this.Controls.Add(this.numGia); this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.txtTenSP); this.Controls.Add(this.txtMaSP);
            this.Name = "FrmProduct"; this.Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.NumericUpDown numSL;
    }
}
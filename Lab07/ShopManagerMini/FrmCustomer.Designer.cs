namespace ShopManagerMini
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();

            this.txtMaKH.Location = new System.Drawing.Point(20, 20); this.txtMaKH.Name = "txtMaKH"; this.txtMaKH.Size = new System.Drawing.Size(120, 20);
            this.txtHoTen.Location = new System.Drawing.Point(150, 20); this.txtHoTen.Name = "txtHoTen"; this.txtHoTen.Size = new System.Drawing.Size(150, 20);
            this.txtSDT.Location = new System.Drawing.Point(310, 20); this.txtSDT.Name = "txtSDT"; this.txtSDT.Size = new System.Drawing.Size(130, 20);

            this.btnAddKH.Location = new System.Drawing.Point(455, 18); this.btnAddKH.Name = "btnAddKH"; this.btnAddKH.Size = new System.Drawing.Size(75, 25); this.btnAddKH.Text = "Thêm KH"; this.btnAddKH.UseVisualStyleBackColor = true;

            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(20, 60); this.dgvCustomers.Name = "dgvCustomers"; this.dgvCustomers.Size = new System.Drawing.Size(650, 320); this.dgvCustomers.TabIndex = 4;

            this.ClientSize = new System.Drawing.Size(690, 400);
            this.Controls.Add(this.dgvCustomers); this.Controls.Add(this.btnAddKH);
            this.Controls.Add(this.txtSDT); this.Controls.Add(this.txtHoTen); this.Controls.Add(this.txtMaKH);
            this.Name = "FrmCustomer"; this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
    }
}
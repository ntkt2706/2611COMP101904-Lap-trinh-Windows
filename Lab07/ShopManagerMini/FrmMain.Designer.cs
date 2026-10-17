namespace ShopManagerMini
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout(); this.statusStrip1.SuspendLayout(); this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuSystem, this.mnuCategory, this.mnuHelp });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0); this.menuStrip1.Name = "menuStrip1"; this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuLogout, this.mnuExit }); this.mnuSystem.Text = "Hệ thống";
            this.mnuLogout.Text = "Đăng xuất"; this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            this.mnuExit.Text = "Thoát"; this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.mnuCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuProduct, this.mnuCustomer }); this.mnuCategory.Text = "Danh mục";
            this.mnuProduct.Text = "Quản lý sản phẩm"; this.mnuProduct.Click += new System.EventHandler(this.mnuProduct_Click);
            this.mnuCustomer.Text = "Quản lý khách hàng"; this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);

            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuAbout }); this.mnuHelp.Text = "Trợ giúp";
            this.mnuAbout.Text = "Giới thiệu"; this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblUserInfo, this.lblTime });
            this.statusStrip1.Location = new System.Drawing.Point(0, 428); this.statusStrip1.Name = "statusStrip1"; this.statusStrip1.Size = new System.Drawing.Size(800, 22);

            this.lblUserInfo.Name = "lblUserInfo"; this.lblUserInfo.Size = new System.Drawing.Size(126, 17); this.lblUserInfo.Text = "Người dùng: Unknown";
            this.lblTime.Name = "lblTime"; this.lblTime.Size = new System.Drawing.Size(659, 17); this.lblTime.Spring = true; this.lblTime.Text = "Thời gian"; this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1); this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true; this.MainMenuStrip = this.menuStrip1; this.Name = "FrmMain"; this.Text = "Shop Manager Mini";
            this.menuStrip1.ResumeLayout(false); this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false); this.statusStrip1.PerformLayout(); this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip1; private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout; private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory; private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer; private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout; private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserInfo; private System.Windows.Forms.ToolStripStatusLabel lblTime;
    }
}
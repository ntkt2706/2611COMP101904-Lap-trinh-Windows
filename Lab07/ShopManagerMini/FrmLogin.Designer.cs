namespace ShopManagerMini
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblUser.AutoSize = true; this.lblUser.Location = new System.Drawing.Point(30, 30); this.lblUser.Name = "lblUser"; this.lblUser.Text = "Username:";
            this.txtUsername.Location = new System.Drawing.Point(100, 27); this.txtUsername.Name = "txtUsername"; this.txtUsername.Size = new System.Drawing.Size(150, 20);

            this.lblPass.AutoSize = true; this.lblPass.Location = new System.Drawing.Point(30, 70); this.lblPass.Name = "lblPass"; this.lblPass.Text = "Password:";
            this.txtPassword.Location = new System.Drawing.Point(100, 67); this.txtPassword.Name = "txtPassword"; this.txtPassword.PasswordChar = '*'; this.txtPassword.Size = new System.Drawing.Size(150, 20);

            this.btnLogin.Location = new System.Drawing.Point(50, 110); this.btnLogin.Name = "btnLogin"; this.btnLogin.Size = new System.Drawing.Size(80, 30); this.btnLogin.Text = "Đăng nhập";
            this.btnExit.Location = new System.Drawing.Point(150, 110); this.btnExit.Name = "btnExit"; this.btnExit.Size = new System.Drawing.Size(80, 30); this.btnExit.Text = "Thoát";

            this.ClientSize = new System.Drawing.Size(290, 170);
            this.Controls.Add(this.btnExit); this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword); this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername); this.Controls.Add(this.lblUser);
            this.Name = "FrmLogin"; this.Text = "Đăng nhập hệ thống";
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.Label lblUser; private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername; private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin; private System.Windows.Forms.Button btnExit;
    }
}
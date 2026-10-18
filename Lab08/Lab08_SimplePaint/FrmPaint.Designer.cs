namespace Lab08_SimplePaint
{
    partial class FrmPaint
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.canvas = new System.Windows.Forms.Panel();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // pnlTools
            this.pnlTools.BackColor = System.Drawing.Color.LightGray;
            this.pnlTools.Controls.Add(this.btnSave);
            this.pnlTools.Controls.Add(this.btnClear);
            this.pnlTools.Controls.Add(this.btnUndo);
            this.pnlTools.Controls.Add(this.pnlColorPreview);
            this.pnlTools.Controls.Add(this.btnColor);
            this.pnlTools.Controls.Add(this.label2);
            this.pnlTools.Controls.Add(this.nudWidth);
            this.pnlTools.Controls.Add(this.label1);
            this.pnlTools.Controls.Add(this.cboMode);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(884, 50);
            // btnSave
            this.btnSave.Location = new System.Drawing.Point(620, 12); this.btnSave.Name = "btnSave"; this.btnSave.Size = new System.Drawing.Size(75, 25); this.btnSave.Text = "Lưu (PNG)"; this.btnSave.UseVisualStyleBackColor = true;
            // btnClear
            this.btnClear.Location = new System.Drawing.Point(530, 12); this.btnClear.Name = "btnClear"; this.btnClear.Size = new System.Drawing.Size(75, 25); this.btnClear.Text = "Clear All"; this.btnClear.UseVisualStyleBackColor = true;
            // btnUndo
            this.btnUndo.Location = new System.Drawing.Point(440, 12); this.btnUndo.Name = "btnUndo"; this.btnUndo.Size = new System.Drawing.Size(75, 25); this.btnUndo.Text = "Undo"; this.btnUndo.UseVisualStyleBackColor = true;
            // pnlColorPreview
            this.pnlColorPreview.BackColor = System.Drawing.Color.Black;
            this.pnlColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorPreview.Location = new System.Drawing.Point(395, 14); this.pnlColorPreview.Name = "pnlColorPreview"; this.pnlColorPreview.Size = new System.Drawing.Size(20, 20);
            // btnColor
            this.btnColor.Location = new System.Drawing.Point(310, 12); this.btnColor.Name = "btnColor"; this.btnColor.Size = new System.Drawing.Size(75, 25); this.btnColor.Text = "Chọn màu"; this.btnColor.UseVisualStyleBackColor = true;
            // label2
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(180, 18); this.label2.Name = "label2"; this.label2.Text = "Độ dày:";
            // nudWidth
            this.nudWidth.Location = new System.Drawing.Point(230, 15); this.nudWidth.Maximum = new decimal(new int[] { 20, 0, 0, 0 }); this.nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 }); this.nudWidth.Name = "nudWidth"; this.nudWidth.Size = new System.Drawing.Size(60, 20); this.nudWidth.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // label1
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(12, 18); this.label1.Name = "label1"; this.label1.Text = "Công cụ:";
            // cboMode
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] { "Pen", "Line", "Rectangle", "Ellipse" });
            this.cboMode.Location = new System.Drawing.Point(70, 14); this.cboMode.Name = "cboMode"; this.cboMode.Size = new System.Drawing.Size(90, 21);
            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 539); this.statusStrip1.Name = "statusStrip1"; this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            // lblStatus
            this.lblStatus.Name = "lblStatus"; this.lblStatus.Size = new System.Drawing.Size(107, 17); this.lblStatus.Text = "Tọa độ: X=0, Y=0";
            // canvas
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 50); this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(884, 489);
            // FrmPaint
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPaint"; this.Text = "Simple Paint - COMP1019";
            this.pnlTools.ResumeLayout(false); this.pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.statusStrip1.ResumeLayout(false); this.statusStrip1.PerformLayout();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel canvas;
    }
}
namespace GraphicsDraw
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.lblWhereX = new System.Windows.Forms.Label();
            this.lblWhereY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolblX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolblY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCls = new System.Windows.Forms.Button();
            this.txtArrayX = new System.Windows.Forms.TextBox();
            this.txtArrayY = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblBrush = new System.Windows.Forms.Label();
            this.cmbSizeBrush = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.Color.White;
            this.pnlPaint.Location = new System.Drawing.Point(12, 12);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(252, 234);
            this.pnlPaint.TabIndex = 0;
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnlPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnlPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblWhereX
            // 
            this.lblWhereX.AutoSize = true;
            this.lblWhereX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWhereX.Location = new System.Drawing.Point(266, 12);
            this.lblWhereX.Name = "lblWhereX";
            this.lblWhereX.Size = new System.Drawing.Size(20, 20);
            this.lblWhereX.TabIndex = 1;
            this.lblWhereX.Text = "x:";
            // 
            // lblWhereY
            // 
            this.lblWhereY.AutoSize = true;
            this.lblWhereY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWhereY.Location = new System.Drawing.Point(359, 12);
            this.lblWhereY.Name = "lblWhereY";
            this.lblWhereY.Size = new System.Drawing.Size(20, 20);
            this.lblWhereY.TabIndex = 2;
            this.lblWhereY.Text = "y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(292, 17);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "x";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(385, 17);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(12, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "y";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolblX,
            this.toolStripStatusLabel2,
            this.toolblY,
            this.toolblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 294);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(450, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel1.Text = "x: ";
            // 
            // toolblX
            // 
            this.toolblX.Name = "toolblX";
            this.toolblX.Size = new System.Drawing.Size(12, 17);
            this.toolblX.Text = "x";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel2.Text = "  y: ";
            // 
            // toolblY
            // 
            this.toolblY.Name = "toolblY";
            this.toolblY.Size = new System.Drawing.Size(13, 17);
            this.toolblY.Text = "y";
            // 
            // toolblStatus
            // 
            this.toolblStatus.Name = "toolblStatus";
            this.toolblStatus.Size = new System.Drawing.Size(367, 17);
            this.toolblStatus.Spring = true;
            this.toolblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(270, 220);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(75, 23);
            this.btnCls.TabIndex = 7;
            this.btnCls.Text = "Clear";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // txtArrayX
            // 
            this.txtArrayX.Location = new System.Drawing.Point(270, 35);
            this.txtArrayX.Multiline = true;
            this.txtArrayX.Name = "txtArrayX";
            this.txtArrayX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrayX.Size = new System.Drawing.Size(75, 179);
            this.txtArrayX.TabIndex = 9;
            // 
            // txtArrayY
            // 
            this.txtArrayY.Location = new System.Drawing.Point(363, 35);
            this.txtArrayY.Multiline = true;
            this.txtArrayY.Name = "txtArrayY";
            this.txtArrayY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrayY.Size = new System.Drawing.Size(75, 179);
            this.txtArrayY.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(363, 220);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblBrush
            // 
            this.lblBrush.AutoSize = true;
            this.lblBrush.Location = new System.Drawing.Point(9, 265);
            this.lblBrush.Name = "lblBrush";
            this.lblBrush.Size = new System.Drawing.Size(71, 13);
            this.lblBrush.TabIndex = 12;
            this.lblBrush.Text = "Size of brush:";
            // 
            // cmbSizeBrush
            // 
            this.cmbSizeBrush.FormattingEnabled = true;
            this.cmbSizeBrush.Items.AddRange(new object[] {
            "Small",
            "Normal",
            "Big"});
            this.cmbSizeBrush.Location = new System.Drawing.Point(86, 262);
            this.cmbSizeBrush.Name = "cmbSizeBrush";
            this.cmbSizeBrush.Size = new System.Drawing.Size(79, 21);
            this.cmbSizeBrush.TabIndex = 13;
            this.cmbSizeBrush.Text = "Small";
            this.cmbSizeBrush.SelectedIndexChanged += new System.EventHandler(this.cmbSizeBrush_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(300, 260);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load and show";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 316);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbSizeBrush);
            this.Controls.Add(this.lblBrush);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtArrayY);
            this.Controls.Add(this.txtArrayX);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblWhereY);
            this.Controls.Add(this.lblWhereX);
            this.Controls.Add(this.pnlPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(466, 355);
            this.MinimumSize = new System.Drawing.Size(466, 355);
            this.Name = "Main";
            this.Text = "Paint and Point";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.Label lblWhereX;
        private System.Windows.Forms.Label lblWhereY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolblX;
        private System.Windows.Forms.ToolStripStatusLabel toolblY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolblStatus;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.TextBox txtArrayX;
        private System.Windows.Forms.TextBox txtArrayY;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblBrush;
        private System.Windows.Forms.ComboBox cmbSizeBrush;
        private System.Windows.Forms.Button btnLoad;
    }
}


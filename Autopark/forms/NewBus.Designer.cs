namespace Autopark
{
    partial class frmNewBus
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
            this.lblDriver = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.lvlService = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.cmbTrack = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(12, 20);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(55, 13);
            this.lblDriver.TabIndex = 0;
            this.lblDriver.Text = "Водитель";
            // 
            // cmbDriver
            // 
            this.cmbDriver.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(180, 17);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(166, 21);
            this.cmbDriver.TabIndex = 1;
            // 
            // lvlService
            // 
            this.lvlService.AutoSize = true;
            this.lvlService.Location = new System.Drawing.Point(12, 58);
            this.lvlService.Name = "lvlService";
            this.lvlService.Size = new System.Drawing.Size(148, 13);
            this.lvlService.TabIndex = 2;
            this.lvlService.Text = "Техническое обслуживание";
            // 
            // cmbService
            // 
            this.cmbService.BackColor = System.Drawing.SystemColors.Control;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(180, 55);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(166, 21);
            this.cmbService.TabIndex = 3;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(12, 103);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(52, 13);
            this.lblTrack.TabIndex = 4;
            this.lblTrack.Text = "Маршрут";
            // 
            // cmbTrack
            // 
            this.cmbTrack.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTrack.FormattingEnabled = true;
            this.cmbTrack.Location = new System.Drawing.Point(180, 100);
            this.cmbTrack.Name = "cmbTrack";
            this.cmbTrack.Size = new System.Drawing.Size(166, 21);
            this.cmbTrack.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmNewBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 221);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTrack);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.lvlService);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.lblDriver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewBus";
            this.Text = "Новый автобус";
            this.Load += new System.EventHandler(this.frmNewBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label lvlService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.ComboBox cmbTrack;
        private System.Windows.Forms.Button btnSave;
    }
}
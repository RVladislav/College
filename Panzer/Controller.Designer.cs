namespace Panzer
{
    partial class Controller_frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller_frmMain));
            this.btnStartPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartPause
            // 
            this.btnStartPause.Location = new System.Drawing.Point(357, 12);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(75, 23);
            this.btnStartPause.TabIndex = 0;
            this.btnStartPause.Text = "Start | Pause";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartStop_Click);
            this.btnStartPause.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Manipulater_Person);
            this.btnStartPause.Leave += new System.EventHandler(this.btnStartStop_Leave);
            // 
            // Controller_frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 331);
            this.Controls.Add(this.btnStartPause);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 370);
            this.MinimumSize = new System.Drawing.Size(460, 370);
            this.Name = "Controller_frmMain";
            this.Text = "Panzer - Razhnov VG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_frmMain_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Manipulater_Person);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartPause;
    }
}


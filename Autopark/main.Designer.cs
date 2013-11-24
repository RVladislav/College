namespace Autopark
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolbtnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnNewBus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnVacation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnAboutProduction = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toollblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblVacation = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnFile,
            this.toolbtnEdit,
            this.toolbtnView,
            this.toolbtnAboutProduction});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(785, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // toolbtnFile
            // 
            this.toolbtnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnSave,
            this.toolbtnExit});
            this.toolbtnFile.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnFile.Image")));
            this.toolbtnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnFile.Name = "toolbtnFile";
            this.toolbtnFile.Size = new System.Drawing.Size(49, 22);
            this.toolbtnFile.Text = "Файл";
            // 
            // toolbtnSave
            // 
            this.toolbtnSave.Name = "toolbtnSave";
            this.toolbtnSave.Size = new System.Drawing.Size(132, 22);
            this.toolbtnSave.Text = "Сохранить";
            // 
            // toolbtnExit
            // 
            this.toolbtnExit.Name = "toolbtnExit";
            this.toolbtnExit.Size = new System.Drawing.Size(132, 22);
            this.toolbtnExit.Text = "Выход";
            this.toolbtnExit.Click += new System.EventHandler(this.toolbtnExit_Click);
            // 
            // toolbtnEdit
            // 
            this.toolbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnNewBus,
            this.toolbtnWorker,
            this.toolbtnVacation});
            this.toolbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnEdit.Image")));
            this.toolbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnEdit.Name = "toolbtnEdit";
            this.toolbtnEdit.Size = new System.Drawing.Size(60, 22);
            this.toolbtnEdit.Text = "Правка";
            // 
            // toolbtnNewBus
            // 
            this.toolbtnNewBus.Name = "toolbtnNewBus";
            this.toolbtnNewBus.Size = new System.Drawing.Size(171, 22);
            this.toolbtnNewBus.Text = "Новый автобус";
            this.toolbtnNewBus.Click += new System.EventHandler(this.toolbtnNewBus_Click);
            // 
            // toolbtnWorker
            // 
            this.toolbtnWorker.Name = "toolbtnWorker";
            this.toolbtnWorker.Size = new System.Drawing.Size(171, 22);
            this.toolbtnWorker.Text = "Новый работник";
            // 
            // toolbtnVacation
            // 
            this.toolbtnVacation.Name = "toolbtnVacation";
            this.toolbtnVacation.Size = new System.Drawing.Size(171, 22);
            this.toolbtnVacation.Text = "Новая должность";
            // 
            // toolbtnView
            // 
            this.toolbtnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnReport});
            this.toolbtnView.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnView.Image")));
            this.toolbtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnView.Name = "toolbtnView";
            this.toolbtnView.Size = new System.Drawing.Size(40, 22);
            this.toolbtnView.Text = "Вид";
            // 
            // toolbtnReport
            // 
            this.toolbtnReport.Name = "toolbtnReport";
            this.toolbtnReport.Size = new System.Drawing.Size(106, 22);
            this.toolbtnReport.Text = "Отчёт";
            this.toolbtnReport.Click += new System.EventHandler(this.toolbtnReport_Click);
            // 
            // toolbtnAboutProduction
            // 
            this.toolbtnAboutProduction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnAboutProduction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnHelp});
            this.toolbtnAboutProduction.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnAboutProduction.Image")));
            this.toolbtnAboutProduction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnAboutProduction.Name = "toolbtnAboutProduction";
            this.toolbtnAboutProduction.Size = new System.Drawing.Size(95, 22);
            this.toolbtnAboutProduction.Text = "О программе";
            // 
            // toolbtnHelp
            // 
            this.toolbtnHelp.Name = "toolbtnHelp";
            this.toolbtnHelp.Size = new System.Drawing.Size(123, 22);
            this.toolbtnHelp.Text = "Помощь";
            this.toolbtnHelp.Click += new System.EventHandler(this.toolbtnHelp_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toollblStatus,
            this.toolProgressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 441);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(785, 21);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toollblStatus
            // 
            this.toollblStatus.Name = "toollblStatus";
            this.toollblStatus.Size = new System.Drawing.Size(120, 15);
            this.toollblStatus.Text = "Программа открыта";
            // 
            // toolProgressBar
            // 
            this.toolProgressBar.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.toolProgressBar.Name = "toolProgressBar";
            this.toolProgressBar.Size = new System.Drawing.Size(100, 15);
            this.toolProgressBar.Value = 100;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblVacation);
            this.pnlMenu.Controls.Add(this.lblWorker);
            this.pnlMenu.Controls.Add(this.lblBus);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 416);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblVacation
            // 
            this.lblVacation.AutoSize = true;
            this.lblVacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVacation.Location = new System.Drawing.Point(3, 91);
            this.lblVacation.Name = "lblVacation";
            this.lblVacation.Size = new System.Drawing.Size(112, 24);
            this.lblVacation.TabIndex = 5;
            this.lblVacation.Text = "Должности";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorker.Location = new System.Drawing.Point(3, 51);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(106, 24);
            this.lblWorker.TabIndex = 4;
            this.lblWorker.Text = "Работники";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBus.Location = new System.Drawing.Point(3, 12);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(98, 24);
            this.lblBus.TabIndex = 3;
            this.lblBus.Text = "Автобусы";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 462);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmMain";
            this.Text = "Автопарк";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnFile;
        private System.Windows.Forms.ToolStripMenuItem toolbtnSave;
        private System.Windows.Forms.ToolStripMenuItem toolbtnExit;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnEdit;
        private System.Windows.Forms.ToolStripMenuItem toolbtnNewBus;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnView;
        private System.Windows.Forms.ToolStripMenuItem toolbtnReport;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnAboutProduction;
        private System.Windows.Forms.ToolStripMenuItem toolbtnHelp;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toollblStatus;
        private System.Windows.Forms.ToolStripProgressBar toolProgressBar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblVacation;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.ToolStripMenuItem toolbtnWorker;
        private System.Windows.Forms.ToolStripMenuItem toolbtnVacation;
    }
}


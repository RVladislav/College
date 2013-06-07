namespace Bilds_Fiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStr = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.литерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOne = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TA_build = new Bilds_Fiz.DS_Build_FizTableAdapters.BuildTableAdapter();
            this.TA_buildAbout = new Bilds_Fiz.DS_Build_FizTableAdapters.Build_AboutTableAdapter();
            this.TA_buildAboutS = new Bilds_Fiz.DS_Build_FizTableAdapters.Build_About_STableAdapter();
            this.TA_liter = new Bilds_Fiz.DS_Build_FizTableAdapters.LiterTableAdapter();
            this.TA_buildAllInfo = new Bilds_Fiz.DS_Build_FizTableAdapters.BuildAllInfoTableAdapter();
            this.BS_build = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Build_Fiz = new Bilds_Fiz.DS_Build_Fiz();
            this.BS_buildAbout = new System.Windows.Forms.BindingSource(this.components);
            this.BS_buildAboutS = new System.Windows.Forms.BindingSource(this.components);
            this.BS_liter = new System.Windows.Forms.BindingSource(this.components);
            this.BS_buildAllInfo = new System.Windows.Forms.BindingSource(this.components);
            this.BS_buildLiter = new System.Windows.Forms.BindingSource(this.components);
            this.TA_build_Liter = new Bilds_Fiz.DS_Build_FizTableAdapters.Build_LiterTableAdapter();
            this.menuStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_build)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Build_Fiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAboutS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_liter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAllInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildLiter)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStr
            // 
            this.menuStr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.вДокументToolStripMenuItem});
            this.menuStr.Location = new System.Drawing.Point(0, 461);
            this.menuStr.Name = "menuStr";
            this.menuStr.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStr.Size = new System.Drawing.Size(912, 24);
            this.menuStr.TabIndex = 0;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.домToolStripMenuItem,
            this.литерToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // домToolStripMenuItem
            // 
            this.домToolStripMenuItem.Name = "домToolStripMenuItem";
            this.домToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.домToolStripMenuItem.Text = "Дом";
            this.домToolStripMenuItem.Click += new System.EventHandler(this.домToolStripMenuItem_Click);
            // 
            // литерToolStripMenuItem
            // 
            this.литерToolStripMenuItem.Name = "литерToolStripMenuItem";
            this.литерToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.литерToolStripMenuItem.Text = "Литер";
            this.литерToolStripMenuItem.Click += new System.EventHandler(this.литерToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheAutorToolStripMenuItem,
            this.programmToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aboutToolStripMenuItem.Text = "Информация";
            // 
            // aboutTheAutorToolStripMenuItem
            // 
            this.aboutTheAutorToolStripMenuItem.Name = "aboutTheAutorToolStripMenuItem";
            this.aboutTheAutorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutTheAutorToolStripMenuItem.Text = "Автор";
            this.aboutTheAutorToolStripMenuItem.Click += new System.EventHandler(this.aboutTheAutorToolStripMenuItem_Click);
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.programmToolStripMenuItem.Text = "О программе";
            this.programmToolStripMenuItem.Click += new System.EventHandler(this.programmToolStripMenuItem_Click);
            // 
            // вДокументToolStripMenuItem
            // 
            this.вДокументToolStripMenuItem.Name = "вДокументToolStripMenuItem";
            this.вДокументToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.вДокументToolStripMenuItem.Text = "В документ ->";
            this.вДокументToolStripMenuItem.Click += new System.EventHandler(this.вДокументToolStripMenuItem_Click);
            // 
            // dgvOne
            // 
            this.dgvOne.AllowUserToAddRows = false;
            this.dgvOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOne.Location = new System.Drawing.Point(332, 19);
            this.dgvOne.Name = "dgvOne";
            this.dgvOne.Size = new System.Drawing.Size(557, 438);
            this.dgvOne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Дома. Кратко";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Литеры";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Дома";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(244, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(244, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TA_build
            // 
            this.TA_build.ClearBeforeFill = true;
            // 
            // TA_buildAbout
            // 
            this.TA_buildAbout.ClearBeforeFill = true;
            // 
            // TA_buildAboutS
            // 
            this.TA_buildAboutS.ClearBeforeFill = true;
            // 
            // TA_liter
            // 
            this.TA_liter.ClearBeforeFill = true;
            // 
            // TA_buildAllInfo
            // 
            this.TA_buildAllInfo.ClearBeforeFill = true;
            // 
            // BS_build
            // 
            this.BS_build.DataMember = "Build";
            this.BS_build.DataSource = this.DS_Build_Fiz;
            // 
            // DS_Build_Fiz
            // 
            this.DS_Build_Fiz.DataSetName = "DS_Build_Fiz";
            this.DS_Build_Fiz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_buildAbout
            // 
            this.BS_buildAbout.DataMember = "Build_About";
            this.BS_buildAbout.DataSource = this.DS_Build_Fiz;
            // 
            // BS_buildAboutS
            // 
            this.BS_buildAboutS.DataMember = "Build_About_S";
            this.BS_buildAboutS.DataSource = this.DS_Build_Fiz;
            // 
            // BS_liter
            // 
            this.BS_liter.DataMember = "Liter";
            this.BS_liter.DataSource = this.DS_Build_Fiz;
            // 
            // BS_buildAllInfo
            // 
            this.BS_buildAllInfo.DataMember = "BuildAllInfo";
            this.BS_buildAllInfo.DataSource = this.DS_Build_Fiz;
            // 
            // BS_buildLiter
            // 
            this.BS_buildLiter.DataMember = "Build_Liter";
            this.BS_buildLiter.DataSource = this.DS_Build_Fiz;
            // 
            // TA_build_Liter
            // 
            this.TA_build_Liter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 485);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvOne);
            this.Controls.Add(this.menuStr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStr;
            this.Name = "frmMain";
            this.Text = "Частное домовладение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStr.ResumeLayout(false);
            this.menuStr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_build)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Build_Fiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAboutS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_liter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAllInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildLiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_Build_Fiz DS_Build_Fiz;
        private DS_Build_FizTableAdapters.BuildTableAdapter TA_build;
        private System.Windows.Forms.MenuStrip menuStr;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.BindingSource BS_build;
        private System.Windows.Forms.BindingSource BS_buildAbout;
        private DS_Build_FizTableAdapters.Build_AboutTableAdapter TA_buildAbout;
        private System.Windows.Forms.BindingSource BS_buildAboutS;
        private DS_Build_FizTableAdapters.Build_About_STableAdapter TA_buildAboutS;
        private System.Windows.Forms.BindingSource BS_liter;
        private DS_Build_FizTableAdapters.LiterTableAdapter TA_liter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem домToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem литерToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource BS_buildAllInfo;
        private DS_Build_FizTableAdapters.BuildAllInfoTableAdapter TA_buildAllInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource BS_buildLiter;
        private DS_Build_FizTableAdapters.Build_LiterTableAdapter TA_build_Liter;
        private System.Windows.Forms.ToolStripMenuItem вДокументToolStripMenuItem;
    }
}
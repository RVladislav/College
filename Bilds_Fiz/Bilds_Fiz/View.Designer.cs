namespace Bilds_Fiz
{
    partial class frmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView));
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.TA_build = new Bilds_Fiz.DS_Build_FizTableAdapters.BuildTableAdapter();
            this.TA_buildAbout = new Bilds_Fiz.DS_Build_FizTableAdapters.Build_AboutTableAdapter();
            this.TA_buildAboutS = new Bilds_Fiz.DS_Build_FizTableAdapters.Build_About_STableAdapter();
            this.TA_liter = new Bilds_Fiz.DS_Build_FizTableAdapters.LiterTableAdapter();
            this.dS_Build_Fiz = new Bilds_Fiz.DS_Build_Fiz();
            this.BS_build = new System.Windows.Forms.BindingSource(this.components);
            this.BS_buildAbout = new System.Windows.Forms.BindingSource(this.components);
            this.BS_buildAboutS = new System.Windows.Forms.BindingSource(this.components);
            this.BS_liter = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Build_Fiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_build)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAboutS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_liter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 12);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.Size = new System.Drawing.Size(727, 511);
            this.dgvView.TabIndex = 0;
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
            // dS_Build_Fiz
            // 
            this.dS_Build_Fiz.DataSetName = "DS_Build_Fiz";
            this.dS_Build_Fiz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_build
            // 
            this.BS_build.DataMember = "Build";
            this.BS_build.DataSource = this.dS_Build_Fiz;
            // 
            // BS_buildAbout
            // 
            this.BS_buildAbout.DataMember = "Build_About";
            this.BS_buildAbout.DataSource = this.dS_Build_Fiz;
            // 
            // BS_buildAboutS
            // 
            this.BS_buildAboutS.DataMember = "Build_About_S";
            this.BS_buildAboutS.DataSource = this.dS_Build_Fiz;
            // 
            // BS_liter
            // 
            this.BS_liter.DataMember = "Liter";
            this.BS_liter.DataSource = this.dS_Build_Fiz;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 535);
            this.Controls.Add(this.dgvView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View";
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Build_Fiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_build)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_buildAboutS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_liter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private DS_Build_Fiz dS_Build_Fiz;
        private System.Windows.Forms.BindingSource BS_build;
        private DS_Build_FizTableAdapters.BuildTableAdapter TA_build;
        private System.Windows.Forms.BindingSource BS_buildAbout;
        private DS_Build_FizTableAdapters.Build_AboutTableAdapter TA_buildAbout;
        private System.Windows.Forms.BindingSource BS_buildAboutS;
        private DS_Build_FizTableAdapters.Build_About_STableAdapter TA_buildAboutS;
        private System.Windows.Forms.BindingSource BS_liter;
        private DS_Build_FizTableAdapters.LiterTableAdapter TA_liter;
    }
}
namespace Bilds_Fiz
{
    partial class frmAdd_Liter
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtWhyBuild = new System.Windows.Forms.TextBox();
            this.chbMyself = new System.Windows.Forms.CheckBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAllarea = new System.Windows.Forms.TextBox();
            this.txtLivearea = new System.Windows.Forms.TextBox();
            this.txtbreakBuild = new System.Windows.Forms.TextBox();
            this.txtWall = new System.Windows.Forms.TextBox();
            this.txtCoast = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.txtRoomsWhy = new System.Windows.Forms.TextBox();
            this.txtRoomsArea = new System.Windows.Forms.TextBox();
            this.txtRoomsHight = new System.Windows.Forms.TextBox();
            this.txtRoomsFloor = new System.Windows.Forms.TextBox();
            this.grbLiter = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAdditional = new System.Windows.Forms.RadioButton();
            this.rbMain = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbNumberBuild = new System.Windows.Forms.ComboBox();
            this.BS_build = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Build_Fiz = new Bilds_Fiz.DS_Build_Fiz();
            this.TA_build = new Bilds_Fiz.DS_Build_FizTableAdapters.BuildTableAdapter();
            this.grbLiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_build)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Build_Fiz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 612);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 612);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Номер сооружения (литер)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Назначение сооружения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Возведено самовольно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Год постройки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Общая площадь литеры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Жилая площадь";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Инвентаризационная стоимость литеры";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Материал стен";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Износ в процентах";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Назначение помещения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Количество помещений в эксплотации";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Этажность";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Площадь помещения";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Этаж размещения помещения";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 499);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Высота помещения";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(266, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(122, 20);
            this.txtNumber.TabIndex = 56;
            // 
            // txtWhyBuild
            // 
            this.txtWhyBuild.Location = new System.Drawing.Point(266, 41);
            this.txtWhyBuild.Name = "txtWhyBuild";
            this.txtWhyBuild.Size = new System.Drawing.Size(122, 20);
            this.txtWhyBuild.TabIndex = 57;
            // 
            // chbMyself
            // 
            this.chbMyself.AutoSize = true;
            this.chbMyself.Location = new System.Drawing.Point(323, 111);
            this.chbMyself.Name = "chbMyself";
            this.chbMyself.Size = new System.Drawing.Size(15, 14);
            this.chbMyself.TabIndex = 59;
            this.chbMyself.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(266, 140);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(122, 20);
            this.txtYear.TabIndex = 60;
            // 
            // txtAllarea
            // 
            this.txtAllarea.Location = new System.Drawing.Point(266, 175);
            this.txtAllarea.Name = "txtAllarea";
            this.txtAllarea.Size = new System.Drawing.Size(122, 20);
            this.txtAllarea.TabIndex = 61;
            // 
            // txtLivearea
            // 
            this.txtLivearea.Location = new System.Drawing.Point(266, 210);
            this.txtLivearea.Name = "txtLivearea";
            this.txtLivearea.Size = new System.Drawing.Size(122, 20);
            this.txtLivearea.TabIndex = 62;
            // 
            // txtbreakBuild
            // 
            this.txtbreakBuild.Location = new System.Drawing.Point(266, 245);
            this.txtbreakBuild.Name = "txtbreakBuild";
            this.txtbreakBuild.Size = new System.Drawing.Size(122, 20);
            this.txtbreakBuild.TabIndex = 63;
            // 
            // txtWall
            // 
            this.txtWall.Location = new System.Drawing.Point(266, 280);
            this.txtWall.Name = "txtWall";
            this.txtWall.Size = new System.Drawing.Size(122, 20);
            this.txtWall.TabIndex = 64;
            // 
            // txtCoast
            // 
            this.txtCoast.Location = new System.Drawing.Point(266, 315);
            this.txtCoast.Name = "txtCoast";
            this.txtCoast.Size = new System.Drawing.Size(122, 20);
            this.txtCoast.TabIndex = 65;
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(266, 350);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(122, 20);
            this.txtFloor.TabIndex = 66;
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(266, 385);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(122, 20);
            this.txtRooms.TabIndex = 67;
            // 
            // txtRoomsWhy
            // 
            this.txtRoomsWhy.Location = new System.Drawing.Point(266, 420);
            this.txtRoomsWhy.Name = "txtRoomsWhy";
            this.txtRoomsWhy.Size = new System.Drawing.Size(122, 20);
            this.txtRoomsWhy.TabIndex = 68;
            // 
            // txtRoomsArea
            // 
            this.txtRoomsArea.Location = new System.Drawing.Point(266, 455);
            this.txtRoomsArea.Name = "txtRoomsArea";
            this.txtRoomsArea.Size = new System.Drawing.Size(122, 20);
            this.txtRoomsArea.TabIndex = 69;
            // 
            // txtRoomsHight
            // 
            this.txtRoomsHight.Location = new System.Drawing.Point(266, 490);
            this.txtRoomsHight.Name = "txtRoomsHight";
            this.txtRoomsHight.Size = new System.Drawing.Size(122, 20);
            this.txtRoomsHight.TabIndex = 70;
            // 
            // txtRoomsFloor
            // 
            this.txtRoomsFloor.Location = new System.Drawing.Point(266, 527);
            this.txtRoomsFloor.Name = "txtRoomsFloor";
            this.txtRoomsFloor.Size = new System.Drawing.Size(122, 20);
            this.txtRoomsFloor.TabIndex = 71;
            // 
            // grbLiter
            // 
            this.grbLiter.Controls.Add(this.label3);
            this.grbLiter.Controls.Add(this.rbAdditional);
            this.grbLiter.Controls.Add(this.rbMain);
            this.grbLiter.Location = new System.Drawing.Point(5, 65);
            this.grbLiter.Name = "grbLiter";
            this.grbLiter.Size = new System.Drawing.Size(383, 40);
            this.grbLiter.TabIndex = 72;
            this.grbLiter.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Тип литеры";
            // 
            // rbAdditional
            // 
            this.rbAdditional.AutoSize = true;
            this.rbAdditional.Location = new System.Drawing.Point(281, 14);
            this.rbAdditional.Name = "rbAdditional";
            this.rbAdditional.Size = new System.Drawing.Size(89, 17);
            this.rbAdditional.TabIndex = 74;
            this.rbAdditional.Text = "Добавочный";
            this.rbAdditional.UseVisualStyleBackColor = true;
            // 
            // rbMain
            // 
            this.rbMain.AutoSize = true;
            this.rbMain.Checked = true;
            this.rbMain.Location = new System.Drawing.Point(200, 14);
            this.rbMain.Name = "rbMain";
            this.rbMain.Size = new System.Drawing.Size(75, 17);
            this.rbMain.TabIndex = 73;
            this.rbMain.TabStop = true;
            this.rbMain.Text = "Основной";
            this.rbMain.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 566);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "Номер дома";
            // 
            // cmbNumberBuild
            // 
            this.cmbNumberBuild.DataSource = this.BS_build;
            this.cmbNumberBuild.DisplayMember = "Здание #";
            this.cmbNumberBuild.FormattingEnabled = true;
            this.cmbNumberBuild.Location = new System.Drawing.Point(267, 558);
            this.cmbNumberBuild.Name = "cmbNumberBuild";
            this.cmbNumberBuild.Size = new System.Drawing.Size(121, 21);
            this.cmbNumberBuild.TabIndex = 75;
            this.cmbNumberBuild.ValueMember = "Здание #";
            // 
            // BS_build
            // 
            this.BS_build.DataMember = "Build";
            this.BS_build.DataSource = this.dS_Build_Fiz;
            // 
            // dS_Build_Fiz
            // 
            this.dS_Build_Fiz.DataSetName = "DS_Build_Fiz";
            this.dS_Build_Fiz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_build
            // 
            this.TA_build.ClearBeforeFill = true;
            // 
            // frmAdd_Liter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 647);
            this.Controls.Add(this.cmbNumberBuild);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.grbLiter);
            this.Controls.Add(this.txtRoomsFloor);
            this.Controls.Add(this.txtRoomsHight);
            this.Controls.Add(this.txtRoomsArea);
            this.Controls.Add(this.txtRoomsWhy);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtCoast);
            this.Controls.Add(this.txtWall);
            this.Controls.Add(this.txtbreakBuild);
            this.Controls.Add(this.txtLivearea);
            this.Controls.Add(this.txtAllarea);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.chbMyself);
            this.Controls.Add(this.txtWhyBuild);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd_Liter";
            this.Text = "Добавление литера";
            this.Load += new System.EventHandler(this.frmAdd_Liter_Load);
            this.grbLiter.ResumeLayout(false);
            this.grbLiter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_build)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Build_Fiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtWhyBuild;
        private System.Windows.Forms.CheckBox chbMyself;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAllarea;
        private System.Windows.Forms.TextBox txtLivearea;
        private System.Windows.Forms.TextBox txtbreakBuild;
        private System.Windows.Forms.TextBox txtWall;
        private System.Windows.Forms.TextBox txtCoast;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.TextBox txtRoomsWhy;
        private System.Windows.Forms.TextBox txtRoomsArea;
        private System.Windows.Forms.TextBox txtRoomsHight;
        private System.Windows.Forms.TextBox txtRoomsFloor;
        private System.Windows.Forms.GroupBox grbLiter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAdditional;
        private System.Windows.Forms.RadioButton rbMain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbNumberBuild;
        private DS_Build_Fiz dS_Build_Fiz;
        private System.Windows.Forms.BindingSource BS_build;
        private DS_Build_FizTableAdapters.BuildTableAdapter TA_build;
    }
}
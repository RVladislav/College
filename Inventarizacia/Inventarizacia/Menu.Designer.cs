namespace Inventarizacia
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
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(12, 12);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(163, 489);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Сотрудники";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(181, 12);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(163, 489);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "Кабинеты";
            this.btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(350, 12);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(163, 489);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Инвентарь";
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(519, 12);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(163, 489);
            this.btnStorage.TabIndex = 3;
            this.btnStorage.Text = "Склад";
            this.btnStorage.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 513);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnStaff);
            this.Name = "frmMain";
            this.Text = "Инвентаризация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnStorage;
    }
}


namespace роект
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOpenAdvertisement = new System.Windows.Forms.Button();
            this.buttonOpenNewspapers = new System.Windows.Forms.Button();
            this.buttonOpenOrganizations = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenAdvertisement
            // 
            this.buttonOpenAdvertisement.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenAdvertisement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAdvertisement.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAdvertisement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenAdvertisement.Location = new System.Drawing.Point(67, 331);
            this.buttonOpenAdvertisement.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenAdvertisement.Name = "buttonOpenAdvertisement";
            this.buttonOpenAdvertisement.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenAdvertisement.TabIndex = 11;
            this.buttonOpenAdvertisement.Text = "Реклама";
            this.buttonOpenAdvertisement.UseVisualStyleBackColor = false;
            this.buttonOpenAdvertisement.Click += new System.EventHandler(this.buttonOpenAdvertisement_Click);
            // 
            // buttonOpenNewspapers
            // 
            this.buttonOpenNewspapers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenNewspapers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenNewspapers.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenNewspapers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenNewspapers.Location = new System.Drawing.Point(67, 272);
            this.buttonOpenNewspapers.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenNewspapers.Name = "buttonOpenNewspapers";
            this.buttonOpenNewspapers.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenNewspapers.TabIndex = 10;
            this.buttonOpenNewspapers.Text = "Газеты";
            this.buttonOpenNewspapers.UseVisualStyleBackColor = false;
            this.buttonOpenNewspapers.Click += new System.EventHandler(this.buttonOpenNewspapers_Click);
            // 
            // buttonOpenOrganizations
            // 
            this.buttonOpenOrganizations.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenOrganizations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenOrganizations.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenOrganizations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenOrganizations.Location = new System.Drawing.Point(67, 212);
            this.buttonOpenOrganizations.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenOrganizations.Name = "buttonOpenOrganizations";
            this.buttonOpenOrganizations.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenOrganizations.TabIndex = 9;
            this.buttonOpenOrganizations.Text = "Организации";
            this.buttonOpenOrganizations.UseVisualStyleBackColor = false;
            this.buttonOpenOrganizations.Click += new System.EventHandler(this.buttonOpenOrganizations_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(398, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenAdvertisement);
            this.Controls.Add(this.buttonOpenNewspapers);
            this.Controls.Add(this.buttonOpenOrganizations);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenAdvertisement;
        private System.Windows.Forms.Button buttonOpenNewspapers;
        private System.Windows.Forms.Button buttonOpenOrganizations;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


﻿namespace роект
{
    partial class FormNewspepars
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
            this.listViewOrg = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPrise = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewOrg
            // 
            this.listViewOrg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2});
            this.listViewOrg.FullRowSelect = true;
            this.listViewOrg.GridLines = true;
            this.listViewOrg.HideSelection = false;
            this.listViewOrg.Location = new System.Drawing.Point(125, 12);
            this.listViewOrg.MultiSelect = false;
            this.listViewOrg.Name = "listViewOrg";
            this.listViewOrg.Size = new System.Drawing.Size(468, 264);
            this.listViewOrg.TabIndex = 53;
            this.listViewOrg.UseCompatibleStateImageBehavior = false;
            this.listViewOrg.View = System.Windows.Forms.View.Details;
            this.listViewOrg.SelectedIndexChanged += new System.EventHandler(this.listViewNewspepar_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Id";
            this.columnHeader0.Width = 46;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название газеты";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Почта";
            this.columnHeader5.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена рекламы";
            this.columnHeader2.Width = 131;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(518, 282);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 38);
            this.buttonDel.TabIndex = 52;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(422, 282);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 38);
            this.buttonEdit.TabIndex = 51;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(320, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 38);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(10, 148);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 49;
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrise.Location = new System.Drawing.Point(10, 95);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrise.TabIndex = 48;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(10, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 47;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(9, 130);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 15);
            this.labelEmail.TabIndex = 46;
            this.labelEmail.Text = "Почта";
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrise.Location = new System.Drawing.Point(7, 77);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(95, 15);
            this.labelPrise.TabIndex = 45;
            this.labelPrise.Text = "Цена рекламы";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(7, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 15);
            this.labelName.TabIndex = 44;
            this.labelName.Text = "Название газеты";
            // 
            // FormNewspepars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 331);
            this.Controls.Add(this.listViewOrg);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPrise);
            this.Controls.Add(this.labelName);
            this.Name = "FormNewspepars";
            this.Text = "Газеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrg;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.Label labelName;
    }
}
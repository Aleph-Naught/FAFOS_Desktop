﻿namespace FAFOS
{
    partial class HQUserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HQUserForm));
            this.FranchiseGridView = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusiNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiscalYrEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHQ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpRegionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addFranButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.ProvBox = new System.Windows.Forms.ComboBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.AddRegionBtn = new System.Windows.Forms.Button();
            this.DeleteRegionBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FranchiseGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FranchiseGridView
            // 
            this.FranchiseGridView.AllowUserToAddRows = false;
            this.FranchiseGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranchiseGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FranchiseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FranchiseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.ComName,
            this.taxNum,
            this.BusiNum,
            this.FiscalYrEnd,
            this.zoneID,
            this.isHQ,
            this.deleteButton});
            this.FranchiseGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.FranchiseGridView.Location = new System.Drawing.Point(17, 204);
            this.FranchiseGridView.Name = "FranchiseGridView";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranchiseGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FranchiseGridView.Size = new System.Drawing.Size(660, 241);
            this.FranchiseGridView.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 50;
            // 
            // ComName
            // 
            this.ComName.HeaderText = "Name";
            this.ComName.Name = "ComName";
            this.ComName.Width = 150;
            // 
            // taxNum
            // 
            this.taxNum.HeaderText = "Tax Reg.";
            this.taxNum.Name = "taxNum";
            this.taxNum.Width = 130;
            // 
            // BusiNum
            // 
            this.BusiNum.HeaderText = "B.N.";
            this.BusiNum.Name = "BusiNum";
            this.BusiNum.Width = 130;
            // 
            // FiscalYrEnd
            // 
            this.FiscalYrEnd.HeaderText = "Fiscal Year End";
            this.FiscalYrEnd.Name = "FiscalYrEnd";
            this.FiscalYrEnd.Width = 60;
            // 
            // zoneID
            // 
            this.zoneID.HeaderText = "Zone ID";
            this.zoneID.Name = "zoneID";
            this.zoneID.Visible = false;
            this.zoneID.Width = 60;
            // 
            // isHQ
            // 
            this.isHQ.HeaderText = "HQ";
            this.isHQ.Name = "isHQ";
            this.isHQ.Width = 40;
            // 
            // deleteButton
            // 
            this.deleteButton.HeaderText = "Delete";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Width = 55;
            // 
            // OpRegionCombo
            // 
            this.OpRegionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpRegionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpRegionCombo.FormattingEnabled = true;
            this.OpRegionCombo.Location = new System.Drawing.Point(16, 30);
            this.OpRegionCombo.Name = "OpRegionCombo";
            this.OpRegionCombo.Size = new System.Drawing.Size(426, 21);
            this.OpRegionCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operational Regions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Franchisees";
            // 
            // addFranButton
            // 
            this.addFranButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.addFranButton.FlatAppearance.BorderSize = 0;
            this.addFranButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFranButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFranButton.ForeColor = System.Drawing.Color.White;
            this.addFranButton.Location = new System.Drawing.Point(12, 460);
            this.addFranButton.Name = "addFranButton";
            this.addFranButton.Size = new System.Drawing.Size(134, 33);
            this.addFranButton.TabIndex = 66;
            this.addFranButton.Text = "Add Franchise";
            this.addFranButton.UseVisualStyleBackColor = false;
            this.addFranButton.Visible = false;
            this.addFranButton.Click += new System.EventHandler(this.addFranButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CityBox);
            this.groupBox1.Controls.Add(this.ProvBox);
            this.groupBox1.Controls.Add(this.CountryBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TitleTxtBox);
            this.groupBox1.Controls.Add(this.AddRegionBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(17, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 87);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Region";
            // 
            // CityBox
            // 
            this.CityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(426, 48);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(136, 21);
            this.CityBox.TabIndex = 72;
            // 
            // ProvBox
            // 
            this.ProvBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvBox.FormattingEnabled = true;
            this.ProvBox.Location = new System.Drawing.Point(284, 48);
            this.ProvBox.Name = "ProvBox";
            this.ProvBox.Size = new System.Drawing.Size(136, 21);
            this.ProvBox.TabIndex = 71;
            // 
            // CountryBox
            // 
            this.CountryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(162, 47);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(115, 21);
            this.CountryBox.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Region Title";
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.Location = new System.Drawing.Point(12, 48);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(142, 20);
            this.TitleTxtBox.TabIndex = 69;
            // 
            // AddRegionBtn
            // 
            this.AddRegionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.AddRegionBtn.FlatAppearance.BorderSize = 0;
            this.AddRegionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRegionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRegionBtn.ForeColor = System.Drawing.Color.White;
            this.AddRegionBtn.Location = new System.Drawing.Point(448, 14);
            this.AddRegionBtn.Name = "AddRegionBtn";
            this.AddRegionBtn.Size = new System.Drawing.Size(122, 26);
            this.AddRegionBtn.TabIndex = 68;
            this.AddRegionBtn.Text = "Add Region";
            this.AddRegionBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteRegionBtn
            // 
            this.DeleteRegionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.DeleteRegionBtn.FlatAppearance.BorderSize = 0;
            this.DeleteRegionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRegionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRegionBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteRegionBtn.Location = new System.Drawing.Point(465, 22);
            this.DeleteRegionBtn.Name = "DeleteRegionBtn";
            this.DeleteRegionBtn.Size = new System.Drawing.Size(122, 32);
            this.DeleteRegionBtn.TabIndex = 68;
            this.DeleteRegionBtn.Text = "Delete Region";
            this.DeleteRegionBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(602, 466);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 73;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // HQUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 510);
            this.Controls.Add(this.addFranButton);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteRegionBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpRegionCombo);
            this.Controls.Add(this.FranchiseGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HQUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HQUserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit_clicked);
            ((System.ComponentModel.ISupportInitialize)(this.FranchiseGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FranchiseGridView;
        private System.Windows.Forms.ComboBox OpRegionCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addFranButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.ComboBox ProvBox;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.Button AddRegionBtn;
        private System.Windows.Forms.Button DeleteRegionBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusiNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiscalYrEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isHQ;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}
namespace FAFOS
{
    partial class RoyaltyFeeCollection
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
            this.franchiseeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.royalteeFees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.show_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.royalteeFees)).BeginInit();
            this.SuspendLayout();
            // 
            // franchiseeBox
            // 
            this.franchiseeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.franchiseeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.franchiseeBox.FormattingEnabled = true;
            this.franchiseeBox.Location = new System.Drawing.Point(15, 111);
            this.franchiseeBox.Margin = new System.Windows.Forms.Padding(2);
            this.franchiseeBox.Name = "franchiseeBox";
            this.franchiseeBox.Size = new System.Drawing.Size(222, 25);
            this.franchiseeBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Select Franchisee:";
            // 
            // royalteeFees
            // 
            this.royalteeFees.AccessibleDescription = "";
            this.royalteeFees.AllowUserToAddRows = false;
            this.royalteeFees.AllowUserToDeleteRows = false;
            this.royalteeFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.royalteeFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.royalteeFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.royalteeFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Month,
            this.Percentage,
            this.BalanceOwed});
            this.royalteeFees.Location = new System.Drawing.Point(11, 152);
            this.royalteeFees.Margin = new System.Windows.Forms.Padding(2);
            this.royalteeFees.Name = "royalteeFees";
            this.royalteeFees.ReadOnly = true;
            this.royalteeFees.RowTemplate.Height = 24;
            this.royalteeFees.Size = new System.Drawing.Size(980, 422);
            this.royalteeFees.TabIndex = 48;
            this.royalteeFees.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "dateIssued";
            this.Date.HeaderText = "Issued Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // Percentage
            // 
            this.Percentage.DataPropertyName = "percentage";
            this.Percentage.HeaderText = "Royalty Fee %";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            // 
            // BalanceOwed
            // 
            this.BalanceOwed.DataPropertyName = "amount";
            this.BalanceOwed.HeaderText = "Balance Owed";
            this.BalanceOwed.Name = "BalanceOwed";
            this.BalanceOwed.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Select Year:";
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2014"});
            this.yearBox.Location = new System.Drawing.Point(275, 111);
            this.yearBox.Margin = new System.Windows.Forms.Padding(2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(108, 25);
            this.yearBox.TabIndex = 49;
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.show_btn.FlatAppearance.BorderSize = 0;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.ForeColor = System.Drawing.Color.White;
            this.show_btn.Location = new System.Drawing.Point(418, 102);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(136, 41);
            this.show_btn.TabIndex = 51;
            this.show_btn.Text = "Show Collection";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 46);
            this.label5.TabIndex = 52;
            this.label5.Text = "Royalty Fees";
            // 
            // RoyaltyFeeCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.royalteeFees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.franchiseeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoyaltyFeeCollection";
            this.Text = "RoyalteeFeeCollection";
            this.Load += new System.EventHandler(this.RoyaltyFeeCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.royalteeFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox franchiseeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView royalteeFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceOwed;
        private System.Windows.Forms.Label label5;
    }
}
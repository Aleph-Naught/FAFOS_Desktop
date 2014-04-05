namespace FAFOS
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.txtInvoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentBox = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.paymentTable = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceBox = new System.Windows.Forms.GroupBox();
            this.PaymentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).BeginInit();
            this.InvoiceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.FormattingEnabled = true;
            this.txtInvoice.Location = new System.Drawing.Point(15, 103);
            this.txtInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(162, 25);
            this.txtInvoice.TabIndex = 34;
            this.txtInvoice.SelectedValueChanged += new System.EventHandler(this.txtInvoice_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Unpaid Invoices";
            // 
            // PaymentBox
            // 
            this.PaymentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaymentBox.Controls.Add(this.txtType);
            this.PaymentBox.Controls.Add(this.label10);
            this.PaymentBox.Controls.Add(this.txtRemarks);
            this.PaymentBox.Controls.Add(this.label9);
            this.PaymentBox.Controls.Add(this.txtAmount);
            this.PaymentBox.Controls.Add(this.label3);
            this.PaymentBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.PaymentBox.Location = new System.Drawing.Point(15, 384);
            this.PaymentBox.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.Padding = new System.Windows.Forms.Padding(2);
            this.PaymentBox.Size = new System.Drawing.Size(294, 118);
            this.PaymentBox.TabIndex = 35;
            this.PaymentBox.TabStop = false;
            this.PaymentBox.Text = "Add Payment";
            this.PaymentBox.Visible = false;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Visa",
            "MasterCard",
            "Debit"});
            this.txtType.Location = new System.Drawing.Point(84, 20);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(92, 25);
            this.txtType.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtRemarks.Location = new System.Drawing.Point(84, 72);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(164, 41);
            this.txtRemarks.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtAmount.Location = new System.Drawing.Point(84, 48);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(78, 23);
            this.txtAmount.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.Submit_btn.FlatAppearance.BorderSize = 0;
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.ForeColor = System.Drawing.Color.White;
            this.Submit_btn.Location = new System.Drawing.Point(483, 445);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(95, 57);
            this.Submit_btn.TabIndex = 37;
            this.Submit_btn.Text = "Submit Payment";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Visible = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 46);
            this.label14.TabIndex = 112;
            this.label14.Text = "Pay Invoices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 41);
            this.label4.TabIndex = 19;
            this.label4.Text = "Previous Payments";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Balance";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTotal.Location = new System.Drawing.Point(82, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(78, 23);
            this.txtTotal.TabIndex = 22;
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBalance.Location = new System.Drawing.Point(82, 161);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(78, 23);
            this.txtBalance.TabIndex = 23;
            // 
            // paymentTable
            // 
            this.paymentTable.AllowUserToAddRows = false;
            this.paymentTable.AllowUserToDeleteRows = false;
            this.paymentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Type,
            this.Amount,
            this.Remarks});
            this.paymentTable.Location = new System.Drawing.Point(82, 52);
            this.paymentTable.Margin = new System.Windows.Forms.Padding(2);
            this.paymentTable.Name = "paymentTable";
            this.paymentTable.ReadOnly = true;
            this.paymentTable.RowTemplate.Height = 24;
            this.paymentTable.Size = new System.Drawing.Size(480, 91);
            this.paymentTable.TabIndex = 24;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // InvoiceBox
            // 
            this.InvoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceBox.Controls.Add(this.paymentTable);
            this.InvoiceBox.Controls.Add(this.txtBalance);
            this.InvoiceBox.Controls.Add(this.txtTotal);
            this.InvoiceBox.Controls.Add(this.label2);
            this.InvoiceBox.Controls.Add(this.label4);
            this.InvoiceBox.Controls.Add(this.label5);
            this.InvoiceBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.InvoiceBox.Location = new System.Drawing.Point(16, 160);
            this.InvoiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.InvoiceBox.Name = "InvoiceBox";
            this.InvoiceBox.Padding = new System.Windows.Forms.Padding(2);
            this.InvoiceBox.Size = new System.Drawing.Size(578, 204);
            this.InvoiceBox.TabIndex = 36;
            this.InvoiceBox.TabStop = false;
            this.InvoiceBox.Text = "Invoice Information";
            this.InvoiceBox.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 541);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.InvoiceBox);
            this.Controls.Add(this.PaymentBox);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.PaymentBox.ResumeLayout(false);
            this.PaymentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).EndInit();
            this.InvoiceBox.ResumeLayout(false);
            this.InvoiceBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PaymentBox;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.DataGridView paymentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.GroupBox InvoiceBox;
    }
}
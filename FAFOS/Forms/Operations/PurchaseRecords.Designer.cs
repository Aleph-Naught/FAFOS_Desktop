namespace FAFOS
{
    partial class PurchaseRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SavePurchase_btn = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.purchaseRecordsdgv = new System.Windows.Forms.DataGridView();
            this.orderItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsupplier = new System.Windows.Forms.Label();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRecordsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // SavePurchase_btn
            // 
            this.SavePurchase_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePurchase_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.SavePurchase_btn.FlatAppearance.BorderSize = 0;
            this.SavePurchase_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePurchase_btn.ForeColor = System.Drawing.Color.White;
            this.SavePurchase_btn.Location = new System.Drawing.Point(607, 347);
            this.SavePurchase_btn.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.SavePurchase_btn.Name = "SavePurchase_btn";
            this.SavePurchase_btn.Size = new System.Drawing.Size(153, 62);
            this.SavePurchase_btn.TabIndex = 86;
            this.SavePurchase_btn.Text = "Save";
            this.SavePurchase_btn.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(660, 294);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 103;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(603, 297);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 102;
            this.lblTotal.Text = "Total";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(553, 83);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(207, 23);
            this.date.TabIndex = 96;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(418, 87);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 16);
            this.lblDate.TabIndex = 95;
            this.lblDate.Text = "Purchase Date";
            // 
            // purchaseRecordsdgv
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseRecordsdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseRecordsdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseRecordsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseRecordsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseRecordsdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemID,
            this.item,
            this.description,
            this.cost,
            this.Qty,
            this.lineTotal});
            this.purchaseRecordsdgv.Location = new System.Drawing.Point(12, 123);
            this.purchaseRecordsdgv.Name = "purchaseRecordsdgv";
            this.purchaseRecordsdgv.Size = new System.Drawing.Size(748, 150);
            this.purchaseRecordsdgv.TabIndex = 90;
            // 
            // orderItemID
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemID.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderItemID.HeaderText = "#";
            this.orderItemID.Name = "orderItemID";
            this.orderItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // item
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.DefaultCellStyle = dataGridViewCellStyle3;
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // description
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.DefaultCellStyle = dataGridViewCellStyle4;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cost
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.DefaultCellStyle = dataGridViewCellStyle5;
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Qty
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.DefaultCellStyle = dataGridViewCellStyle6;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lineTotal
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.lineTotal.HeaderText = "Line Total";
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.ReadOnly = true;
            this.lineTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblsupplier
            // 
            this.lblsupplier.AutoSize = true;
            this.lblsupplier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplier.Location = new System.Drawing.Point(9, 87);
            this.lblsupplier.Name = "lblsupplier";
            this.lblsupplier.Size = new System.Drawing.Size(65, 16);
            this.lblsupplier.TabIndex = 108;
            this.lblsupplier.Text = "Supplier";
            // 
            // comboSupplier
            // 
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.Location = new System.Drawing.Point(94, 83);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(121, 25);
            this.comboSupplier.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 46);
            this.label5.TabIndex = 110;
            this.label5.Text = "Record Purchases";
            // 
            // PurchaseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 442);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.lblsupplier);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.purchaseRecordsdgv);
            this.Controls.Add(this.SavePurchase_btn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PurchaseRecord";
            this.Text = "PurchaseRecords";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRecordsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SavePurchase_btn;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView purchaseRecordsdgv;
        private System.Windows.Forms.Label lblsupplier;
        private System.Windows.Forms.ComboBox comboSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemID;
        private System.Windows.Forms.DataGridViewComboBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotal;
        private System.Windows.Forms.Label label5;
    }
}
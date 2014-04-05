namespace FAFOS
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productsdgv = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteproduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.servicesdgv = new System.Windows.Forms.DataGridView();
            this.number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productnametextBox = new System.Windows.Forms.TextBox();
            this.productdescriptiontextBox = new System.Windows.Forms.TextBox();
            this.productpricetextBox = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.supplier = new System.Windows.Forms.ComboBox();
            this.AddProduct_btn = new System.Windows.Forms.Button();
            this.AddService_btn = new System.Windows.Forms.Button();
            this.servicepricetextbox = new System.Windows.Forms.TextBox();
            this.servicedescriptiontextbox = new System.Windows.Forms.TextBox();
            this.servicenametextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productsearch = new System.Windows.Forms.ComboBox();
            this.serviceSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addSupplierBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsdgv
            // 
            this.productsdgv.AllowUserToAddRows = false;
            this.productsdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.productsdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.productID,
            this.productName,
            this.productDescription,
            this.Cost,
            this.retailPrice,
            this.productQuantity,
            this.CategoryName,
            this.SupplierName,
            this.deleteproduct});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsdgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.productsdgv.Location = new System.Drawing.Point(4, 32);
            this.productsdgv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productsdgv.MultiSelect = false;
            this.productsdgv.Name = "productsdgv";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsdgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.productsdgv.RowTemplate.Height = 24;
            this.productsdgv.Size = new System.Drawing.Size(847, 266);
            this.productsdgv.TabIndex = 13;
            // 
            // number
            // 
            this.number.FillWeight = 50F;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "item_id";
            this.productID.HeaderText = "#";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productID.Visible = false;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = "Item";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productDescription
            // 
            this.productDescription.DataPropertyName = "description";
            this.productDescription.HeaderText = "Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // retailPrice
            // 
            this.retailPrice.DataPropertyName = "price";
            this.retailPrice.HeaderText = "Price";
            this.retailPrice.Name = "retailPrice";
            this.retailPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "quantity";
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "type";
            this.CategoryName.FillWeight = 75F;
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "supplier";
            this.SupplierName.FillWeight = 75F;
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // deleteproduct
            // 
            this.deleteproduct.FillWeight = 50F;
            this.deleteproduct.HeaderText = "Remove";
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Text = "Delete";
            this.deleteproduct.UseColumnTextForButtonValue = true;
            // 
            // Save_btn
            // 
            this.Save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.Save_btn.FlatAppearance.BorderSize = 0;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(713, 671);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(166, 52);
            this.Save_btn.TabIndex = 17;
            this.Save_btn.Text = "Save Updates";
            this.Save_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Products";
            // 
            // servicesdgv
            // 
            this.servicesdgv.AllowUserToAddRows = false;
            this.servicesdgv.AllowUserToDeleteRows = false;
            this.servicesdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.servicesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number1,
            this.itemID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.deleteService});
            this.servicesdgv.Location = new System.Drawing.Point(4, 52);
            this.servicesdgv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.servicesdgv.Name = "servicesdgv";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicesdgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.servicesdgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesdgv.RowTemplate.Height = 24;
            this.servicesdgv.Size = new System.Drawing.Size(847, 186);
            this.servicesdgv.TabIndex = 19;
            // 
            // number1
            // 
            this.number1.HeaderText = "#";
            this.number1.Name = "number1";
            this.number1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemID
            // 
            this.itemID.DataPropertyName = "item_id";
            this.itemID.HeaderText = "#";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Service";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // deleteService
            // 
            this.deleteService.HeaderText = "Remove";
            this.deleteService.Name = "deleteService";
            this.deleteService.Text = "Delete";
            this.deleteService.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Services";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(892, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add Product";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label4.Location = new System.Drawing.Point(892, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label5.Location = new System.Drawing.Point(891, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label6.Location = new System.Drawing.Point(892, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Retail Price";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label9.Location = new System.Drawing.Point(892, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label10.Location = new System.Drawing.Point(892, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Supplier";
            // 
            // productnametextBox
            // 
            this.productnametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productnametextBox.Location = new System.Drawing.Point(1005, 90);
            this.productnametextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productnametextBox.Name = "productnametextBox";
            this.productnametextBox.Size = new System.Drawing.Size(285, 23);
            this.productnametextBox.TabIndex = 35;
            // 
            // productdescriptiontextBox
            // 
            this.productdescriptiontextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productdescriptiontextBox.Location = new System.Drawing.Point(1005, 134);
            this.productdescriptiontextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productdescriptiontextBox.Name = "productdescriptiontextBox";
            this.productdescriptiontextBox.Size = new System.Drawing.Size(285, 23);
            this.productdescriptiontextBox.TabIndex = 36;
            // 
            // productpricetextBox
            // 
            this.productpricetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productpricetextBox.Location = new System.Drawing.Point(1005, 177);
            this.productpricetextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productpricetextBox.Name = "productpricetextBox";
            this.productpricetextBox.Size = new System.Drawing.Size(175, 23);
            this.productpricetextBox.TabIndex = 37;
            // 
            // category
            // 
            this.category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(1005, 219);
            this.category.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(285, 24);
            this.category.TabIndex = 39;
            // 
            // supplier
            // 
            this.supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplier.FormattingEnabled = true;
            this.supplier.Location = new System.Drawing.Point(1005, 262);
            this.supplier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(175, 24);
            this.supplier.TabIndex = 40;
            // 
            // AddProduct_btn
            // 
            this.AddProduct_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProduct_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.AddProduct_btn.FlatAppearance.BorderSize = 0;
            this.AddProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct_btn.ForeColor = System.Drawing.Color.White;
            this.AddProduct_btn.Location = new System.Drawing.Point(1113, 296);
            this.AddProduct_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddProduct_btn.Name = "AddProduct_btn";
            this.AddProduct_btn.Size = new System.Drawing.Size(177, 47);
            this.AddProduct_btn.TabIndex = 41;
            this.AddProduct_btn.Text = "Add Product";
            this.AddProduct_btn.UseVisualStyleBackColor = false;
            // 
            // AddService_btn
            // 
            this.AddService_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddService_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.AddService_btn.FlatAppearance.BorderSize = 0;
            this.AddService_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddService_btn.ForeColor = System.Drawing.Color.White;
            this.AddService_btn.Location = new System.Drawing.Point(1113, 567);
            this.AddService_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddService_btn.Name = "AddService_btn";
            this.AddService_btn.Size = new System.Drawing.Size(177, 46);
            this.AddService_btn.TabIndex = 46;
            this.AddService_btn.Text = "Add Service";
            this.AddService_btn.UseVisualStyleBackColor = false;
            // 
            // servicepricetextbox
            // 
            this.servicepricetextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.servicepricetextbox.Location = new System.Drawing.Point(1005, 503);
            this.servicepricetextbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.servicepricetextbox.Name = "servicepricetextbox";
            this.servicepricetextbox.Size = new System.Drawing.Size(175, 23);
            this.servicepricetextbox.TabIndex = 63;
            // 
            // servicedescriptiontextbox
            // 
            this.servicedescriptiontextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.servicedescriptiontextbox.Location = new System.Drawing.Point(1005, 466);
            this.servicedescriptiontextbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.servicedescriptiontextbox.Name = "servicedescriptiontextbox";
            this.servicedescriptiontextbox.Size = new System.Drawing.Size(285, 23);
            this.servicedescriptiontextbox.TabIndex = 62;
            // 
            // servicenametextbox
            // 
            this.servicenametextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.servicenametextbox.Location = new System.Drawing.Point(1005, 427);
            this.servicenametextbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.servicenametextbox.Name = "servicenametextbox";
            this.servicenametextbox.Size = new System.Drawing.Size(285, 23);
            this.servicenametextbox.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label13.Location = new System.Drawing.Point(891, 510);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Price";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label12.Location = new System.Drawing.Point(891, 469);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label11.Location = new System.Drawing.Point(892, 427);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(891, 381);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Add Service";
            // 
            // productsearch
            // 
            this.productsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsearch.FormattingEnabled = true;
            this.productsearch.Location = new System.Drawing.Point(663, 0);
            this.productsearch.Name = "productsearch";
            this.productsearch.Size = new System.Drawing.Size(188, 19);
            this.productsearch.TabIndex = 65;
            // 
            // serviceSearch
            // 
            this.serviceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceSearch.FormattingEnabled = true;
            this.serviceSearch.Location = new System.Drawing.Point(660, 5);
            this.serviceSearch.Name = "serviceSearch";
            this.serviceSearch.Size = new System.Drawing.Size(188, 19);
            this.serviceSearch.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Find:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(607, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 68;
            this.label16.Text = "Find:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 46);
            this.label14.TabIndex = 111;
            this.label14.Text = "Inventory";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(14, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.productsdgv);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.productsearch);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.servicesdgv);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.serviceSearch);
            this.splitContainer1.Size = new System.Drawing.Size(865, 575);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 112;
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.addSupplierBtn.FlatAppearance.BorderSize = 0;
            this.addSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplierBtn.ForeColor = System.Drawing.Color.White;
            this.addSupplierBtn.Location = new System.Drawing.Point(1211, 262);
            this.addSupplierBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Size = new System.Drawing.Size(79, 24);
            this.addSupplierBtn.TabIndex = 113;
            this.addSupplierBtn.Text = "Add New";
            this.addSupplierBtn.UseVisualStyleBackColor = false;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1184, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 16);
            this.label15.TabIndex = 114;
            this.label15.Text = "or";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 780);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.addSupplierBtn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.servicepricetextbox);
            this.Controls.Add(this.servicedescriptiontextbox);
            this.Controls.Add(this.servicenametextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddService_btn);
            this.Controls.Add(this.AddProduct_btn);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.category);
            this.Controls.Add(this.productpricetextBox);
            this.Controls.Add(this.productdescriptiontextBox);
            this.Controls.Add(this.productnametextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save_btn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "InventoryForm";
            this.Text = "Maintain Inventory Form";
            ((System.ComponentModel.ISupportInitialize)(this.productsdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesdgv)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsdgv;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView servicesdgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox productnametextBox;
        private System.Windows.Forms.TextBox productdescriptiontextBox;
        private System.Windows.Forms.TextBox productpricetextBox;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.ComboBox supplier;
        private System.Windows.Forms.Button AddProduct_btn;
        private System.Windows.Forms.Button AddService_btn;
        private System.Windows.Forms.TextBox servicepricetextbox;
        private System.Windows.Forms.TextBox servicedescriptiontextbox;
        private System.Windows.Forms.TextBox servicenametextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ComboBox productsearch;
        private System.Windows.Forms.ComboBox serviceSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewButtonColumn deleteproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn deleteService;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addSupplierBtn;
        private System.Windows.Forms.Label label15;
   
    }
}


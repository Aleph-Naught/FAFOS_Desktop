namespace FAFOS
{
    partial class MapsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.generate_btn = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.saveRoute = new System.Windows.Forms.Button();
            this.workOrderTable = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.servicesTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HelpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMap
            // 
            this.MainMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMap.Bearing = 0F;
            this.MainMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(15, 302);
            this.MainMap.Margin = new System.Windows.Forms.Padding(2);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(946, 407);
            this.MainMap.TabIndex = 42;
            this.MainMap.Visible = false;
            this.MainMap.Zoom = 0D;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Work Order:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Service Contract:";
            // 
            // generate_btn
            // 
            this.generate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.generate_btn.Enabled = false;
            this.generate_btn.FlatAppearance.BorderSize = 0;
            this.generate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.ForeColor = System.Drawing.Color.White;
            this.generate_btn.Location = new System.Drawing.Point(978, 302);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(99, 57);
            this.generate_btn.TabIndex = 49;
            this.generate_btn.Text = "Generate Map";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.Location = new System.Drawing.Point(1221, 202);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(94, 41);
            this.lblUserInfo.TabIndex = 51;
            // 
            // saveRoute
            // 
            this.saveRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.saveRoute.FlatAppearance.BorderSize = 0;
            this.saveRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRoute.ForeColor = System.Drawing.Color.White;
            this.saveRoute.Location = new System.Drawing.Point(978, 365);
            this.saveRoute.Name = "saveRoute";
            this.saveRoute.Size = new System.Drawing.Size(99, 57);
            this.saveRoute.TabIndex = 53;
            this.saveRoute.Text = "Session End";
            this.saveRoute.UseVisualStyleBackColor = false;
            this.saveRoute.Click += new System.EventHandler(this.saveRoute_Click);
            // 
            // workOrderTable
            // 
            this.workOrderTable.AllowUserToAddRows = false;
            this.workOrderTable.AllowUserToDeleteRows = false;
            this.workOrderTable.AllowUserToResizeRows = false;
            this.workOrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.issuedDate,
            this.OrderAddress,
            this.OrderCity,
            this.OrderProvince,
            this.OrderCountry,
            this.Done});
            this.workOrderTable.Location = new System.Drawing.Point(3, 37);
            this.workOrderTable.Margin = new System.Windows.Forms.Padding(2);
            this.workOrderTable.Name = "workOrderTable";
            this.workOrderTable.RowHeadersVisible = false;
            this.workOrderTable.RowTemplate.Height = 24;
            this.workOrderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workOrderTable.Size = new System.Drawing.Size(466, 155);
            this.workOrderTable.TabIndex = 54;
            this.workOrderTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // orderID
            // 
            this.orderID.DataPropertyName = "id";
            this.orderID.HeaderText = "ID";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // issuedDate
            // 
            this.issuedDate.DataPropertyName = "dateIssued";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.issuedDate.HeaderText = "Date Issued";
            this.issuedDate.Name = "issuedDate";
            this.issuedDate.ReadOnly = true;
            this.issuedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderAddress
            // 
            this.OrderAddress.DataPropertyName = "address";
            this.OrderAddress.HeaderText = "Address";
            this.OrderAddress.Name = "OrderAddress";
            this.OrderAddress.ReadOnly = true;
            this.OrderAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderCity
            // 
            this.OrderCity.DataPropertyName = "city";
            this.OrderCity.HeaderText = "City";
            this.OrderCity.Name = "OrderCity";
            this.OrderCity.ReadOnly = true;
            this.OrderCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderProvince
            // 
            this.OrderProvince.DataPropertyName = "province";
            this.OrderProvince.HeaderText = "Province";
            this.OrderProvince.Name = "OrderProvince";
            this.OrderProvince.ReadOnly = true;
            this.OrderProvince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderProvince.Visible = false;
            // 
            // OrderCountry
            // 
            this.OrderCountry.DataPropertyName = "country";
            this.OrderCountry.HeaderText = "Country";
            this.OrderCountry.Name = "OrderCountry";
            this.OrderCountry.ReadOnly = true;
            this.OrderCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderCountry.Visible = false;
            // 
            // Done
            // 
            this.Done.HeaderText = "Completed";
            this.Done.Name = "Done";
            // 
            // servicesTable
            // 
            this.servicesTable.AllowUserToAddRows = false;
            this.servicesTable.AllowUserToDeleteRows = false;
            this.servicesTable.AllowUserToResizeRows = false;
            this.servicesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.servicesTable.Location = new System.Drawing.Point(3, 37);
            this.servicesTable.Margin = new System.Windows.Forms.Padding(2);
            this.servicesTable.Name = "servicesTable";
            this.servicesTable.RowHeadersVisible = false;
            this.servicesTable.RowTemplate.Height = 24;
            this.servicesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesTable.Size = new System.Drawing.Size(578, 155);
            this.servicesTable.TabIndex = 55;
            this.servicesTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "service";
            this.dataGridViewTextBoxColumn1.HeaderText = "Service";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "period";
            this.Column1.HeaderText = "Period";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nextDate";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Due Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "notes";
            this.Column3.HeaderText = "Notes";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "province";
            this.dataGridViewTextBoxColumn5.HeaderText = "Province";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn6.HeaderText = "Country";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Completed";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 46);
            this.label5.TabIndex = 56;
            this.label5.Text = "Day Itinerary";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.workOrderTable);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.servicesTable);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Size = new System.Drawing.Size(1077, 209);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 57;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Location = new System.Drawing.Point(978, 651);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(99, 57);
            this.HelpBtn.TabIndex = 58;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // MapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 720);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveRoute);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.MainMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapsForm";
            this.Text = "MapsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapsForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesTable)).EndInit();
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

        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button saveRoute;
        private System.Windows.Forms.DataGridView workOrderTable;
        private System.Windows.Forms.DataGridView servicesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCountry;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button HelpBtn;

    }
}
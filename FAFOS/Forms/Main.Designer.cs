namespace FAFOS.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayItineraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editQuoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSalesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToSalesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSalesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialStatementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.royaltyFeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.syncAndroid = new System.Windows.Forms.Button();
            this.paymentNotification = new System.Windows.Forms.Label();
            this.serviceNotification = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.notificationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userLabel
            // 
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(118, 17);
            this.userLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.userSettingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.userSettingsToolStripMenuItem.Text = "User Settings";
            this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.userSettingsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspectionToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.recordPurchaseToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.dayItineraryToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // inspectionToolStripMenuItem
            // 
            this.inspectionToolStripMenuItem.Name = "inspectionToolStripMenuItem";
            this.inspectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inspectionToolStripMenuItem.Text = "Inspection";
            this.inspectionToolStripMenuItem.Click += new System.EventHandler(this.inspectionToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // recordPurchaseToolStripMenuItem
            // 
            this.recordPurchaseToolStripMenuItem.Name = "recordPurchaseToolStripMenuItem";
            this.recordPurchaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.recordPurchaseToolStripMenuItem.Text = "Record Purchase";
            this.recordPurchaseToolStripMenuItem.Click += new System.EventHandler(this.recordPurchaseToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // dayItineraryToolStripMenuItem
            // 
            this.dayItineraryToolStripMenuItem.Name = "dayItineraryToolStripMenuItem";
            this.dayItineraryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dayItineraryToolStripMenuItem.Text = "Day Itinerary";
            this.dayItineraryToolStripMenuItem.Click += new System.EventHandler(this.dayItineraryToolStripMenuItem_Click_1);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuoteToolStripMenuItem,
            this.editQuoteToolStripMenuItem,
            this.createSalesOrderToolStripMenuItem,
            this.convertToSalesOrderToolStripMenuItem,
            this.editSalesOrderToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // createQuoteToolStripMenuItem
            // 
            this.createQuoteToolStripMenuItem.Name = "createQuoteToolStripMenuItem";
            this.createQuoteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.createQuoteToolStripMenuItem.Text = "Create Quote";
            this.createQuoteToolStripMenuItem.Click += new System.EventHandler(this.createQuoteToolStripMenuItem_Click);
            // 
            // editQuoteToolStripMenuItem
            // 
            this.editQuoteToolStripMenuItem.Name = "editQuoteToolStripMenuItem";
            this.editQuoteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editQuoteToolStripMenuItem.Text = "Edit Quote";
            this.editQuoteToolStripMenuItem.Click += new System.EventHandler(this.editQuoteToolStripMenuItem_Click);
            // 
            // createSalesOrderToolStripMenuItem
            // 
            this.createSalesOrderToolStripMenuItem.Name = "createSalesOrderToolStripMenuItem";
            this.createSalesOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.createSalesOrderToolStripMenuItem.Text = "Create Sales Order";
            this.createSalesOrderToolStripMenuItem.Click += new System.EventHandler(this.createSalesOrderToolStripMenuItem_Click);
            // 
            // convertToSalesOrderToolStripMenuItem
            // 
            this.convertToSalesOrderToolStripMenuItem.Name = "convertToSalesOrderToolStripMenuItem";
            this.convertToSalesOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.convertToSalesOrderToolStripMenuItem.Text = "Convert to Sales Order";
            this.convertToSalesOrderToolStripMenuItem.Click += new System.EventHandler(this.convertToSalesOrderToolStripMenuItem_Click);
            // 
            // editSalesOrderToolStripMenuItem
            // 
            this.editSalesOrderToolStripMenuItem.Name = "editSalesOrderToolStripMenuItem";
            this.editSalesOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editSalesOrderToolStripMenuItem.Text = "Edit Sales Order";
            this.editSalesOrderToolStripMenuItem.Click += new System.EventHandler(this.editSalesOrderToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.addContractToolStripMenuItem,
            this.editClientToolStripMenuItem,
            this.editContractToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // addContractToolStripMenuItem
            // 
            this.addContractToolStripMenuItem.Name = "addContractToolStripMenuItem";
            this.addContractToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addContractToolStripMenuItem.Text = "Add Contract";
            this.addContractToolStripMenuItem.Click += new System.EventHandler(this.addContractToolStripMenuItem_Click);
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editClientToolStripMenuItem.Text = "Edit Client";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.editClientToolStripMenuItem_Click);
            // 
            // editContractToolStripMenuItem
            // 
            this.editContractToolStripMenuItem.Name = "editContractToolStripMenuItem";
            this.editContractToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editContractToolStripMenuItem.Text = "Edit Contract";
            this.editContractToolStripMenuItem.Click += new System.EventHandler(this.editContractToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financialStatementsToolStripMenuItem,
            this.revenueReportsToolStripMenuItem,
            this.royaltyFeeToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // financialStatementsToolStripMenuItem
            // 
            this.financialStatementsToolStripMenuItem.Name = "financialStatementsToolStripMenuItem";
            this.financialStatementsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.financialStatementsToolStripMenuItem.Text = "Financial Statements";
            this.financialStatementsToolStripMenuItem.Click += new System.EventHandler(this.financialStatementsToolStripMenuItem_Click);
            // 
            // revenueReportsToolStripMenuItem
            // 
            this.revenueReportsToolStripMenuItem.Name = "revenueReportsToolStripMenuItem";
            this.revenueReportsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.revenueReportsToolStripMenuItem.Text = "Revenue Reports";
            this.revenueReportsToolStripMenuItem.Click += new System.EventHandler(this.revenueReportsToolStripMenuItem_Click);
            // 
            // royaltyFeeToolStripMenuItem
            // 
            this.royaltyFeeToolStripMenuItem.Name = "royaltyFeeToolStripMenuItem";
            this.royaltyFeeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.royaltyFeeToolStripMenuItem.Text = "Royalty Fee";
            this.royaltyFeeToolStripMenuItem.Click += new System.EventHandler(this.royaltyFeeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.notificationPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer1.Size = new System.Drawing.Size(1184, 695);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 3;
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.notificationPanel.Controls.Add(this.panel1);
            this.notificationPanel.Controls.Add(this.paymentNotification);
            this.notificationPanel.Controls.Add(this.serviceNotification);
            this.notificationPanel.Controls.Add(this.label3);
            this.notificationPanel.Controls.Add(this.label4);
            this.notificationPanel.Controls.Add(this.label1);
            this.notificationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationPanel.Location = new System.Drawing.Point(0, 0);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(196, 693);
            this.notificationPanel.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.syncAndroid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 213);
            this.panel1.TabIndex = 58;
            // 
            // syncAndroid
            // 
            this.syncAndroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.syncAndroid.FlatAppearance.BorderSize = 0;
            this.syncAndroid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.syncAndroid.ForeColor = System.Drawing.Color.White;
            this.syncAndroid.Location = new System.Drawing.Point(25, 129);
            this.syncAndroid.Margin = new System.Windows.Forms.Padding(4);
            this.syncAndroid.Name = "syncAndroid";
            this.syncAndroid.Size = new System.Drawing.Size(133, 49);
            this.syncAndroid.TabIndex = 57;
            this.syncAndroid.Text = "Sync Data With Android";
            this.syncAndroid.UseVisualStyleBackColor = false;
            this.syncAndroid.Click += new System.EventHandler(this.syncAndroid_Click);
            // 
            // paymentNotification
            // 
            this.paymentNotification.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentNotification.Location = new System.Drawing.Point(22, 207);
            this.paymentNotification.Name = "paymentNotification";
            this.paymentNotification.Size = new System.Drawing.Size(219, 89);
            this.paymentNotification.TabIndex = 5;
            this.paymentNotification.Text = "None";
            // 
            // serviceNotification
            // 
            this.serviceNotification.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNotification.Location = new System.Drawing.Point(15, 79);
            this.serviceNotification.Name = "serviceNotification";
            this.serviceNotification.Size = new System.Drawing.Size(226, 90);
            this.serviceNotification.TabIndex = 4;
            this.serviceNotification.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payments Due:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Services:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day Notifications";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FAFOS";
            this.Load += new System.EventHandler(this.MainPrototype_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel userLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label paymentNotification;
        private System.Windows.Forms.Label serviceNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button syncAndroid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem inspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQuoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editQuoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSalesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToSalesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSalesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialStatementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem royaltyFeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayItineraryToolStripMenuItem;
    }
}
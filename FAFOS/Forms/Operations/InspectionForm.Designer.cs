namespace FAFOS
{
    partial class InspectionForm
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
            this.inspectionType = new System.Windows.Forms.ComboBox();
            this.generate_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pdfPreview = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inspectionType
            // 
            this.inspectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionType.FormattingEnabled = true;
            this.inspectionType.Items.AddRange(new object[] {
            "Extinguisher Report",
            "Emergency Light",
            "Fire Hose Cabinet"});
            this.inspectionType.Location = new System.Drawing.Point(4, 118);
            this.inspectionType.Margin = new System.Windows.Forms.Padding(2);
            this.inspectionType.Name = "inspectionType";
            this.inspectionType.Size = new System.Drawing.Size(383, 25);
            this.inspectionType.TabIndex = 39;
            // 
            // generate_btn
            // 
            this.generate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.generate_btn.FlatAppearance.BorderSize = 0;
            this.generate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.ForeColor = System.Drawing.Color.White;
            this.generate_btn.Location = new System.Drawing.Point(251, 161);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(136, 48);
            this.generate_btn.TabIndex = 52;
            this.generate_btn.Text = "Generate Report";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Inspection Report:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inspectionType);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.generate_btn);
            this.panel1.Location = new System.Drawing.Point(11, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 277);
            this.panel1.TabIndex = 54;
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Items.AddRange(new object[] {
            "",
            "Extinguisher Report",
            "Hose Report",
            "Emergency Light Report"});
            this.addressBox.Location = new System.Drawing.Point(5, 41);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(382, 25);
            this.addressBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Service Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 46);
            this.label5.TabIndex = 55;
            this.label5.Text = "Inspection Reports";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pdfPreview
            // 
            this.pdfPreview.AllowWebBrowserDrop = false;
            this.pdfPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfPreview.Location = new System.Drawing.Point(444, 69);
            this.pdfPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfPreview.Name = "pdfPreview";
            this.pdfPreview.Size = new System.Drawing.Size(620, 587);
            this.pdfPreview.TabIndex = 56;
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 687);
            this.Controls.Add(this.pdfPreview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InspectionForm";
            this.Text = "InspectionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inspectionType;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox addressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser pdfPreview;
    }
}
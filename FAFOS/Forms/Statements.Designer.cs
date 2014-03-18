namespace FAFOS
{
    partial class Statements
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
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.pnlStatement = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStatement.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClients
            // 
            this.cbClients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(10, 38);
            this.cbClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(176, 26);
            this.cbClients.TabIndex = 39;
            // 
            // pnlStatement
            // 
            this.pnlStatement.Controls.Add(this.label1);
            this.pnlStatement.Controls.Add(this.btnStatement);
            this.pnlStatement.Controls.Add(this.cbClients);
            this.pnlStatement.Location = new System.Drawing.Point(209, 152);
            this.pnlStatement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlStatement.Name = "pnlStatement";
            this.pnlStatement.Size = new System.Drawing.Size(397, 101);
            this.pnlStatement.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Outstanding Accounts:";
            // 
            // btnStatement
            // 
            this.btnStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.btnStatement.FlatAppearance.BorderSize = 0;
            this.btnStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatement.ForeColor = System.Drawing.Color.White;
            this.btnStatement.Location = new System.Drawing.Point(282, 25);
            this.btnStatement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(94, 50);
            this.btnStatement.TabIndex = 42;
            this.btnStatement.Text = "Generate Statement";
            this.btnStatement.UseVisualStyleBackColor = false;
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 46);
            this.label5.TabIndex = 53;
            this.label5.Text = "Financial Statements";
            // 
            // Statements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlStatement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Statements";
            this.Text = "Statements";
            this.pnlStatement.ResumeLayout(false);
            this.pnlStatement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Panel pnlStatement;
        private System.Windows.Forms.Button btnStatement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
﻿namespace FAFOS
{
    partial class SyncView
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
            this.syncToAndroid = new System.Windows.Forms.Button();
            this.syncFromAndroid = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // syncToAndroid
            // 
            this.syncToAndroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.syncToAndroid.FlatAppearance.BorderSize = 0;
            this.syncToAndroid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncToAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncToAndroid.ForeColor = System.Drawing.Color.White;
            this.syncToAndroid.Location = new System.Drawing.Point(26, 147);
            this.syncToAndroid.Name = "syncToAndroid";
            this.syncToAndroid.Size = new System.Drawing.Size(156, 40);
            this.syncToAndroid.TabIndex = 57;
            this.syncToAndroid.Text = "Sync Contracts to Mobile Device";
            this.syncToAndroid.UseVisualStyleBackColor = false;
            // 
            // syncFromAndroid
            // 
            this.syncFromAndroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.syncFromAndroid.FlatAppearance.BorderSize = 0;
            this.syncFromAndroid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncFromAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncFromAndroid.ForeColor = System.Drawing.Color.White;
            this.syncFromAndroid.Location = new System.Drawing.Point(26, 85);
            this.syncFromAndroid.Name = "syncFromAndroid";
            this.syncFromAndroid.Size = new System.Drawing.Size(156, 41);
            this.syncFromAndroid.TabIndex = 56;
            this.syncFromAndroid.Text = "Sync Inspection Results from Mobile Device";
            this.syncFromAndroid.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "Sync Options";
            // 
            // SyncView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.syncToAndroid);
            this.Controls.Add(this.syncFromAndroid);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SyncView";
            this.Text = "FAFOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SyncView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button syncToAndroid;
        private System.Windows.Forms.Button syncFromAndroid;
        private System.Windows.Forms.Label label9;
    }
}

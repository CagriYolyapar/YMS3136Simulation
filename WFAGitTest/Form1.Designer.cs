﻿namespace WFAGitTest
{
    partial class Form1
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
            this.btnSelamla = new System.Windows.Forms.Button();
            this.btnCagri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelamla
            // 
            this.btnSelamla.Location = new System.Drawing.Point(278, 151);
            this.btnSelamla.Name = "btnSelamla";
            this.btnSelamla.Size = new System.Drawing.Size(75, 23);
            this.btnSelamla.TabIndex = 0;
            this.btnSelamla.Text = "Selamla";
            this.btnSelamla.UseVisualStyleBackColor = true;
            this.btnSelamla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCagri
            // 
            this.btnCagri.Location = new System.Drawing.Point(423, 70);
            this.btnCagri.Name = "btnCagri";
            this.btnCagri.Size = new System.Drawing.Size(75, 23);
            this.btnCagri.TabIndex = 1;
            this.btnCagri.Text = "btnCagri";
            this.btnCagri.UseVisualStyleBackColor = true;
            this.btnCagri.Click += new System.EventHandler(this.btnCagri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCagri);
            this.Controls.Add(this.btnSelamla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelamla;
        private System.Windows.Forms.Button btnCagri;
        private System.Windows.Forms.Button button1;
    }
}


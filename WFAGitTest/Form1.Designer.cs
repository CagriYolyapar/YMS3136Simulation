namespace WFAGitTest
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstanil = new System.Windows.Forms.ListBox();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lstanil
            // 
            this.lstanil.FormattingEnabled = true;
            this.lstanil.Location = new System.Drawing.Point(407, 297);
            this.lstanil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstanil.Name = "lstanil";
            this.lstanil.Size = new System.Drawing.Size(91, 69);
            this.lstanil.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFAGitTest.Properties.Resources.Annotation_2020_02_03_104617;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstanil);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCagri);
            this.Controls.Add(this.btnSelamla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelamla;
        private System.Windows.Forms.Button btnCagri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstanil;
    }
}


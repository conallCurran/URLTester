using System;

namespace URLTester
{
    partial class URLTester1
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
            this.URLbox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.URLbox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbl_items = new System.Windows.Forms.CheckedListBox();
            this.BrokenLinks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLbox1
            // 
            this.URLbox1.Location = new System.Drawing.Point(343, 30);
            this.URLbox1.Name = "URLbox1";
            this.URLbox1.Size = new System.Drawing.Size(349, 20);
            this.URLbox1.TabIndex = 0;
            this.URLbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Download Links";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // URLbox2
            // 
            this.URLbox2.Location = new System.Drawing.Point(343, 121);
            this.URLbox2.Name = "URLbox2";
            this.URLbox2.Size = new System.Drawing.Size(349, 20);
            this.URLbox2.TabIndex = 5;
            this.URLbox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Test Links";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbl_items
            // 
            this.cbl_items.FormattingEnabled = true;
            this.cbl_items.Location = new System.Drawing.Point(399, 171);
            this.cbl_items.Name = "cbl_items";
            this.cbl_items.Size = new System.Drawing.Size(529, 94);
            this.cbl_items.TabIndex = 8;
            // 
            // BrokenLinks
            // 
            this.BrokenLinks.Location = new System.Drawing.Point(23, 171);
            this.BrokenLinks.Multiline = true;
            this.BrokenLinks.Name = "BrokenLinks";
            this.BrokenLinks.Size = new System.Drawing.Size(370, 94);
            this.BrokenLinks.TabIndex = 9;
            this.BrokenLinks.TextChanged += new System.EventHandler(this.BrokenLinks_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Errors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Web Page Active:";
            // 
            // URLTester1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrokenLinks);
            this.Controls.Add(this.cbl_items);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.URLbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.URLbox1);
            this.Name = "URLTester1";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.URLTester1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox URLbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox URLbox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox cbl_items;
        private System.Windows.Forms.TextBox BrokenLinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
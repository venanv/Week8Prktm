namespace Week8Prktm
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Manager1 = new System.Windows.Forms.Label();
            this.Captain1 = new System.Windows.Forms.Label();
            this.Manager2 = new System.Windows.Forms.Label();
            this.Captain2 = new System.Windows.Forms.Label();
            this.Stadium = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(41, 30);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(376, 28);
            this.cb1.TabIndex = 0;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(516, 30);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(376, 28);
            this.cb2.TabIndex = 1;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Captain :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mangaer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Captain :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stadium :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Capacity :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "VS";
            // 
            // Manager1
            // 
            this.Manager1.AutoSize = true;
            this.Manager1.Location = new System.Drawing.Point(123, 107);
            this.Manager1.Name = "Manager1";
            this.Manager1.Size = new System.Drawing.Size(0, 20);
            this.Manager1.TabIndex = 9;
            this.Manager1.Click += new System.EventHandler(this.label8_Click);
            // 
            // Captain1
            // 
            this.Captain1.AutoSize = true;
            this.Captain1.Location = new System.Drawing.Point(123, 157);
            this.Captain1.Name = "Captain1";
            this.Captain1.Size = new System.Drawing.Size(0, 20);
            this.Captain1.TabIndex = 10;
            // 
            // Manager2
            // 
            this.Manager2.AutoSize = true;
            this.Manager2.Location = new System.Drawing.Point(609, 107);
            this.Manager2.Name = "Manager2";
            this.Manager2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Manager2.Size = new System.Drawing.Size(0, 20);
            this.Manager2.TabIndex = 11;
            this.Manager2.Click += new System.EventHandler(this.Manager2_Click);
            // 
            // Captain2
            // 
            this.Captain2.AutoSize = true;
            this.Captain2.Location = new System.Drawing.Point(609, 157);
            this.Captain2.Name = "Captain2";
            this.Captain2.Size = new System.Drawing.Size(0, 20);
            this.Captain2.TabIndex = 12;
            // 
            // Stadium
            // 
            this.Stadium.AutoSize = true;
            this.Stadium.Location = new System.Drawing.Point(357, 285);
            this.Stadium.Name = "Stadium";
            this.Stadium.Size = new System.Drawing.Size(0, 20);
            this.Stadium.TabIndex = 13;
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(357, 331);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(0, 20);
            this.Capacity.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 467);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.Stadium);
            this.Controls.Add(this.Captain2);
            this.Controls.Add(this.Manager2);
            this.Controls.Add(this.Captain1);
            this.Controls.Add(this.Manager1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Manager1;
        private System.Windows.Forms.Label Captain1;
        private System.Windows.Forms.Label Manager2;
        private System.Windows.Forms.Label Captain2;
        private System.Windows.Forms.Label Stadium;
        private System.Windows.Forms.Label Capacity;
    }
}


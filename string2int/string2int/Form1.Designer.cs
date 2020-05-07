namespace string2int
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuesA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuesB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AnsB = new System.Windows.Forms.NumericUpDown();
            this.AnsA = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnsB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnsA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnsA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QuesA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ques A :";
            // 
            // QuesA
            // 
            this.QuesA.Location = new System.Drawing.Point(123, 29);
            this.QuesA.Name = "QuesA";
            this.QuesA.ReadOnly = true;
            this.QuesA.Size = new System.Drawing.Size(224, 22);
            this.QuesA.TabIndex = 1;
            this.QuesA.Text = "abc573";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer‎  A :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AnsB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.QuesB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer‎  B :";
            // 
            // QuesB
            // 
            this.QuesB.Location = new System.Drawing.Point(123, 29);
            this.QuesB.Name = "QuesB";
            this.QuesB.ReadOnly = true;
            this.QuesB.Size = new System.Drawing.Size(224, 22);
            this.QuesB.TabIndex = 1;
            this.QuesB.Text = "a5b7c3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ques B :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnsB
            // 
            this.AnsB.Enabled = false;
            this.AnsB.Location = new System.Drawing.Point(123, 71);
            this.AnsB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AnsB.Name = "AnsB";
            this.AnsB.ReadOnly = true;
            this.AnsB.Size = new System.Drawing.Size(224, 22);
            this.AnsB.TabIndex = 6;
            // 
            // AnsA
            // 
            this.AnsA.Enabled = false;
            this.AnsA.Location = new System.Drawing.Point(123, 76);
            this.AnsA.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AnsA.Name = "AnsA";
            this.AnsA.ReadOnly = true;
            this.AnsA.Size = new System.Drawing.Size(224, 22);
            this.AnsA.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnsB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnsA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuesA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuesB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown AnsA;
        private System.Windows.Forms.NumericUpDown AnsB;
    }
}


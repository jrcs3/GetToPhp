namespace GetToPhpWinF
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
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParam3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParam4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(121, 12);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(100, 26);
            this.txtParam1.TabIndex = 1;
            this.txtParam1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parameter #1:";
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(121, 44);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(100, 26);
            this.txtParam2.TabIndex = 3;
            this.txtParam2.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parameter #2:";
            // 
            // txtParam3
            // 
            this.txtParam3.Location = new System.Drawing.Point(121, 76);
            this.txtParam3.Name = "txtParam3";
            this.txtParam3.Size = new System.Drawing.Size(100, 26);
            this.txtParam3.TabIndex = 5;
            this.txtParam3.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parameter #3:";
            // 
            // txtParam4
            // 
            this.txtParam4.Location = new System.Drawing.Point(121, 108);
            this.txtParam4.Name = "txtParam4";
            this.txtParam4.Size = new System.Drawing.Size(100, 26);
            this.txtParam4.TabIndex = 7;
            this.txtParam4.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parameter #4:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(39, 162);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 326);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtParam4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParam3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParam3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParam4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
    }
}


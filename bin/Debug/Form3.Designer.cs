namespace BugetPlan
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.rentAmnt = new System.Windows.Forms.Label();
            this.rentAmntTxtBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.OkRentTXtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "RENT INFO :";
            // 
            // rentAmnt
            // 
            this.rentAmnt.AutoSize = true;
            this.rentAmnt.Location = new System.Drawing.Point(269, 148);
            this.rentAmnt.Name = "rentAmnt";
            this.rentAmnt.Size = new System.Drawing.Size(135, 13);
            this.rentAmnt.TabIndex = 27;
            this.rentAmnt.Text = "enter monthly rent amount :";
            // 
            // rentAmntTxtBox
            // 
            this.rentAmntTxtBox.Location = new System.Drawing.Point(412, 148);
            this.rentAmntTxtBox.Name = "rentAmntTxtBox";
            this.rentAmntTxtBox.Size = new System.Drawing.Size(100, 20);
            this.rentAmntTxtBox.TabIndex = 26;
            this.rentAmntTxtBox.TextChanged += new System.EventHandler(this.rentAmntTxtBox_TextChanged);
            this.rentAmntTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rentAmntTxtBox_KeyPress);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(437, 174);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 29;
            this.OK.Text = "OK\r\n\r\n";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // OkRentTXtBox
            // 
            this.OkRentTXtBox.Location = new System.Drawing.Point(412, 281);
            this.OkRentTXtBox.Name = "OkRentTXtBox";
            this.OkRentTXtBox.Size = new System.Drawing.Size(100, 20);
            this.OkRentTXtBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Enter the monthly rent bellow and press OK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = " monthly rent amount :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OkRentTXtBox);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentAmnt);
            this.Controls.Add(this.rentAmntTxtBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rentAmnt;
        private System.Windows.Forms.TextBox rentAmntTxtBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox OkRentTXtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
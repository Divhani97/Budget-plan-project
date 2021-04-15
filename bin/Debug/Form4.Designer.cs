namespace BugetPlan
{
    partial class Form4
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
            this.MonthlyPAymenttextBox1 = new System.Windows.Forms.TextBox();
            this.propertyCalcBttn = new System.Windows.Forms.Button();
            this.monthBuyTxtBx = new System.Windows.Forms.TextBox();
            this.interestBuyTxtBox = new System.Windows.Forms.TextBox();
            this.depositTxtBx = new System.Windows.Forms.TextBox();
            this.propertyTxtBox = new System.Windows.Forms.TextBox();
            this.monthsBuy = new System.Windows.Forms.Label();
            this.interestBuy = new System.Windows.Forms.Label();
            this.depositValue = new System.Windows.Forms.Label();
            this.propertyPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "ROPERTY PURCHASE INFO :";
            // 
            // MonthlyPAymenttextBox1
            // 
            this.MonthlyPAymenttextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthlyPAymenttextBox1.Location = new System.Drawing.Point(409, 321);
            this.MonthlyPAymenttextBox1.Multiline = true;
            this.MonthlyPAymenttextBox1.Name = "MonthlyPAymenttextBox1";
            this.MonthlyPAymenttextBox1.Size = new System.Drawing.Size(228, 40);
            this.MonthlyPAymenttextBox1.TabIndex = 46;
            // 
            // propertyCalcBttn
            // 
            this.propertyCalcBttn.Location = new System.Drawing.Point(343, 247);
            this.propertyCalcBttn.Name = "propertyCalcBttn";
            this.propertyCalcBttn.Size = new System.Drawing.Size(75, 35);
            this.propertyCalcBttn.TabIndex = 45;
            this.propertyCalcBttn.Text = "Calculate";
            this.propertyCalcBttn.UseVisualStyleBackColor = true;
            this.propertyCalcBttn.Click += new System.EventHandler(this.propertyCalcBttn_Click);
            // 
            // monthBuyTxtBx
            // 
            this.monthBuyTxtBx.Location = new System.Drawing.Point(450, 211);
            this.monthBuyTxtBx.Name = "monthBuyTxtBx";
            this.monthBuyTxtBx.Size = new System.Drawing.Size(100, 20);
            this.monthBuyTxtBx.TabIndex = 44;
            this.monthBuyTxtBx.TextChanged += new System.EventHandler(this.monthBuyTxtBx_TextChanged);
            this.monthBuyTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthBuyTxtBx_KeyPress);
            // 
            // interestBuyTxtBox
            // 
            this.interestBuyTxtBox.Location = new System.Drawing.Point(450, 181);
            this.interestBuyTxtBox.Name = "interestBuyTxtBox";
            this.interestBuyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.interestBuyTxtBox.TabIndex = 43;
            this.interestBuyTxtBox.TextChanged += new System.EventHandler(this.interestBuyTxtBox_TextChanged);
            this.interestBuyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestBuyTxtBox_KeyPress);
            // 
            // depositTxtBx
            // 
            this.depositTxtBx.Location = new System.Drawing.Point(450, 151);
            this.depositTxtBx.Name = "depositTxtBx";
            this.depositTxtBx.Size = new System.Drawing.Size(100, 20);
            this.depositTxtBx.TabIndex = 42;
            this.depositTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositTxtBx_KeyPress);
            // 
            // propertyTxtBox
            // 
            this.propertyTxtBox.Location = new System.Drawing.Point(450, 119);
            this.propertyTxtBox.Name = "propertyTxtBox";
            this.propertyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.propertyTxtBox.TabIndex = 41;
            this.propertyTxtBox.TextChanged += new System.EventHandler(this.propertyTxtBox_TextChanged);
            this.propertyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTxtBox_KeyPress);
            this.propertyTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.propertyTxtBox_Validating);
            // 
            // monthsBuy
            // 
            this.monthsBuy.AutoSize = true;
            this.monthsBuy.Location = new System.Drawing.Point(256, 211);
            this.monthsBuy.Name = "monthsBuy";
            this.monthsBuy.Size = new System.Drawing.Size(88, 13);
            this.monthsBuy.TabIndex = 40;
            this.monthsBuy.Text = "months to repay :";
            // 
            // interestBuy
            // 
            this.interestBuy.AutoSize = true;
            this.interestBuy.Location = new System.Drawing.Point(262, 181);
            this.interestBuy.Name = "interestBuy";
            this.interestBuy.Size = new System.Drawing.Size(82, 13);
            this.interestBuy.TabIndex = 39;
            this.interestBuy.Text = "interest rate(%) :";
            // 
            // depositValue
            // 
            this.depositValue.AutoSize = true;
            this.depositValue.Location = new System.Drawing.Point(262, 151);
            this.depositValue.Name = "depositValue";
            this.depositValue.Size = new System.Drawing.Size(67, 13);
            this.depositValue.TabIndex = 38;
            this.depositValue.Text = "total deposit:";
            // 
            // propertyPrice
            // 
            this.propertyPrice.AutoSize = true;
            this.propertyPrice.Location = new System.Drawing.Point(251, 110);
            this.propertyPrice.Name = "propertyPrice";
            this.propertyPrice.Size = new System.Drawing.Size(136, 13);
            this.propertyPrice.TabIndex = 37;
            this.propertyPrice.Text = "purchase price of property :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "monthly home payment value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(702, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 48;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MonthlyPAymenttextBox1);
            this.Controls.Add(this.propertyCalcBttn);
            this.Controls.Add(this.monthBuyTxtBx);
            this.Controls.Add(this.interestBuyTxtBox);
            this.Controls.Add(this.depositTxtBx);
            this.Controls.Add(this.propertyTxtBox);
            this.Controls.Add(this.monthsBuy);
            this.Controls.Add(this.interestBuy);
            this.Controls.Add(this.depositValue);
            this.Controls.Add(this.propertyPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button propertyCalcBttn;
        private System.Windows.Forms.TextBox monthBuyTxtBx;
        private System.Windows.Forms.TextBox interestBuyTxtBox;
        private System.Windows.Forms.TextBox depositTxtBx;
        private System.Windows.Forms.TextBox propertyTxtBox;
        private System.Windows.Forms.Label monthsBuy;
        private System.Windows.Forms.Label interestBuy;
        private System.Windows.Forms.Label depositValue;
        private System.Windows.Forms.Label propertyPrice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox MonthlyPAymenttextBox1;
        private System.Windows.Forms.Button button1;
    }
}
namespace BugetPlan
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.estInsuranceTxtBx = new System.Windows.Forms.TextBox();
            this.intrstTxtBx = new System.Windows.Forms.TextBox();
            this.purchasePriceTxtBx = new System.Windows.Forms.TextBox();
            this.totalDepositTxtBx = new System.Windows.Forms.TextBox();
            this.estInsurance = new System.Windows.Forms.Label();
            this.purchasePrice = new System.Windows.Forms.Label();
            this.totalDeposit = new System.Windows.Forms.Label();
            this.intrst = new System.Windows.Forms.Label();
            this.modelMakeTxtBx = new System.Windows.Forms.TextBox();
            this.modelMake = new System.Windows.Forms.Label();
            this.textBox_MonthlyCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 50;
            this.button1.Text = "see Calculation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "VEHICLE PURCHASE INFO :";
            // 
            // estInsuranceTxtBx
            // 
            this.estInsuranceTxtBx.Location = new System.Drawing.Point(416, 242);
            this.estInsuranceTxtBx.Name = "estInsuranceTxtBx";
            this.estInsuranceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.estInsuranceTxtBx.TabIndex = 48;
            this.estInsuranceTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estInsuranceTxtBx_KeyPress);
            // 
            // intrstTxtBx
            // 
            this.intrstTxtBx.Location = new System.Drawing.Point(416, 216);
            this.intrstTxtBx.Name = "intrstTxtBx";
            this.intrstTxtBx.Size = new System.Drawing.Size(100, 20);
            this.intrstTxtBx.TabIndex = 47;
            this.intrstTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intrstTxtBx_KeyPress);
            // 
            // purchasePriceTxtBx
            // 
            this.purchasePriceTxtBx.Location = new System.Drawing.Point(416, 155);
            this.purchasePriceTxtBx.Name = "purchasePriceTxtBx";
            this.purchasePriceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.purchasePriceTxtBx.TabIndex = 46;
            this.purchasePriceTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasePriceTxtBx_KeyPress);
            // 
            // totalDepositTxtBx
            // 
            this.totalDepositTxtBx.Location = new System.Drawing.Point(416, 190);
            this.totalDepositTxtBx.Name = "totalDepositTxtBx";
            this.totalDepositTxtBx.Size = new System.Drawing.Size(100, 20);
            this.totalDepositTxtBx.TabIndex = 45;
            this.totalDepositTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalDepositTxtBx_KeyPress);
            // 
            // estInsurance
            // 
            this.estInsurance.AutoSize = true;
            this.estInsurance.Location = new System.Drawing.Point(228, 249);
            this.estInsurance.Name = "estInsurance";
            this.estInsurance.Size = new System.Drawing.Size(129, 13);
            this.estInsurance.TabIndex = 44;
            this.estInsurance.Text = "estm. insurance premium :";
            // 
            // purchasePrice
            // 
            this.purchasePrice.AutoSize = true;
            this.purchasePrice.Location = new System.Drawing.Point(228, 162);
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Size = new System.Drawing.Size(80, 13);
            this.purchasePrice.TabIndex = 43;
            this.purchasePrice.Text = "purchase price:";
            // 
            // totalDeposit
            // 
            this.totalDeposit.AutoSize = true;
            this.totalDeposit.Location = new System.Drawing.Point(228, 193);
            this.totalDeposit.Name = "totalDeposit";
            this.totalDeposit.Size = new System.Drawing.Size(70, 13);
            this.totalDeposit.TabIndex = 42;
            this.totalDeposit.Text = "total deposit :";
            // 
            // intrst
            // 
            this.intrst.AutoSize = true;
            this.intrst.Location = new System.Drawing.Point(228, 223);
            this.intrst.Name = "intrst";
            this.intrst.Size = new System.Drawing.Size(79, 13);
            this.intrst.TabIndex = 41;
            this.intrst.Text = "inerest rate(%) :";
            // 
            // modelMakeTxtBx
            // 
            this.modelMakeTxtBx.Location = new System.Drawing.Point(416, 129);
            this.modelMakeTxtBx.Name = "modelMakeTxtBx";
            this.modelMakeTxtBx.Size = new System.Drawing.Size(100, 20);
            this.modelMakeTxtBx.TabIndex = 40;
            this.modelMakeTxtBx.TextChanged += new System.EventHandler(this.modelMakeTxtBx_TextChanged);
            this.modelMakeTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modelMakeTxtBx_KeyPress);
            // 
            // modelMake
            // 
            this.modelMake.AutoSize = true;
            this.modelMake.Location = new System.Drawing.Point(229, 132);
            this.modelMake.Name = "modelMake";
            this.modelMake.Size = new System.Drawing.Size(88, 13);
            this.modelMake.TabIndex = 39;
            this.modelMake.Text = "model and make:";
            // 
            // textBox_MonthlyCost
            // 
            this.textBox_MonthlyCost.Location = new System.Drawing.Point(362, 377);
            this.textBox_MonthlyCost.Name = "textBox_MonthlyCost";
            this.textBox_MonthlyCost.Size = new System.Drawing.Size(100, 20);
            this.textBox_MonthlyCost.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "the total monthly cost :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MonthlyCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estInsuranceTxtBx);
            this.Controls.Add(this.intrstTxtBx);
            this.Controls.Add(this.purchasePriceTxtBx);
            this.Controls.Add(this.totalDepositTxtBx);
            this.Controls.Add(this.estInsurance);
            this.Controls.Add(this.purchasePrice);
            this.Controls.Add(this.totalDeposit);
            this.Controls.Add(this.intrst);
            this.Controls.Add(this.modelMakeTxtBx);
            this.Controls.Add(this.modelMake);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox estInsuranceTxtBx;
        private System.Windows.Forms.TextBox intrstTxtBx;
        private System.Windows.Forms.TextBox purchasePriceTxtBx;
        private System.Windows.Forms.TextBox totalDepositTxtBx;
        private System.Windows.Forms.Label estInsurance;
        private System.Windows.Forms.Label purchasePrice;
        private System.Windows.Forms.Label totalDeposit;
        private System.Windows.Forms.Label intrst;
        private System.Windows.Forms.TextBox modelMakeTxtBx;
        private System.Windows.Forms.Label modelMake;
        private System.Windows.Forms.TextBox textBox_MonthlyCost;
        private System.Windows.Forms.Label label2;
    }
}
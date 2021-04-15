namespace BugetPlan
{
    partial class Form2
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
            this.radioButtonVehicle = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.radioButtonRent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonVehicle
            // 
            this.radioButtonVehicle.AutoSize = true;
            this.radioButtonVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVehicle.Location = new System.Drawing.Point(355, 258);
            this.radioButtonVehicle.Name = "radioButtonVehicle";
            this.radioButtonVehicle.Size = new System.Drawing.Size(106, 20);
            this.radioButtonVehicle.TabIndex = 20;
            this.radioButtonVehicle.TabStop = true;
            this.radioButtonVehicle.Text = "Buy vehicle";
            this.radioButtonVehicle.UseVisualStyleBackColor = true;
            this.radioButtonVehicle.CheckedChanged += new System.EventHandler(this.radioButtonVehicle_CheckedChanged);
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBuy.Location = new System.Drawing.Point(355, 183);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(114, 20);
            this.radioButtonBuy.TabIndex = 19;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy property";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // radioButtonRent
            // 
            this.radioButtonRent.AutoSize = true;
            this.radioButtonRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRent.Location = new System.Drawing.Point(355, 124);
            this.radioButtonRent.Name = "radioButtonRent";
            this.radioButtonRent.Size = new System.Drawing.Size(58, 20);
            this.radioButtonRent.TabIndex = 18;
            this.radioButtonRent.TabStop = true;
            this.radioButtonRent.Text = "Rent";
            this.radioButtonRent.UseVisualStyleBackColor = true;
            this.radioButtonRent.CheckedChanged += new System.EventHandler(this.radioButtonRent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chose what you want to do below and click OK:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonVehicle);
            this.Controls.Add(this.radioButtonBuy);
            this.Controls.Add(this.radioButtonRent);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonVehicle;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.RadioButton radioButtonRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
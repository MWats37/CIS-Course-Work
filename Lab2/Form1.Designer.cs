namespace Lab2
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
            this.enterPriceLable = new System.Windows.Forms.Label();
            this.mealPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipOutputLable1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipOutputLable2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipOutputLable3 = new System.Windows.Forms.Label();
            this.calculateTipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPriceLable
            // 
            this.enterPriceLable.AutoSize = true;
            this.enterPriceLable.Location = new System.Drawing.Point(94, 80);
            this.enterPriceLable.Name = "enterPriceLable";
            this.enterPriceLable.Size = new System.Drawing.Size(98, 13);
            this.enterPriceLable.TabIndex = 0;
            this.enterPriceLable.Text = "Enter price of meal:";
            // 
            // mealPriceTextBox
            // 
            this.mealPriceTextBox.Location = new System.Drawing.Point(199, 80);
            this.mealPriceTextBox.Name = "mealPriceTextBox";
            this.mealPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.mealPriceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "15 %";
            // 
            // tipOutputLable1
            // 
            this.tipOutputLable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipOutputLable1.Location = new System.Drawing.Point(199, 124);
            this.tipOutputLable1.Name = "tipOutputLable1";
            this.tipOutputLable1.Size = new System.Drawing.Size(100, 23);
            this.tipOutputLable1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "18 %";
            // 
            // tipOutputLable2
            // 
            this.tipOutputLable2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipOutputLable2.Location = new System.Drawing.Point(199, 162);
            this.tipOutputLable2.Name = "tipOutputLable2";
            this.tipOutputLable2.Size = new System.Drawing.Size(100, 22);
            this.tipOutputLable2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "20 %";
            // 
            // tipOutputLable3
            // 
            this.tipOutputLable3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipOutputLable3.Location = new System.Drawing.Point(199, 200);
            this.tipOutputLable3.Name = "tipOutputLable3";
            this.tipOutputLable3.Size = new System.Drawing.Size(100, 23);
            this.tipOutputLable3.TabIndex = 7;
            // 
            // calculateTipButton
            // 
            this.calculateTipButton.Location = new System.Drawing.Point(160, 252);
            this.calculateTipButton.Name = "calculateTipButton";
            this.calculateTipButton.Size = new System.Drawing.Size(87, 24);
            this.calculateTipButton.TabIndex = 8;
            this.calculateTipButton.Text = "Calculate Tip";
            this.calculateTipButton.UseVisualStyleBackColor = true;
            this.calculateTipButton.Click += new System.EventHandler(this.calculateTipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateTipButton);
            this.Controls.Add(this.tipOutputLable3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipOutputLable2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipOutputLable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mealPriceTextBox);
            this.Controls.Add(this.enterPriceLable);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPriceLable;
        private System.Windows.Forms.TextBox mealPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipOutputLable1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tipOutputLable2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tipOutputLable3;
        private System.Windows.Forms.Button calculateTipButton;
    }
}


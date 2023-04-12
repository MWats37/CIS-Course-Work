namespace Program3
{
    partial class uThankItWeMakeItForm
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.entreeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.entreeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.initialCostLabel = new System.Windows.Forms.Label();
            this.adjustedCostLabel = new System.Windows.Forms.Label();
            this.shipmentCostLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.initialCostOutLabel = new System.Windows.Forms.Label();
            this.adjustedCostOutLabel = new System.Windows.Forms.Label();
            this.shipmentCostOutLabel = new System.Windows.Forms.Label();
            this.totalPriceOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(160, 67);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City:";
            // 
            // entreeLabel
            // 
            this.entreeLabel.AutoSize = true;
            this.entreeLabel.Location = new System.Drawing.Point(81, 106);
            this.entreeLabel.Name = "entreeLabel";
            this.entreeLabel.Size = new System.Drawing.Size(106, 13);
            this.entreeLabel.TabIndex = 1;
            this.entreeLabel.Text = "Entree/Item Number:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(88, 144);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(99, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity (Servings):";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Louisville",
            "Lexington",
            "Indianapolis",
            "Nashville"});
            this.cityComboBox.Location = new System.Drawing.Point(203, 67);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 3;
            this.cityComboBox.Text = "Choose a City";
            // 
            // entreeTextBox
            // 
            this.entreeTextBox.Location = new System.Drawing.Point(203, 106);
            this.entreeTextBox.Name = "entreeTextBox";
            this.entreeTextBox.Size = new System.Drawing.Size(100, 20);
            this.entreeTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(203, 144);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.Location = new System.Drawing.Point(203, 196);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(75, 23);
            this.calculateCostButton.TabIndex = 6;
            this.calculateCostButton.Text = "Calculate";
            this.calculateCostButton.UseVisualStyleBackColor = true;
            this.calculateCostButton.Click += new System.EventHandler(this.calculateCostButton_Click);
            // 
            // initialCostLabel
            // 
            this.initialCostLabel.AutoSize = true;
            this.initialCostLabel.Location = new System.Drawing.Point(129, 266);
            this.initialCostLabel.Name = "initialCostLabel";
            this.initialCostLabel.Size = new System.Drawing.Size(58, 13);
            this.initialCostLabel.TabIndex = 7;
            this.initialCostLabel.Text = "Initial Cost:";
            // 
            // adjustedCostLabel
            // 
            this.adjustedCostLabel.AutoSize = true;
            this.adjustedCostLabel.Location = new System.Drawing.Point(112, 308);
            this.adjustedCostLabel.Name = "adjustedCostLabel";
            this.adjustedCostLabel.Size = new System.Drawing.Size(75, 13);
            this.adjustedCostLabel.TabIndex = 8;
            this.adjustedCostLabel.Text = "Adjusted Cost:";
            // 
            // shipmentCostLabel
            // 
            this.shipmentCostLabel.AutoSize = true;
            this.shipmentCostLabel.Location = new System.Drawing.Point(109, 351);
            this.shipmentCostLabel.Name = "shipmentCostLabel";
            this.shipmentCostLabel.Size = new System.Drawing.Size(78, 13);
            this.shipmentCostLabel.TabIndex = 9;
            this.shipmentCostLabel.Text = "Shipment Cost:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(120, 391);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 10;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // initialCostOutLabel
            // 
            this.initialCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutLabel.Location = new System.Drawing.Point(203, 256);
            this.initialCostOutLabel.Name = "initialCostOutLabel";
            this.initialCostOutLabel.Size = new System.Drawing.Size(100, 23);
            this.initialCostOutLabel.TabIndex = 11;
            // 
            // adjustedCostOutLabel
            // 
            this.adjustedCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjustedCostOutLabel.Location = new System.Drawing.Point(203, 298);
            this.adjustedCostOutLabel.Name = "adjustedCostOutLabel";
            this.adjustedCostOutLabel.Size = new System.Drawing.Size(100, 23);
            this.adjustedCostOutLabel.TabIndex = 12;
            // 
            // shipmentCostOutLabel
            // 
            this.shipmentCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentCostOutLabel.Location = new System.Drawing.Point(203, 341);
            this.shipmentCostOutLabel.Name = "shipmentCostOutLabel";
            this.shipmentCostOutLabel.Size = new System.Drawing.Size(100, 23);
            this.shipmentCostOutLabel.TabIndex = 13;
            // 
            // totalPriceOutLabel
            // 
            this.totalPriceOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutLabel.Location = new System.Drawing.Point(203, 381);
            this.totalPriceOutLabel.Name = "totalPriceOutLabel";
            this.totalPriceOutLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOutLabel.TabIndex = 14;
            // 
            // uThankItWeMakeItForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 501);
            this.Controls.Add(this.totalPriceOutLabel);
            this.Controls.Add(this.shipmentCostOutLabel);
            this.Controls.Add(this.adjustedCostOutLabel);
            this.Controls.Add(this.initialCostOutLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.shipmentCostLabel);
            this.Controls.Add(this.adjustedCostLabel);
            this.Controls.Add(this.initialCostLabel);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.entreeTextBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.entreeLabel);
            this.Controls.Add(this.cityLabel);
            this.Name = "uThankItWeMakeItForm";
            this.Text = "UThankItWeMakeIt Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label entreeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox entreeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.Label initialCostLabel;
        private System.Windows.Forms.Label adjustedCostLabel;
        private System.Windows.Forms.Label shipmentCostLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label initialCostOutLabel;
        private System.Windows.Forms.Label adjustedCostOutLabel;
        private System.Windows.Forms.Label shipmentCostOutLabel;
        private System.Windows.Forms.Label totalPriceOutLabel;
    }
}


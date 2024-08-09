namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.Windows.Forms.Label createPrizeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            placeNumberValue = new System.Windows.Forms.TextBox();
            placeNumberLabel = new System.Windows.Forms.Label();
            placeNameValue = new System.Windows.Forms.TextBox();
            placeNameLabel = new System.Windows.Forms.Label();
            prizeAmountValue = new System.Windows.Forms.TextBox();
            prizeAmountLabel = new System.Windows.Forms.Label();
            prizePercentageValue = new System.Windows.Forms.TextBox();
            prizePercentabeLabel = new System.Windows.Forms.Label();
            orLabel = new System.Windows.Forms.Label();
            createPrizeButton = new System.Windows.Forms.Button();
            createPrizeLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            createPrizeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new System.Drawing.Size(267, 62);
            createPrizeLabel.TabIndex = 26;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new System.Drawing.Point(337, 106);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new System.Drawing.Size(209, 43);
            placeNumberValue.TabIndex = 28;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            placeNumberLabel.Location = new System.Drawing.Point(45, 99);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new System.Drawing.Size(252, 50);
            placeNumberLabel.TabIndex = 27;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new System.Drawing.Point(337, 155);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new System.Drawing.Size(209, 43);
            placeNameValue.TabIndex = 30;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            placeNameLabel.Location = new System.Drawing.Point(45, 148);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new System.Drawing.Size(215, 50);
            placeNameLabel.TabIndex = 29;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new System.Drawing.Point(337, 204);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new System.Drawing.Size(209, 43);
            prizeAmountValue.TabIndex = 32;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            prizeAmountLabel.Location = new System.Drawing.Point(45, 197);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new System.Drawing.Size(244, 50);
            prizeAmountLabel.TabIndex = 31;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new System.Drawing.Point(337, 387);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new System.Drawing.Size(209, 43);
            prizePercentageValue.TabIndex = 34;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentabeLabel
            // 
            prizePercentabeLabel.AutoSize = true;
            prizePercentabeLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prizePercentabeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            prizePercentabeLabel.Location = new System.Drawing.Point(45, 380);
            prizePercentabeLabel.Name = "prizePercentabeLabel";
            prizePercentabeLabel.Size = new System.Drawing.Size(293, 50);
            prizePercentabeLabel.TabIndex = 33;
            prizePercentabeLabel.Text = "Prize Percentage";
            prizePercentabeLabel.Click += prizePercentabeLabel_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            orLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            orLabel.Location = new System.Drawing.Point(251, 282);
            orLabel.Name = "orLabel";
            orLabel.Size = new System.Drawing.Size(87, 50);
            orLabel.TabIndex = 35;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = System.Drawing.Color.DodgerBlue;
            createPrizeButton.Location = new System.Drawing.Point(170, 494);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new System.Drawing.Size(278, 80);
            createPrizeButton.TabIndex = 36;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(588, 613);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentabeLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentabeLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}
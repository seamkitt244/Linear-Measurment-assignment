namespace linear_measurment
{
    partial class outputLabel
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
            this.InchesToCentimeters = new System.Windows.Forms.RadioButton();
            this.FeetToCentimeters = new System.Windows.Forms.RadioButton();
            this.YardsToMeters = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InchesToCentimeters
            // 
            this.InchesToCentimeters.AutoSize = true;
            this.InchesToCentimeters.Location = new System.Drawing.Point(8, 108);
            this.InchesToCentimeters.Name = "InchesToCentimeters";
            this.InchesToCentimeters.Size = new System.Drawing.Size(251, 29);
            this.InchesToCentimeters.TabIndex = 0;
            this.InchesToCentimeters.TabStop = true;
            this.InchesToCentimeters.Text = "Inches to Centimeters";
            this.InchesToCentimeters.UseVisualStyleBackColor = true;
            // 
            // FeetToCentimeters
            // 
            this.FeetToCentimeters.AutoSize = true;
            this.FeetToCentimeters.Location = new System.Drawing.Point(8, 143);
            this.FeetToCentimeters.Name = "FeetToCentimeters";
            this.FeetToCentimeters.Size = new System.Drawing.Size(231, 29);
            this.FeetToCentimeters.TabIndex = 1;
            this.FeetToCentimeters.TabStop = true;
            this.FeetToCentimeters.Text = "Feet to Centimeters";
            this.FeetToCentimeters.UseVisualStyleBackColor = true;
            // 
            // YardsToMeters
            // 
            this.YardsToMeters.AutoSize = true;
            this.YardsToMeters.Location = new System.Drawing.Point(8, 178);
            this.YardsToMeters.Name = "YardsToMeters";
            this.YardsToMeters.Size = new System.Drawing.Size(196, 29);
            this.YardsToMeters.TabIndex = 2;
            this.YardsToMeters.TabStop = true;
            this.YardsToMeters.Text = "Yards to Meters";
            this.YardsToMeters.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 213);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(225, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Miles to Kilometers";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(155, 266);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 31);
            this.inputTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter value";
            // 
            // upLabel
            // 
            this.upLabel.Location = new System.Drawing.Point(13, 357);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(242, 88);
            this.upLabel.TabIndex = 6;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(8, 303);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(247, 39);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 80);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose which conversion you would like to do?";
            // 
            // outputLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.YardsToMeters);
            this.Controls.Add(this.FeetToCentimeters);
            this.Controls.Add(this.InchesToCentimeters);
            this.Name = "outputLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton InchesToCentimeters;
        private System.Windows.Forms.RadioButton FeetToCentimeters;
        private System.Windows.Forms.RadioButton YardsToMeters;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label2;
    }
}


﻿
namespace NumericUpDownControl
{
    partial class InterestCalculatorForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.principalLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.yearlyAccountBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(243, 10);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(34, 15);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(50, 13);
            this.principalLabel.TabIndex = 1;
            this.principalLabel.Text = "Principal:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(13, 63);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(71, 13);
            this.interestRateLabel.TabIndex = 2;
            this.interestRateLabel.Text = "Interest Rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(47, 111);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(37, 13);
            this.yearsLabel.TabIndex = 3;
            this.yearsLabel.Text = "Years:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(90, 12);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(137, 20);
            this.principalTextBox.TabIndex = 4;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(90, 60);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(137, 20);
            this.interestRateTextBox.TabIndex = 5;
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(90, 109);
            this.yearUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.ReadOnly = true;
            this.yearUpDown.Size = new System.Drawing.Size(137, 20);
            this.yearUpDown.TabIndex = 6;
            this.yearUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(16, 166);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(345, 89);
            this.displayTextBox.TabIndex = 7;
            // 
            // yearlyAccountBalanceLabel
            // 
            this.yearlyAccountBalanceLabel.AutoSize = true;
            this.yearlyAccountBalanceLabel.Location = new System.Drawing.Point(16, 147);
            this.yearlyAccountBalanceLabel.Name = "yearlyAccountBalanceLabel";
            this.yearlyAccountBalanceLabel.Size = new System.Drawing.Size(124, 13);
            this.yearlyAccountBalanceLabel.TabIndex = 8;
            this.yearlyAccountBalanceLabel.Text = "Yearly Account Balance:";
            // 
            // InterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 267);
            this.Controls.Add(this.yearlyAccountBalanceLabel);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.calculateButton);
            this.Name = "InterestCalculatorForm";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label yearlyAccountBalanceLabel;
    }
}


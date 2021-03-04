
namespace MultipleButtons
{
    partial class MultipleButtons
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
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.firstButtonLabel = new System.Windows.Forms.Label();
            this.secondButtonLabel = new System.Windows.Forms.Label();
            this.thirdButtonLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(27, 113);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(111, 35);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "First Button";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(156, 113);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(114, 35);
            this.secondButton.TabIndex = 1;
            this.secondButton.Text = "Second Button";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Location = new System.Drawing.Point(297, 113);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(111, 35);
            this.thirdButton.TabIndex = 2;
            this.thirdButton.Text = "Third Button";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.thirdButton_Click);
            // 
            // firstButtonLabel
            // 
            this.firstButtonLabel.AutoSize = true;
            this.firstButtonLabel.Location = new System.Drawing.Point(24, 20);
            this.firstButtonLabel.Name = "firstButtonLabel";
            this.firstButtonLabel.Size = new System.Drawing.Size(123, 13);
            this.firstButtonLabel.TabIndex = 3;
            this.firstButtonLabel.Text = "First Button with no Style";
            // 
            // secondButtonLabel
            // 
            this.secondButtonLabel.AutoSize = true;
            this.secondButtonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondButtonLabel.Location = new System.Drawing.Point(143, 62);
            this.secondButtonLabel.Name = "secondButtonLabel";
            this.secondButtonLabel.Size = new System.Drawing.Size(159, 15);
            this.secondButtonLabel.TabIndex = 4;
            this.secondButtonLabel.Text = "Second Button with FixedSingle";
            this.secondButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdButtonLabel
            // 
            this.thirdButtonLabel.AutoSize = true;
            this.thirdButtonLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdButtonLabel.Location = new System.Drawing.Point(303, 20);
            this.thirdButtonLabel.Name = "thirdButtonLabel";
            this.thirdButtonLabel.Size = new System.Drawing.Size(131, 15);
            this.thirdButtonLabel.TabIndex = 5;
            this.thirdButtonLabel.Text = "Third Button with Fixed3D";
            this.thirdButtonLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.Location = new System.Drawing.Point(9, 186);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(423, 31);
            this.DescLabel.TabIndex = 6;
            this.DescLabel.Text = "Programming in Visual C# is fun!";
            // 
            // MultipleButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 237);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.thirdButtonLabel);
            this.Controls.Add(this.secondButtonLabel);
            this.Controls.Add(this.firstButtonLabel);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Name = "MultipleButtons";
            this.Text = "Multiple Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button thirdButton;
        private System.Windows.Forms.Label firstButtonLabel;
        private System.Windows.Forms.Label secondButtonLabel;
        private System.Windows.Forms.Label thirdButtonLabel;
        private System.Windows.Forms.Label DescLabel;
    }
}


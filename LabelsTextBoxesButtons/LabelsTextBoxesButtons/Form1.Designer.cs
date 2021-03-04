
namespace LabelsTextBoxesButtons
{
    partial class LabelsTextBoxesButtonsTestForm
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
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(129, 87);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.displayPasswordButton.TabIndex = 0;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPasswordLabel.Location = new System.Drawing.Point(49, 49);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(237, 25);
            this.displayPasswordLabel.TabIndex = 1;
            this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(49, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '•';
            this.inputTextBox.Size = new System.Drawing.Size(237, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // LabelsTextBoxesButtonsTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 128);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.displayPasswordButton);
            this.Name = "LabelsTextBoxesButtonsTestForm";
            this.Text = "Labels, TextBox and Buttons Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayPasswordButton;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}


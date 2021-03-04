
namespace KeyboardEventHandling
{
    partial class KeyDemoForm
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
            this.keyPressedLabel = new System.Windows.Forms.Label();
            this.keyInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyPressedLabel
            // 
            this.keyPressedLabel.AutoSize = true;
            this.keyPressedLabel.Location = new System.Drawing.Point(47, 27);
            this.keyPressedLabel.Name = "keyPressedLabel";
            this.keyPressedLabel.Size = new System.Drawing.Size(68, 13);
            this.keyPressedLabel.TabIndex = 0;
            this.keyPressedLabel.Text = "Key pressed:";
            // 
            // keyInfoLabel
            // 
            this.keyInfoLabel.AutoSize = true;
            this.keyInfoLabel.Location = new System.Drawing.Point(47, 81);
            this.keyInfoLabel.Name = "keyInfoLabel";
            this.keyInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.keyInfoLabel.TabIndex = 1;
            // 
            // KeyDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 289);
            this.Controls.Add(this.keyInfoLabel);
            this.Controls.Add(this.keyPressedLabel);
            this.Name = "KeyDemoForm";
            this.Text = "Key Demo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDemo_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyPressedLabel;
        private System.Windows.Forms.Label keyInfoLabel;
    }
}


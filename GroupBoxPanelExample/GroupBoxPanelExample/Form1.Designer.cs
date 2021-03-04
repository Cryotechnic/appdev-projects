
namespace GroupBoxPanelExample
{
    partial class mainGroupBox
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
            this.hiButton = new System.Windows.Forms.Button();
            this.byeButton = new System.Windows.Forms.Button();
            this.mainGroupBoxLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiButton
            // 
            this.hiButton.Location = new System.Drawing.Point(70, 51);
            this.hiButton.Name = "hiButton";
            this.hiButton.Size = new System.Drawing.Size(75, 23);
            this.hiButton.TabIndex = 0;
            this.hiButton.Text = "Hi";
            this.hiButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.hiButton_Click);
            // 
            // byeButton
            // 
            this.byeButton.Location = new System.Drawing.Point(151, 51);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(75, 23);
            this.byeButton.TabIndex = 1;
            this.byeButton.Text = "Bye";
            this.byeButton.UseVisualStyleBackColor = true;
            this.byeButton.Click += new System.EventHandler(this.byeButton_Click);
            // 
            // mainGroupBoxLabel
            // 
            this.mainGroupBoxLabel.AutoSize = true;
            this.mainGroupBoxLabel.Location = new System.Drawing.Point(67, 21);
            this.mainGroupBoxLabel.Name = "mainGroupBoxLabel";
            this.mainGroupBoxLabel.Size = new System.Drawing.Size(80, 13);
            this.mainGroupBoxLabel.TabIndex = 2;
            this.mainGroupBoxLabel.Text = "Main GroupBox";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.rightButton);
            this.mainPanel.Controls.Add(this.leftButton);
            this.mainPanel.Location = new System.Drawing.Point(70, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(174, 100);
            this.mainPanel.TabIndex = 3;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(4, 4);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "Far left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(156, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "Far right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageLabel.Location = new System.Drawing.Point(42, 192);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(237, 23);
            this.messageLabel.TabIndex = 4;
            // 
            // mainGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 224);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainGroupBoxLabel);
            this.Controls.Add(this.byeButton);
            this.Controls.Add(this.hiButton);
            this.Name = "mainGroupBox";
            this.Text = "GroupBox and Panel Example";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hiButton;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.Label mainGroupBoxLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label messageLabel;
    }
}


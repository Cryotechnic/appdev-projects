
namespace ToolTips
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
            this.components = new System.ComponentModel.Container();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.FirstLabelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SecondLabelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstLabel.Location = new System.Drawing.Point(31, 13);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(76, 15);
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "This is a label.";
            this.FirstLabelTooltip.SetToolTip(this.FirstLabel, "First Label");
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondLabel.Location = new System.Drawing.Point(31, 46);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(103, 15);
            this.SecondLabel.TabIndex = 1;
            this.SecondLabel.Text = "This is another label";
            this.SecondLabelTooltip.SetToolTip(this.SecondLabel, "Second Tooltip");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 116);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.FirstLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.ToolTip FirstLabelTooltip;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.ToolTip SecondLabelTooltip;
    }
}


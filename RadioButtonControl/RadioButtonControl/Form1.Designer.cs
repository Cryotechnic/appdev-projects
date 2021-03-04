
namespace RadioButtonControl
{
    partial class RadioButtonTestForm
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
            this.messageBoxButtons = new System.Windows.Forms.GroupBox();
            this.retryCancelRadioButton = new System.Windows.Forms.RadioButton();
            this.yesNoRadioButton = new System.Windows.Forms.RadioButton();
            this.yesNoCancelRadioButton = new System.Windows.Forms.RadioButton();
            this.abortRetryIgnoreRadioButton = new System.Windows.Forms.RadioButton();
            this.okCancelRadioButton = new System.Windows.Forms.RadioButton();
            this.okRadioButton = new System.Windows.Forms.RadioButton();
            this.messageBoxIcon = new System.Windows.Forms.GroupBox();
            this.warningRadioButton = new System.Windows.Forms.RadioButton();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.questionRadioButton = new System.Windows.Forms.RadioButton();
            this.exclamationRadioButton = new System.Windows.Forms.RadioButton();
            this.informationRadioButton = new System.Windows.Forms.RadioButton();
            this.asteriskRadioButton = new System.Windows.Forms.RadioButton();
            this.handRadioButton = new System.Windows.Forms.RadioButton();
            this.errorRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.messageBoxButtons.SuspendLayout();
            this.messageBoxIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBoxButtons
            // 
            this.messageBoxButtons.Controls.Add(this.retryCancelRadioButton);
            this.messageBoxButtons.Controls.Add(this.yesNoRadioButton);
            this.messageBoxButtons.Controls.Add(this.yesNoCancelRadioButton);
            this.messageBoxButtons.Controls.Add(this.abortRetryIgnoreRadioButton);
            this.messageBoxButtons.Controls.Add(this.okCancelRadioButton);
            this.messageBoxButtons.Controls.Add(this.okRadioButton);
            this.messageBoxButtons.Location = new System.Drawing.Point(13, 13);
            this.messageBoxButtons.Name = "messageBoxButtons";
            this.messageBoxButtons.Size = new System.Drawing.Size(147, 162);
            this.messageBoxButtons.TabIndex = 0;
            this.messageBoxButtons.TabStop = false;
            this.messageBoxButtons.Text = "Button Type";
            // 
            // retryCancelRadioButton
            // 
            this.retryCancelRadioButton.AutoSize = true;
            this.retryCancelRadioButton.Location = new System.Drawing.Point(7, 135);
            this.retryCancelRadioButton.Name = "retryCancelRadioButton";
            this.retryCancelRadioButton.Size = new System.Drawing.Size(83, 17);
            this.retryCancelRadioButton.TabIndex = 5;
            this.retryCancelRadioButton.TabStop = true;
            this.retryCancelRadioButton.Text = "RetryCancel";
            this.retryCancelRadioButton.UseVisualStyleBackColor = true;
            this.retryCancelRadioButton.CheckedChanged += new System.EventHandler(this.retryCancelRadioButton_CheckedChanged);
            // 
            // yesNoRadioButton
            // 
            this.yesNoRadioButton.AutoSize = true;
            this.yesNoRadioButton.Location = new System.Drawing.Point(7, 112);
            this.yesNoRadioButton.Name = "yesNoRadioButton";
            this.yesNoRadioButton.Size = new System.Drawing.Size(57, 17);
            this.yesNoRadioButton.TabIndex = 4;
            this.yesNoRadioButton.TabStop = true;
            this.yesNoRadioButton.Text = "YesNo";
            this.yesNoRadioButton.UseVisualStyleBackColor = true;
            this.yesNoRadioButton.CheckedChanged += new System.EventHandler(this.yesNoRadioButton_CheckedChanged);
            // 
            // yesNoCancelRadioButton
            // 
            this.yesNoCancelRadioButton.AutoSize = true;
            this.yesNoCancelRadioButton.Location = new System.Drawing.Point(6, 89);
            this.yesNoCancelRadioButton.Name = "yesNoCancelRadioButton";
            this.yesNoCancelRadioButton.Size = new System.Drawing.Size(90, 17);
            this.yesNoCancelRadioButton.TabIndex = 3;
            this.yesNoCancelRadioButton.TabStop = true;
            this.yesNoCancelRadioButton.Text = "YesNoCancel";
            this.yesNoCancelRadioButton.UseVisualStyleBackColor = true;
            this.yesNoCancelRadioButton.CheckedChanged += new System.EventHandler(this.yesNoCancelRadioButton_CheckedChanged);
            // 
            // abortRetryIgnoreRadioButton
            // 
            this.abortRetryIgnoreRadioButton.AutoSize = true;
            this.abortRetryIgnoreRadioButton.Location = new System.Drawing.Point(6, 66);
            this.abortRetryIgnoreRadioButton.Name = "abortRetryIgnoreRadioButton";
            this.abortRetryIgnoreRadioButton.Size = new System.Drawing.Size(105, 17);
            this.abortRetryIgnoreRadioButton.TabIndex = 2;
            this.abortRetryIgnoreRadioButton.TabStop = true;
            this.abortRetryIgnoreRadioButton.Text = "AbortRetryIgnore";
            this.abortRetryIgnoreRadioButton.UseVisualStyleBackColor = true;
            this.abortRetryIgnoreRadioButton.CheckedChanged += new System.EventHandler(this.abortRetryIgnoreRadioButton_CheckedChanged);
            // 
            // okCancelRadioButton
            // 
            this.okCancelRadioButton.AutoSize = true;
            this.okCancelRadioButton.Location = new System.Drawing.Point(7, 43);
            this.okCancelRadioButton.Name = "okCancelRadioButton";
            this.okCancelRadioButton.Size = new System.Drawing.Size(73, 17);
            this.okCancelRadioButton.TabIndex = 1;
            this.okCancelRadioButton.TabStop = true;
            this.okCancelRadioButton.Text = "OKCancel";
            this.okCancelRadioButton.UseVisualStyleBackColor = true;
            this.okCancelRadioButton.CheckedChanged += new System.EventHandler(this.okCancelRadioButton_CheckedChanged);
            // 
            // okRadioButton
            // 
            this.okRadioButton.AutoSize = true;
            this.okRadioButton.Location = new System.Drawing.Point(7, 20);
            this.okRadioButton.Name = "okRadioButton";
            this.okRadioButton.Size = new System.Drawing.Size(40, 17);
            this.okRadioButton.TabIndex = 0;
            this.okRadioButton.TabStop = true;
            this.okRadioButton.Text = "OK";
            this.okRadioButton.UseVisualStyleBackColor = true;
            this.okRadioButton.CheckedChanged += new System.EventHandler(this.okRadioButton_CheckedChanged);
            // 
            // messageBoxIcon
            // 
            this.messageBoxIcon.Controls.Add(this.warningRadioButton);
            this.messageBoxIcon.Controls.Add(this.stopRadioButton);
            this.messageBoxIcon.Controls.Add(this.questionRadioButton);
            this.messageBoxIcon.Controls.Add(this.exclamationRadioButton);
            this.messageBoxIcon.Controls.Add(this.informationRadioButton);
            this.messageBoxIcon.Controls.Add(this.asteriskRadioButton);
            this.messageBoxIcon.Controls.Add(this.handRadioButton);
            this.messageBoxIcon.Controls.Add(this.errorRadioButton);
            this.messageBoxIcon.Location = new System.Drawing.Point(174, 13);
            this.messageBoxIcon.Name = "messageBoxIcon";
            this.messageBoxIcon.Size = new System.Drawing.Size(147, 204);
            this.messageBoxIcon.TabIndex = 1;
            this.messageBoxIcon.TabStop = false;
            this.messageBoxIcon.Text = "Icon";
            // 
            // warningRadioButton
            // 
            this.warningRadioButton.AutoSize = true;
            this.warningRadioButton.Location = new System.Drawing.Point(6, 181);
            this.warningRadioButton.Name = "warningRadioButton";
            this.warningRadioButton.Size = new System.Drawing.Size(65, 17);
            this.warningRadioButton.TabIndex = 13;
            this.warningRadioButton.TabStop = true;
            this.warningRadioButton.Text = "Warning";
            this.warningRadioButton.UseVisualStyleBackColor = true;
            this.warningRadioButton.CheckedChanged += new System.EventHandler(this.warningRadioButton_CheckedChanged);
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Location = new System.Drawing.Point(6, 158);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(47, 17);
            this.stopRadioButton.TabIndex = 12;
            this.stopRadioButton.TabStop = true;
            this.stopRadioButton.Text = "Stop";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            this.stopRadioButton.CheckedChanged += new System.EventHandler(this.stopRadioButton_CheckedChanged);
            // 
            // questionRadioButton
            // 
            this.questionRadioButton.AutoSize = true;
            this.questionRadioButton.Location = new System.Drawing.Point(7, 135);
            this.questionRadioButton.Name = "questionRadioButton";
            this.questionRadioButton.Size = new System.Drawing.Size(67, 17);
            this.questionRadioButton.TabIndex = 11;
            this.questionRadioButton.TabStop = true;
            this.questionRadioButton.Text = "Question";
            this.questionRadioButton.UseVisualStyleBackColor = true;
            this.questionRadioButton.CheckedChanged += new System.EventHandler(this.questionRadioButton_CheckedChanged);
            // 
            // exclamationRadioButton
            // 
            this.exclamationRadioButton.AutoSize = true;
            this.exclamationRadioButton.Location = new System.Drawing.Point(6, 66);
            this.exclamationRadioButton.Name = "exclamationRadioButton";
            this.exclamationRadioButton.Size = new System.Drawing.Size(82, 17);
            this.exclamationRadioButton.TabIndex = 8;
            this.exclamationRadioButton.TabStop = true;
            this.exclamationRadioButton.Text = "Exclamation";
            this.exclamationRadioButton.UseVisualStyleBackColor = true;
            this.exclamationRadioButton.CheckedChanged += new System.EventHandler(this.exclamationRadioButton_CheckedChanged);
            // 
            // informationRadioButton
            // 
            this.informationRadioButton.AutoSize = true;
            this.informationRadioButton.Location = new System.Drawing.Point(7, 112);
            this.informationRadioButton.Name = "informationRadioButton";
            this.informationRadioButton.Size = new System.Drawing.Size(77, 17);
            this.informationRadioButton.TabIndex = 10;
            this.informationRadioButton.TabStop = true;
            this.informationRadioButton.Text = "Information";
            this.informationRadioButton.UseVisualStyleBackColor = true;
            this.informationRadioButton.CheckedChanged += new System.EventHandler(this.informationRadioButton_CheckedChanged);
            // 
            // asteriskRadioButton
            // 
            this.asteriskRadioButton.AutoSize = true;
            this.asteriskRadioButton.Location = new System.Drawing.Point(7, 20);
            this.asteriskRadioButton.Name = "asteriskRadioButton";
            this.asteriskRadioButton.Size = new System.Drawing.Size(62, 17);
            this.asteriskRadioButton.TabIndex = 6;
            this.asteriskRadioButton.TabStop = true;
            this.asteriskRadioButton.Text = "Asterisk";
            this.asteriskRadioButton.UseVisualStyleBackColor = true;
            this.asteriskRadioButton.CheckedChanged += new System.EventHandler(this.asteriskRadioButton_CheckedChanged);
            // 
            // handRadioButton
            // 
            this.handRadioButton.AutoSize = true;
            this.handRadioButton.Location = new System.Drawing.Point(6, 89);
            this.handRadioButton.Name = "handRadioButton";
            this.handRadioButton.Size = new System.Drawing.Size(51, 17);
            this.handRadioButton.TabIndex = 9;
            this.handRadioButton.TabStop = true;
            this.handRadioButton.Text = "Hand";
            this.handRadioButton.UseVisualStyleBackColor = true;
            this.handRadioButton.CheckedChanged += new System.EventHandler(this.handRadioButton_CheckedChanged);
            // 
            // errorRadioButton
            // 
            this.errorRadioButton.AutoSize = true;
            this.errorRadioButton.Location = new System.Drawing.Point(7, 43);
            this.errorRadioButton.Name = "errorRadioButton";
            this.errorRadioButton.Size = new System.Drawing.Size(47, 17);
            this.errorRadioButton.TabIndex = 7;
            this.errorRadioButton.TabStop = true;
            this.errorRadioButton.Text = "Error";
            this.errorRadioButton.UseVisualStyleBackColor = true;
            this.errorRadioButton.CheckedChanged += new System.EventHandler(this.errorRadioButton_CheckedChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 181);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(147, 36);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Location = new System.Drawing.Point(10, 234);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(311, 23);
            this.displayLabel.TabIndex = 3;
            // 
            // RadioButtonTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 267);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.messageBoxIcon);
            this.Controls.Add(this.messageBoxButtons);
            this.Name = "RadioButtonTestForm";
            this.Text = "Demonstrating Radio Buttons";
            this.messageBoxButtons.ResumeLayout(false);
            this.messageBoxButtons.PerformLayout();
            this.messageBoxIcon.ResumeLayout(false);
            this.messageBoxIcon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox messageBoxButtons;
        private System.Windows.Forms.GroupBox messageBoxIcon;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.RadioButton retryCancelRadioButton;
        private System.Windows.Forms.RadioButton yesNoRadioButton;
        private System.Windows.Forms.RadioButton yesNoCancelRadioButton;
        private System.Windows.Forms.RadioButton abortRetryIgnoreRadioButton;
        private System.Windows.Forms.RadioButton okCancelRadioButton;
        private System.Windows.Forms.RadioButton okRadioButton;
        private System.Windows.Forms.RadioButton warningRadioButton;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton questionRadioButton;
        private System.Windows.Forms.RadioButton exclamationRadioButton;
        private System.Windows.Forms.RadioButton informationRadioButton;
        private System.Windows.Forms.RadioButton asteriskRadioButton;
        private System.Windows.Forms.RadioButton handRadioButton;
        private System.Windows.Forms.RadioButton errorRadioButton;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonControl
{
    public partial class RadioButtonTestForm : Form
    {
        private MessageBoxIcon iconType;
        private MessageBoxButtons buttonType;
        public RadioButtonTestForm()
        {
            InitializeComponent();
        }

        private void okRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okRadioButton)
                buttonType = MessageBoxButtons.OK;
        }

        private void okCancelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okCancelRadioButton)
                buttonType = MessageBoxButtons.OKCancel;
        }

        private void abortRetryIgnoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == abortRetryIgnoreRadioButton)
                buttonType = MessageBoxButtons.AbortRetryIgnore;
        }

        private void yesNoCancelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == yesNoCancelRadioButton)
                buttonType = MessageBoxButtons.YesNoCancel;
        }

        private void yesNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == yesNoRadioButton)
                buttonType = MessageBoxButtons.YesNo;
        }

        private void retryCancelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == retryCancelRadioButton)
                buttonType = MessageBoxButtons.RetryCancel;
        }

        private void asteriskRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton)
                iconType = MessageBoxIcon.Asterisk;
        }

        private void errorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == errorRadioButton)
                iconType = MessageBoxIcon.Error;
        }

        private void exclamationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == exclamationRadioButton)
                iconType = MessageBoxIcon.Exclamation;
        }

        private void handRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == handRadioButton)
                iconType = MessageBoxIcon.Hand;
        }

        private void informationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == informationRadioButton)
                iconType = MessageBoxIcon.Information;
        }

        private void questionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == questionRadioButton)
                iconType = MessageBoxIcon.Question;
        }

        private void stopRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == stopRadioButton)
                iconType = MessageBoxIcon.Stop;
        }

        private void warningRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == warningRadioButton)
                iconType = MessageBoxIcon.Warning;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This is your Custom MessageBox.", "Custom MessageBox",
                buttonType, iconType);

            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed.";
                    break;
                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed";
                    break;
                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed";
                    break;
                case DialogResult.No:
                    displayLabel.Text = "No was pressed.";
                    break;
            }
        }
    }
}

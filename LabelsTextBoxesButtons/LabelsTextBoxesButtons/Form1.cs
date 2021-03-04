using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelsTextBoxesButtons
{
    public partial class LabelsTextBoxesButtonsTestForm : Form
    {
        public LabelsTextBoxesButtonsTestForm()
        {
            InitializeComponent();
        }

        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputTextBox.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxControl
{
    public partial class checkBoxTestForm : Form
    {
        public checkBoxTestForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font (outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleButtons
{
    public partial class MultipleButtons : Form
    {
        public MultipleButtons()
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on the first button.");
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on the second button.");
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on the third button.");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentialTrivia
{
    public partial class presidentialTriviaForm : Form
    {
        public presidentialTriviaForm()
        {
            InitializeComponent();
        }

        private void showAnswerbutton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Theodore Roosevelt";
        }
    }
}

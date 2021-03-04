﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class PictureBoxTestForm : Form
    {
        private int imageNum = -1;
        public PictureBoxTestForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 3;

            imagePictureBox.Image = (Image)(Properties.Resources.ResourceManager
                .GetObject(string.Format("image{0}", imageNum)));
        }
    }
}

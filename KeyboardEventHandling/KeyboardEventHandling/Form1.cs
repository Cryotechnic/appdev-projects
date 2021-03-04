using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardEventHandling
{
    public partial class KeyDemoForm : Form
    {
        public KeyDemoForm()
        {
            InitializeComponent();
        }

        private void KeyDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressedLabel.Text = "Key pressed: " + e.KeyChar;
        }

        private void KeyDemo_KeyDown(object sender, KeyEventArgs e)
        {
            keyInfoLabel.Text =
                "Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
                "Shift: " + (e.Shift ? "Yes" : "No") + '\n' +
                "Ctrl: " + (e.Control ? "Yes" : "No") + '\n' +
                "KeyCode: " + e.KeyCode + '\n' +
                "KeyData " + e.KeyData + '\n' +
                "KeyValue: " + e.KeyValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        private int wordCount = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            buttonSend.Text = "hej";
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            /*
            if (buttonSend.Enabled)
            {
                buttonSend.Enabled = false;
                buttonLock.Text = "Unlock";
            }
            else
            {
                buttonSend.Enabled = true;
                buttonLock.Text = "Lock";
            }
            */

            //buttonSend.Enabled = !buttonSend.Enabled;
        }

        private void buttonClickCount_Click(object sender, EventArgs e)
        {
            clickCount++;
            buttonClickCount.Text = clickCount.ToString();
        }

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = textBoxMessage.Text.ToUpper();
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = textBoxMessage.Text.ToLower();
        }

        private void buttonWordSwap_Click(object sender, EventArgs e)
        {
            var words = textBoxMessage.Text.Split(' ');

            wordCount++;
            if (wordCount >= words.Length)
            {
                wordCount = 0;
            }

            buttonWordSwap.Text = words[wordCount];

            

        }
    }
}

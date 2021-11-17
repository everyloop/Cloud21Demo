using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMultiForms
{
    public partial class Form2 : Form
    {
        public string ButtonName
        {
            get
            {
                return textBoxButtonName.Text;
            }
            set
            {
                textBoxButtonName.Text = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

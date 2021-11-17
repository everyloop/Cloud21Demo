using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMultiForms
{
    public partial class Form1 : Form
    {
        private int buttonCount = 0;
        // private Button activeButton;
        public Form1()
        {
            InitializeComponent();
            //activeButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            var myButton = new Button()
            {
                Location = new System.Drawing.Point(212, 88 + 50 + buttonCount * 50),
                Name = "b" + buttonCount,
                Size = new System.Drawing.Size(94, 29),
                TabIndex = 0,
                Text = "b" + buttonCount,
                UseVisualStyleBackColor = true
            };

            myButton.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(myButton);

            buttonCount++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }
    }

    // Övningsuppgift: Generera 10 x 10 knappar, med talen 0 - 99
    // När man klickar på en knapp visas en messagebox med numret på knappen.
    // [0] [1] ... [9]
    // [10] [11] ... [19]
    // ...
    // [90] .. [99]
}

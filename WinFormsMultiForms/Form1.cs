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
        public Form1()
        {
            InitializeComponent();
            GenerateButtons();
        }

        public void GenerateButtons()
        {
            for (int y = 0; y < 10 ; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    var myButton = new Button()
                    {
                        Location = new Point(x * 60 + 10, y * 50 + 10),
                        Text = (y * 10 + x).ToString(),
                        Size = new Size(55, 29),
                        TabIndex = y * 10 + x
                    };

                    this.Controls.Add(myButton);
                    myButton.Click += MyButton_Click;
                }
            }
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as Button).Text);
            //(sender as Button).Visible = false;

            using (var editForm = new Form2())
            {
                editForm.ButtonName = (sender as Button).Text;
                editForm.ShowDialog();
                (sender as Button).Text = editForm.ButtonName;
            }
        }
    }

    // Övningsuppgift: Generera 10 x 10 knappar, med talen 0 - 99
    // När man klickar på en knapp visas en messagebox med numret på knappen.
    // [0] [1] ... [9]
    // [10] [11] ... [19]
    // ...
    // [90] .. [99]
}

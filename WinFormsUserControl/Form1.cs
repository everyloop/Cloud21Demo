using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUserControl
{
    public partial class Form1 : Form
    {
        public void SetTextbox(string text)
        {
            textBox1.Text = text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(textBox1.Text);

            var userControl = new UserControl1(this);
            userControl.Dock = DockStyle.Fill;
            userControl.ColorSelected += UserControl_ColorSelected;

            var tabCount = tabControl1.TabPages.Count;
            var activePage = tabControl1.TabPages[tabCount - 1];
            activePage.Controls.Add(userControl);

            userControl.AddComboboxItem(textBox1.Text);
            tabControl1.SelectedTab = activePage;
        }

        private void UserControl_ColorSelected(object sender, EventArgs e)
        {
            textBox1.Text = "Color selected";
        }
    }
}

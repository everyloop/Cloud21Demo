using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUserControl
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler ColorSelected;

        private Form1 form = null;

        public UserControl1()
        {
            InitializeComponent();
            AddComboboxItem("Fredrik");
        }

        public UserControl1(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // form.SetTextbox(comboBox1.Text);

            ColorSelected?.Invoke(this, EventArgs.Empty);
        }

        public void AddComboboxItem(string text)
        {
            comboBox1.Items.Add(text);
        }
    }
}

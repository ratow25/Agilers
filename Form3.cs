using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agilers
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1Q1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.ShowDialog();

            this.Hide();
        }

        private void btn2Q1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.ShowDialog();

            this.Hide();
        }
    }
}

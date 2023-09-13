using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agilers
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btn2Q1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();

            form7.ShowDialog();

            this.Hide();
        }
    }
}

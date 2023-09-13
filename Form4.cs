using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agilers
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn1Q1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.ShowDialog();
            
            this.Hide();
        }
    }
}

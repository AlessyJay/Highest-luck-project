using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Highest_Luck
{
    public partial class Form3 : Form
    {
        Random random = new Random();
        public Form3()
        {
            InitializeComponent();
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            Form3 f3 = new Form3();
            f3.Resize = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.Parse(lblScore.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Highest_Luck
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            playersBox.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're going back to main menu, are you sure?", "Closing", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int numPlayerParse = int.Parse(txtNumberOfPlayer.Text);
            int roundNumParse = int.Parse(txtRound.Text);

            if (numPlayerParse < 2 || numPlayerParse > 4)
            {
                lblErrorNumPlayer.ForeColor = Color.Red; 
                lblErrorNumPlayer.Text = "Players cannot be more than 4 or less than 2!";
            } else
            {
                lblErrorNumPlayer.ForeColor = Color.Green;
                lblErrorNumPlayer.Text = "OK";
            }

            if(roundNumParse > 30 || roundNumParse < 5 )
            {
                lblErrorRound.ForeColor = Color.Red;
                lblErrorRound.Text = "Rounds cannot be less than 5 and more than 30!";
            } else
            {
                lblErrorRound.ForeColor = Color.Green;
                lblErrorRound.Text = "OK";
            }
            if(lblErrorNumPlayer.Text == "OK" && lblErrorRound.Text == "OK")
            {
                playersBox.Enabled = true;
                lblErrorStart.Text = null;
                settingBox.Enabled = false;
            } else 
            {
                //do nothing here
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblErrorNumPlayer.Text != "OK" || lblErrorRound.Text != "OK")
            {
                lblErrorStart.ForeColor = Color.Red;
                lblErrorStart.BackColor = Color.Transparent;
                lblErrorStart.Text = $"Please, complete player numbers{"\n"}and rounds before starting the game!";
            }
        }
    }
}

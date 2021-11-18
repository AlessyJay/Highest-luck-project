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
                if(numPlayerParse == 2)
                {
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox5.Enabled = false;
                    groupBox6.Enabled = false;
                } else if(numPlayerParse == 3)
                {
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox6.Enabled = false;
                } else if(numPlayerParse == 4)
                {
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox6.Enabled = true;
                }
                playersBox.Enabled = true;
                lblErrorStart.Text = null;
                settingBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numPlayerParse = int.Parse(txtNumberOfPlayer.Text);
            int roundNumParse = int.Parse(txtRound.Text);

            string player1 = namePlayer1.Text;
            string player2 = namePlayer2.Text;
            string player3 = namePlayer2.Text;
            string player4 = namePlayer3.Text;
            // btn start
            if (lblErrorNumPlayer.Text != "OK" || lblErrorRound.Text != "OK")
            {
                lblErrorStart.ForeColor = Color.Red;
                lblErrorStart.BackColor = Color.Transparent;
                lblErrorStart.Text = $"Please, complete player numbers{"\n"}and rounds before starting the game!";
            }
            if (numPlayerParse == 2 && player1.Trim() == "" || player2.Trim() == "") 
            {
                lblErrorStart.ForeColor = Color.Red;
                lblErrorStart.Text = "Players' name cannot be null";
            } else if(numPlayerParse == 3 && player1.Trim() == "" || player2.Trim() == "" || player3.Trim() == "")
            {
                lblErrorStart.ForeColor = Color.Red;
                lblErrorStart.Text = "Players' name cannot be null";
            } else if(numPlayerParse == 4 && player1.Trim() == "" || player2.Trim() == "" || player3.Trim() == "" || player4.Trim() == "")
            {
                lblErrorStart.ForeColor = Color.Red;
                lblErrorStart.Text = "Players' name cannot be null";
            }
            else
            {
                if(numPlayerParse == 2)
                {
                    
                }
                lblErrorStart.Text = null;
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
        }
    }
}
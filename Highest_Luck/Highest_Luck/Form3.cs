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
        public static Form3 instance;
        public Label lblName1;
        public Label lblName2;
        public Label lblName3;
        public Label lblName4;
        public Label MaxRound;
        public Label numPlayer;
        public GroupBox firstPlayer;
        public GroupBox secondPlayer;
        public GroupBox thirdPlayer;
        public GroupBox forthPlayer;
        public PictureBox pic1;
        public PictureBox pic2;
        public PictureBox pic3;
        public PictureBox pic4;

        Random random = new Random();
        int remainRound = 1;
        int[] score = new int[4];
        int[] bank = new int[4];
        int index = 0;

        public Form3()
        {
            InitializeComponent();
            instance = this;
            lblName1 = playerName1;
            lblName2 = playerName2;
            lblName3 = playerName3;
            lblName4 = playerName4;
            firstPlayer = player1;
            secondPlayer = player2;
            thirdPlayer = player3;
            forthPlayer = player4;
            MaxRound = lblMaxRound;
            numPlayer = numberPlayer;
            pic1 = playerPic1;
            pic2 = playerPic2;
            pic3 = playerPic3;
            pic4 = playerPic4;
            player3.Visible = false;
            player4.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblRemainRound.Text = remainRound.ToString();
            if (numPlayer.Text == "3")
            {
                player3.Visible = true;
            }
            if (numPlayer.Text == "4")
            {
                player3.Visible = true;
                player4.Visible = true;
            }
            bank1.Text = bank[0].ToString();
            bank2.Text = bank[1].ToString();
            bank3.Text = bank[2].ToString();
            bank4.Text = bank[3].ToString();

            score1.Text = score[0].ToString();
            score2.Text = score[1].ToString();
            score3.Text = score[2].ToString();
            score4.Text = score[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = random.Next(1, (6 + 1));
            randomNumber.Text = r.ToString();
            lblRemainRound.Text = remainRound.ToString();

            if (numPlayer.Text == "2")
            {
                if (index == 0)
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    bank1.Text = keep1.ToString();
                    player1.BackColor = Color.Green;
                    player2.BackColor = Color.WhiteSmoke;
                    index += 1;
                    score[0] += keep1;
                    score1.Text = score[0].ToString();
                    keep2 = 0;
                    bank2.Text = keep2.ToString();
                }
                else
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    bank2.Text = keep2.ToString();
                    player2.BackColor = Color.Green;
                    player1.BackColor = Color.WhiteSmoke;
                    index -= index;
                    remainRound += 1;
                    score[1] += keep2;
                    score2.Text = score[1].ToString();
                    keep1 = 0;
                    bank1.Text = keep1.ToString();
                }
                if (remainRound >= int.Parse(MaxRound.Text) + 1)
                {
                    button1.Enabled = false;
                    if (score[0] < score[1])
                    {
                        MessageBox.Show($"Player {lblName2.Text} win!");
                        player2.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        MessageBox.Show($"Player {lblName1.Text} win!");
                        player2.BackColor = Color.WhiteSmoke;
                    }
                }
            }

            if (numPlayer.Text == "3")
            {
                if (index == 0)
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    bank1.Text = keep1.ToString();
                    player1.BackColor = Color.Green;
                    player2.BackColor = Color.WhiteSmoke;
                    player3.BackColor = Color.WhiteSmoke;
                    index += 1;
                    score[0] += keep1;
                    score1.Text = score[0].ToString();
                    keep2 = 0;
                    keep3 = 0;
                    bank2.Text = keep2.ToString();
                    bank3.Text = keep3.ToString();
                }
                else if (index == 1)
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    bank2.Text = keep2.ToString();
                    player2.BackColor = Color.Green;
                    player1.BackColor = Color.WhiteSmoke;
                    player3.BackColor = Color.WhiteSmoke;
                    index += 1;
                    score[1] += keep2;
                    score2.Text = score[1].ToString();
                    keep1 = 0;
                    keep3 = 0;
                    bank1.Text = keep1.ToString();
                    bank3.Text = keep3.ToString();
                }
                else
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    bank3.Text = keep3.ToString();
                    player2.BackColor = Color.WhiteSmoke;
                    player1.BackColor = Color.WhiteSmoke;
                    player3.BackColor = Color.Green;
                    index -= index;
                    remainRound += 1;
                    score[2] += keep3;
                    score3.Text = score[2].ToString();
                    keep1 = 0;
                    keep2 = 0;
                    bank1.Text = keep1.ToString();
                    bank2.Text = keep2.ToString();
                }
                if (remainRound >= int.Parse(lblMaxRound.Text) + 1)
                {
                    button1.Enabled = false;
                    if (score[0] < score[1] &&
                        score[2] < score[1] &&
                        score[3] < score[1])
                    {
                        MessageBox.Show($"Player {lblName2.Text} win!");
                        player3.BackColor = Color.WhiteSmoke;
                    }
                    else if (score[1] < score[0] &&
                       score[2] < score[0] &&
                       score[3] < score[0])
                    {
                        MessageBox.Show($"Player {lblName1.Text} win!");
                        player3.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        MessageBox.Show($"Player {lblName3.Text} win!");
                        player3.BackColor = Color.WhiteSmoke;
                    }
                }
            }

            if (numPlayer.Text == "4")
            {
                if (index == 0)
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    int keep4 = bank[3] = r;
                    bank1.Text = keep1.ToString();
                    player1.BackColor = Color.Green;
                    player2.BackColor = Color.WhiteSmoke;
                    player3.BackColor = Color.WhiteSmoke;
                    player4.BackColor = Color.WhiteSmoke;
                    index += 1;
                    score[0] += keep1;
                    score1.Text = score[0].ToString();
                    keep2 = 0;
                    keep3 = 0;
                    keep4 = 0;
                    bank2.Text = keep2.ToString();
                    bank3.Text = keep3.ToString();
                    bank4.Text = keep4.ToString();
                }
                else if (index == 1)
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    int keep4 = bank[3] = r;
                    bank2.Text = keep2.ToString();
                    player1.BackColor = Color.WhiteSmoke;
                    player2.BackColor = Color.Green;
                    player3.BackColor = Color.WhiteSmoke;
                    player4.BackColor = Color.WhiteSmoke;
                    index += 1;
                    score[1] += keep2;
                    score2.Text = score[1].ToString();
                    keep1 = 0;
                    keep3 = 0;
                    keep4 = 0;
                    bank1.Text = keep1.ToString();
                    bank3.Text = keep3.ToString();
                    bank4.Text = keep4.ToString();
                }
                else if (index == 2)
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    int keep4 = bank[3] = r;
                    bank3.Text = keep3.ToString();
                    player1.BackColor = Color.WhiteSmoke;
                    player2.BackColor = Color.WhiteSmoke;
                    player3.BackColor = Color.Green;
                    player4.BackColor = Color.WhiteSmoke;
                    index += 1;
                    score[2] += keep3;
                    score3.Text = score[2].ToString();
                    keep1 = 0;
                    keep2 = 0;
                    keep4 = 0;
                    bank1.Text = keep1.ToString();
                    bank2.Text = keep2.ToString();
                    bank4.Text = keep4.ToString();
                }
                else
                {
                    int keep1 = bank[0] = r;
                    int keep2 = bank[1] = r;
                    int keep3 = bank[2] = r;
                    int keep4 = bank[3] = r;
                    bank4.Text = keep4.ToString();
                    player2.BackColor = Color.WhiteSmoke;
                    player1.BackColor = Color.WhiteSmoke;
                    player3.BackColor = Color.WhiteSmoke;
                    player4.BackColor = Color.Green;
                    index -= index;
                    remainRound += 1;
                    score[3] += keep4;
                    score4.Text = score[3].ToString();
                    keep1 = 0;
                    keep2 = 0;
                    keep3 = 0;
                    bank1.Text = keep1.ToString();
                    bank2.Text = keep2.ToString();
                    bank3.Text = keep3.ToString();
                }
                if (remainRound >= int.Parse(lblMaxRound.Text) + 1)
                {
                    button1.Enabled = false;
                    if (score[0] < score[1] &&
                        score[2] < score[1] &&
                        score[3] < score[1])
                    {
                        MessageBox.Show($"Player {lblName2.Text} win!");
                        player4.BackColor = Color.WhiteSmoke;
                    }
                    else if (score[1] < score[0] &&
                        score[2] < score[0] &&
                        score[3] < score[0])
                    {
                        MessageBox.Show($"Player {lblName1.Text} win!");
                        player4.BackColor = Color.WhiteSmoke;
                    }
                    else if (score[0] < score[3] &&
                      score[1] < score[3] &&
                      score[2] < score[3])
                    {
                        MessageBox.Show($"Player {lblName4.Text} win!");
                        player4.BackColor = Color.WhiteSmoke;
                    }
                    else if (score[0] < score[2] &&
                        score[1] < score[2] &&
                        score[3] < score[2])
                    {
                        MessageBox.Show($"Player {lblName3.Text} win!");
                        player4.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }
    }
}
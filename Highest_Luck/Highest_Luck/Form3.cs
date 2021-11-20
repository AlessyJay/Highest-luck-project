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

        int roundStart = 1;

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
            lblRemainRound.Text = roundStart.ToString();
            if (numPlayer.Text == "3")
            {
                player3.Visible = true;
            }
            if(numPlayer.Text == "4")
            {
                player3.Visible = true;
                player4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

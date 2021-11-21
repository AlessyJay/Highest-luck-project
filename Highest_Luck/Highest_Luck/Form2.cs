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
        //Create an instance object for Form2 to link with Form3, passing players' data with instance. 
        public static Form2 instance;
        private string name1;
        private string name2;
        private string name3;
        private string name4;
        private int numPlayerParse;
        private int roundNumParse;

        private string pic1;
        private string pic2;
        private string pic3;
        private string pic4;
        private string pic5;

        //Destructure the picture variables
        string dogPic = "D:\\Vistula\\OOP\\59961_Hoard-Warriors-of-OOP_highest_luck_project_1\\Highest_Luck\\Highest_Luck\\bin\\Debug\\Picture\\dog.jpg";
        string birdPic = "D:\\Vistula\\OOP\\59961_Hoard-Warriors-of-OOP_highest_luck_project_1\\Highest_Luck\\Highest_Luck\\bin\\Debug\\Picture\\bluebird.jpg";
        string manPic = "D:\\Vistula\\OOP\\59961_Hoard-Warriors-of-OOP_highest_luck_project_1\\Highest_Luck\\Highest_Luck\\bin\\Debug\\Picture\\man.jpg";
        string markPic = "D:\\Vistula\\OOP\\59961_Hoard-Warriors-of-OOP_highest_luck_project_1\\Highest_Luck\\Highest_Luck\\bin\\Debug\\Picture\\mark.png";
        string confusedPic = "D:\\Vistula\\OOP\\59961_Hoard-Warriors-of-OOP_highest_luck_project_1\\Highest_Luck\\Highest_Luck\\bin\\Debug\\Picture\\confused.jpg";

        //Encapsulate the variables to prevent mistakes from another Form.
        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }
        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }

        public string Name3
        {
            get { return name3; }
            set { name3 = value; }
        }

        public string Name4
        {
            get { return name4; }
            set { name4 = value; }
        }

        public int NumPlayerParse
        {
            get { return numPlayerParse; }
            set { numPlayerParse = value; }
        }

        public int RoundNumParse
        {
            get { return roundNumParse; }
            set { roundNumParse = value; }
        }

        public string Pic1
        {
            get { return pic1; }
            set { pic1 = value; }
        }
        public string Pic2
        {
            get { return pic2; }
            set { pic2 = value; }
        }
        public string Pic3
        {
            get { return pic3; }
            set { pic3 = value; }
        }
        public string Pic4
        {
            get { return pic4; }
            set { pic4 = value; }
        }
        public string Pic5
        {
            get { return pic5; }
            set { pic5 = value; }
        }

        public Form2()
        {
            InitializeComponent();
            instance = this;
            playersBox.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Picture loading section
            //First player
            pictureBox1.Load(dogPic);
            pictureBox2.Load(birdPic);
            pictureBox3.Load(manPic);
            pictureBox4.Load(markPic);
            pictureBox18.Load(confusedPic);

            pictureBox1.MouseClick += new MouseEventHandler((o, a) => previewPic1.Load(dogPic));
            pictureBox2.MouseClick += new MouseEventHandler((o, a) => previewPic1.Load(birdPic));
            pictureBox3.MouseClick += new MouseEventHandler((o, a) => previewPic1.Load(manPic));
            pictureBox4.MouseClick += new MouseEventHandler((o, a) => previewPic1.Load(markPic));
            pictureBox18.MouseClick += new MouseEventHandler((o, a) => previewPic1.Load(confusedPic));


            //Second player
            pictureBox8.Load(dogPic);
            pictureBox7.Load(birdPic);
            pictureBox6.Load(manPic);
            pictureBox5.Load(markPic);
            pictureBox19.Load(confusedPic);

            pictureBox8.MouseClick += new MouseEventHandler((o, a) => previewPic2.Load(dogPic));
            pictureBox7.MouseClick += new MouseEventHandler((o, a) => previewPic2.Load(birdPic));
            pictureBox6.MouseClick += new MouseEventHandler((o, a) => previewPic2.Load(manPic));
            pictureBox5.MouseClick += new MouseEventHandler((o, a) => previewPic2.Load(markPic));
            pictureBox19.MouseClick += new MouseEventHandler((o, a) => previewPic2.Load(confusedPic));

            //Third player
            pictureBox12.Load(dogPic);
            pictureBox11.Load(birdPic);
            pictureBox10.Load(manPic);
            pictureBox9.Load(markPic);
            pictureBox20.Load(confusedPic);

            pictureBox12.MouseClick += new MouseEventHandler((o, a) => previewPic3.Load(dogPic));
            pictureBox11.MouseClick += new MouseEventHandler((o, a) => previewPic3.Load(birdPic));
            pictureBox10.MouseClick += new MouseEventHandler((o, a) => previewPic3.Load(manPic));
            pictureBox9.MouseClick += new MouseEventHandler((o, a) => previewPic3.Load(markPic));
            pictureBox20.MouseClick += new MouseEventHandler((o, a) => previewPic3.Load(confusedPic));

            //Forth player
            pictureBox16.Load(dogPic);
            pictureBox15.Load(birdPic);
            pictureBox14.Load(manPic);
            pictureBox13.Load(markPic);
            pictureBox21.Load(confusedPic);

            pictureBox16.MouseClick += new MouseEventHandler((o, a) => previewPic4.Load(dogPic));
            pictureBox15.MouseClick += new MouseEventHandler((o, a) => previewPic4.Load(birdPic));
            pictureBox14.MouseClick += new MouseEventHandler((o, a) => previewPic4.Load(manPic));
            pictureBox13.MouseClick += new MouseEventHandler((o, a) => previewPic4.Load(markPic));
            pictureBox21.MouseClick += new MouseEventHandler((o, a) => previewPic4.Load(confusedPic));
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
            NumPlayerParse = int.Parse(txtNumberOfPlayer.Text);
            RoundNumParse = int.Parse(txtRound.Text);

            //Setup box for how many players are attending and how many rounds are they going to play.
            if (NumPlayerParse < 2 || NumPlayerParse > 4)
            {
                lblErrorNumPlayer.ForeColor = Color.Red;
                lblErrorNumPlayer.Text = "Players cannot be more than 4 or less than 2!";
            }
            else
            {
                lblErrorNumPlayer.ForeColor = Color.Green;
                lblErrorNumPlayer.Text = "OK";
            }

            if (RoundNumParse > 30 || RoundNumParse < 5)
            {
                lblErrorRound.ForeColor = Color.Red;
                lblErrorRound.Text = "Rounds cannot be less than 5 and more than 30!";
            }
            else
            {
                lblErrorRound.ForeColor = Color.Green;
                lblErrorRound.Text = "OK";
            }
            if (lblErrorNumPlayer.Text == "OK" && lblErrorRound.Text == "OK")
            {
                if (NumPlayerParse == 2)
                {
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox5.Enabled = false;
                    groupBox6.Enabled = false;
                }
                else if (NumPlayerParse == 3)
                {
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox6.Enabled = false;
                }
                else if (NumPlayerParse == 4)
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
            //Start button
            Name1 = namePlayer1.Text;
            Name2 = namePlayer2.Text;
            Name3 = namePlayer3.Text;
            Name4 = namePlayer4.Text;

            Form3 f3 = new Form3();

            //playersBox numbers and rounds validation if player clicked start button without finishing the setup box.
            if (lblErrorNumPlayer.Text != "OK" || lblErrorRound.Text != "OK")
            {
                lblErrorStart.ForeColor = Color.Red;
                lblErrorStart.BackColor = Color.Transparent;
                lblErrorStart.Text = $"Please, complete player numbers{"\n"}" +
                    $"and rounds before starting the game!";
            }

            //Methology of validation for players setting before entering the playground.
            if (NumPlayerParse == 2)
            {
                if (Name1.Trim() == "" || Name2.Trim() == "" &&
                    previewPic1.Image == previewPic2.Image)
                {
                    lblErrorStart.ForeColor = Color.Red;
                    lblErrorStart.BackColor = Color.Transparent;
                    lblErrorStart.Text = $"Players' name cannot be empty!{"\n"}" +
                        $"Pictures are also shouldn't be the same!";
                }
                else
                {
                    Form3.instance.numPlayer.Text = numPlayerParse.ToString();
                    Form3.instance.MaxRound.Text = RoundNumParse.ToString();
                    Form3.instance.lblName1.Text = Name1;
                    Form3.instance.lblName2.Text = Name2;

                    Form3.instance.firstPlayer.Text = Name1;
                    Form3.instance.secondPlayer.Text = Name2;

                    Form3.instance.pic1.Image = previewPic1.Image;
                    Form3.instance.pic2.Image = previewPic2.Image;
                    lblErrorStart.Text = null;
                    this.Hide();
                    f3.ShowDialog();
                    this.Close();
                }
            }
            else if (NumPlayerParse == 3)
            {
                if (Name1.Trim() == "" ||
                    Name2.Trim() == "" ||
                    Name3.Trim() == "" &&
                    previewPic1.Image == previewPic2.Image ||
                    previewPic1.Image == previewPic3.Image ||
                    previewPic2.Image == previewPic3.Image)
                {
                    lblErrorStart.ForeColor = Color.Red;
                    lblErrorStart.BackColor = Color.Transparent;
                    lblErrorStart.Text = $"Players' name cannot be empty!{"\n"}" +
                        $"Pictures are also shouldn't be the same!";
                }
                else
                {
                    Form3.instance.numPlayer.Text = numPlayerParse.ToString();
                    Form3.instance.MaxRound.Text = RoundNumParse.ToString();
                    Form3.instance.lblName1.Text = Name1;
                    Form3.instance.lblName2.Text = Name2;
                    Form3.instance.lblName3.Text = Name3;

                    Form3.instance.firstPlayer.Text = Name1;
                    Form3.instance.secondPlayer.Text = Name2;
                    Form3.instance.thirdPlayer.Text = Name3;

                    Form3.instance.pic1.Image = previewPic1.Image;
                    Form3.instance.pic2.Image = previewPic2.Image;
                    Form3.instance.pic3.Image = previewPic3.Image;
                    lblErrorStart.Text = null;
                    this.Hide();
                    f3.ShowDialog();
                    this.Close();
                }
            }
            else if (NumPlayerParse == 4)
            {
                if (Name1.Trim() == "" ||
                   Name2.Trim() == "" ||
                   Name3.Trim() == "" ||
                   Name4.Trim() == "" &&
                   previewPic1.Image == previewPic2.Image ||
                   previewPic1.Image == previewPic3.Image ||
                   previewPic1.Image == previewPic4.Image ||
                   previewPic2.Image == previewPic3.Image ||
                   previewPic2.Image == previewPic4.Image ||
                   previewPic3.Image == previewPic4.Image)
                {
                    lblErrorStart.ForeColor = Color.Red;
                    lblErrorStart.BackColor = Color.Transparent;
                    lblErrorStart.Text = $"Players' name cannot be empty!{"\n"}" +
                        $"Pictures are also shouldn't be the same!";
                }
                else
                {
                    Form3.instance.numPlayer.Text = numPlayerParse.ToString();
                    Form3.instance.MaxRound.Text = RoundNumParse.ToString();
                    Form3.instance.lblName1.Text = Name1;
                    Form3.instance.lblName2.Text = Name2;
                    Form3.instance.lblName3.Text = Name3;
                    Form3.instance.lblName4.Text = Name4;

                    Form3.instance.firstPlayer.Text = Name1;
                    Form3.instance.secondPlayer.Text = Name2;
                    Form3.instance.thirdPlayer.Text = Name3;
                    Form3.instance.forthPlayer.Text = Name4;

                    Form3.instance.pic1.Image = previewPic1.Image;
                    Form3.instance.pic2.Image = previewPic2.Image;
                    Form3.instance.pic3.Image = previewPic3.Image;
                    Form3.instance.pic4.Image = previewPic4.Image;
                    lblErrorStart.Text = null;
                    this.Hide();
                    f3.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
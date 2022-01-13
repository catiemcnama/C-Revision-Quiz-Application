using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizApplication
{
    public partial class form1 : Form
    {

        public string path = AppDomain.CurrentDomain.BaseDirectory + @"/users/";

        public form1()
        {
            InitializeComponent();
        } 

        private void Adduserbtn_Click(object sender, EventArgs e)
        {
            Adduser AU = new Adduser();
            AU.Show();

        }

        private void form1_Load(object sender, EventArgs e)
        {
            SplashScreen SS = new SplashScreen();
            SS.Show();

            Usernametxt.BackColor = Color.FromArgb(20, 20, 20);
            passwordtxt.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (File.Exists(path + Usernametxt.Text + ".txt") == true)
            {

                StreamReader reader = new StreamReader
                     (path + Usernametxt.Text + ".txt");
                {
                    string password =
                        File.ReadLines(path + Usernametxt.Text + ".txt").Skip(2).Take(1).First();

                    string isAdmin =
                      File.ReadLines(path + Usernametxt.Text + ".txt").Skip(3).Take(1).First();


                    string userScoreString =
                      File.ReadLines(path + Usernametxt.Text + ".txt").Skip(4).Take(1).First();

                    int userScore = Convert.ToInt32(userScoreString);

                    if (password == passwordtxt.Text)
                    {

                        if (isAdmin == "True")
                        {
                            Admindashboard adminForm = new Admindashboard();
                            adminForm.Show();
                            return;
                        }

                        startgamescreen SG = new startgamescreen();

                        UserSettings.userID = Usernametxt.Text;
                        UserSettings.userTotal = userScore;

                        this.Hide();
                        SG.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }

                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("User doesn't exist!", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Adduser AU = new Adduser();
            AU.Show();

        }
    }
}

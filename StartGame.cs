using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class startgamescreen : Form
    {
        public string usernameID;
        public String path = AppDomain.CurrentDomain.BaseDirectory;
        public int UserScoreTotal;

        public startgamescreen()
        {
            InitializeComponent();
        }

        private void startgamescreen_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = "Username: " + UserSettings.userID;
            pictureBox1.ImageLocation = path + @"\" + UserSettings.userID + ".jpg";
            uScore.Text = UserSettings.userTotal.ToString();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (subjectcb.Text == "Maths" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Maths";
                qWindow.level = "Easy";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Maths" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Maths";
                qWindow.level = "Medium";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Maths" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Maths";
                qWindow.level = "Hard";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Physics" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Physics";
                qWindow.level = "Easy";
                qWindow.Show();
                this.Close();
            }

                if (subjectcb.Text == "Physics" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Physics";
                qWindow.level = "Medium";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Physics" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Physics";
                qWindow.level = "Hard";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Chemistry" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Chemistry";
                qWindow.level = "Easy";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Chemistry" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Chemistry";
                qWindow.level = "Medium";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Chemistry" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Chemistry";
                qWindow.level = "Hard";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Biology" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Biology";
                qWindow.level = "Easy";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Biology" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Biology";
                qWindow.level = "Medium";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Biology" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Biology";
                qWindow.level = "Hard";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Computer Science" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Computer Science";
                qWindow.level = "Easy";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Computer Science" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Computer Science";
                qWindow.level = "Medium";
                qWindow.Show();
                this.Close();
            }

            if (subjectcb.Text == "Computer Science" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Computer Science";
                qWindow.level = "Hard";
                qWindow.Show();
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dn = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dn == DialogResult.Yes)
            {
                
                form1 gn = new form1();
                gn.Show();
                this.Close();

            } else
            {
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmResources FR = new frmResources();
            FR.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmHelp FH = new frmHelp();
            FH.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dn = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dn == DialogResult.Yes)
            {

                form1 gn = new form1();
                gn.Show();
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(subjectcb.Text == "Maths" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Maths";
                qWindow.level = "Easy";
                qWindow.Show();
                
            }

            if (subjectcb.Text == "Maths" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Maths";
                qWindow.level = "Medium";
                qWindow.Show();
             
            }

            if (subjectcb.Text == "Maths" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Maths";
                qWindow.level = "Hard";
                qWindow.Show();
                
            }

            if (subjectcb.Text == "Physics" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Physics";
                qWindow.level = "Easy";
                qWindow.Show();
                
            }

            if (subjectcb.Text == "Physics" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Physics";
                qWindow.level = "Medium";
                qWindow.Show();
               
            }

            if (subjectcb.Text == "Physics" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Physics";
                qWindow.level = "Hard";
                qWindow.Show();
               
            }

            if (subjectcb.Text == "Chemistry" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Chemistry";
                qWindow.level = "Easy";
                qWindow.Show();
                
            }

            if (subjectcb.Text == "Chemistry" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Chemistry";
                qWindow.level = "Medium";
                qWindow.Show();
            
            }

            if (subjectcb.Text == "Chemistry" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Chemistry";
                qWindow.level = "Hard";
                qWindow.Show();
              
            }

            if (subjectcb.Text == "Biology" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Biology";
                qWindow.level = "Easy";
                qWindow.Show();
                
            }

            if (subjectcb.Text == "Biology" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Biology";
                qWindow.level = "Medium";
                qWindow.Show();
           
            }

            if (subjectcb.Text == "Biology" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Biology";
                qWindow.level = "Hard";
                qWindow.Show();
               
            }

            if (subjectcb.Text == "Computer Science" && levelcb.Text == "Easy")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Computer Science";
                qWindow.level = "Easy";
                qWindow.Show();
              
            }

            if (subjectcb.Text == "Computer Science" && levelcb.Text == "Medium")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Computer Science";
                qWindow.level = "Medium";
                qWindow.Show();
            
            }

            if (subjectcb.Text == "Computer Science" && levelcb.Text == "Hard")
            {
                Quiz qWindow = new Quiz();
                qWindow.topic = "Computer Science";
                qWindow.level = "Hard";
                qWindow.Show();
           
           }

        }
        
        private void startgamescreen_Enter(object sender, EventArgs e)
        {
            uScore.Refresh();
        }
    }
}

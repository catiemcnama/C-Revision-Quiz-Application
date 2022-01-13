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
using System.Configuration;
using QuizApplication.Properties;

namespace QuizApplication
{
    public partial class Adduser : Form
    {
        public String path = AppDomain.CurrentDomain.BaseDirectory;
        public string filename;
        public OpenFileDialog fileselector;
        public bool hasImageSelected = false;

        public Adduser()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            fileselector = new OpenFileDialog();
            fileselector.Filter = "JPEG file (*.jpg) |*.jpg";

            if (fileselector.ShowDialog() == DialogResult.OK)
            {

                filename = Path.GetFileName(fileselector.FileName);
                pictureBox1.ImageLocation = fileselector.FileName;
                hasImageSelected = true;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (hasImageSelected == false)
            {
                MessageBox.Show("You must select an avatar!", "Error!",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(Username.Text) ||
                String.IsNullOrEmpty(Firstname.Text) ||
                    String.IsNullOrEmpty(Lastname.Text) ||
                    String.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please complete all fields!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\users\"
                   + Username.Text + ".txt"))
                {
                    MessageBox.Show("Username already exsists!", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                using (StreamWriter SW = new StreamWriter(path + @"\users\"
                   + Username.Text + ".txt", false))
                {
                    SW.WriteLine(Firstname.Text);
                    SW.WriteLine(Lastname.Text);
                    SW.WriteLine(Password.Text);
                    SW.WriteLine("False");
                    SW.WriteLine("0");
                    SW.Close();
                }
                File.Copy(fileselector.FileName, path + Username.Text + ".jpg", true);

                MessageBox.Show("Username successfully created!", "Success!",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

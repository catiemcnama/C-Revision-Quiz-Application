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
    public partial class Admindashboard : Form
    {
       public string path = AppDomain.CurrentDomain.BaseDirectory + @"/users/";

        public Admindashboard()
        {
            InitializeComponent();
        }

        private void showusersbtn_Click(object sender, EventArgs e)
        {

            Deleteuserbtn.Enabled = true;
            MakeAdminbtn.Enabled = true;
            ShowUsers();
        }

        private void ShowUsers()
        {
            dataGridView1.Rows.Clear();

            string[] files = Directory.GetFiles
                (path, "*.txt", SearchOption.AllDirectories);

            foreach (string user in files)
            {
                string username =
                   Path.GetFileName(user.Replace(".txt", ""));

                StreamReader reader = new StreamReader(user);
                {
                    dataGridView1.Rows.Add(
                        username, reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine());
                    reader.Close();
                }
            }
        }

        private void Deleteuserbtn_Click(object sender, EventArgs e)
        {
            string fileName = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();
            File.Delete(path + fileName + ".txt");
            ShowUsers();
        }

        private void MakeAdminbtn_Click(object sender, EventArgs e)
        {
            string fileName = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();

            string line = File.ReadLines(path + @"\" + fileName + ".txt").Skip(3).Take(1).First();

            string line1;
            string line2;
            string line3;
            string line4;
            string adminLine;

            StreamReader reader = new StreamReader(path + @"\" + fileName + ".txt");
            {
                line1 = reader.ReadLine();
                line2 = reader.ReadLine();
                line3 = reader.ReadLine();
                adminLine = reader.ReadLine();
                reader.Close();
            }

            if (adminLine == "False"){

                StreamWriter writer = new StreamWriter(path + @"\" + fileName + ".txt");
                {
                    writer.WriteLine(line1);
                    writer.WriteLine(line2);
                    writer.WriteLine(line3);  
                    writer.WriteLine("True"); //or true
                    writer.Close();

                }
            }

            if (adminLine == "True")
            {

                StreamWriter writer = new StreamWriter(path + @"\" + fileName + ".txt");
                {
                    writer.WriteLine(line1);
                    writer.WriteLine(line2);
                    writer.WriteLine(line3);
                    writer.WriteLine("False"); 
                    writer.Close();
                }
            }

            ShowUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
         Adduser AU = new Adduser();
         AU.Show();
         
        }
      }
    }

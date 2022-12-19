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
using System.Windows.Shapes;

namespace project
{
    public partial class askqs : Form
    {
        private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";
        public  static int qsid = 1;
        public askqs()
        {
            InitializeComponent();
        }
        public static bool checkanonymouse(string username)
        {
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains(username) && line.Contains("YES"))
                {
                   return true;
                }
            }
            return false;
        }
        public static bool search(string s1)
        {        
            foreach (string line in File.ReadLines(path))
            {
                string[] arr = line.Split(',');
                if (arr[1] == s1 )
                    return true;
            }
            return false;
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void qstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string from = UI.str, qs = qstxt.Text, ans = "Not Answered Yet .", to = guna2TextBox2.Text, ano = "";               
            if (newlogin.un.Length > 0)
                from = newlogin.un;
            if (radioButton1.Checked)//no
            {
                ano = "NO";
            }
            if (radioButton2.Checked)//yes
            {                 
                ano = "YES";            
            }  
            if(to.Length==0 || qs.Trim().Length == 0 || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Information Is Not Completed !", "proces Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  if (!search(to))
            {
                MessageBox.Show("Invalid Username", "proces Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (from == to)
            {
                MessageBox.Show("You Can't Ask Question To Yourself", "proces Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (radioButton2.Checked)//ano qs
                {
                    if (!checkanonymouse(to) && ano == "YES")//dont allow
                    {
                        MessageBox.Show("This User Does Not Allow The Anonymous Question", "proces Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else
                    {
                        string s = qsid + "," + from + "," + to + "," + qs + "," + ans + "," + ano + "\n";
                        File.AppendAllText(qspath, s);
                        MessageBox.Show("You Have Sent The Question Successfully", "proces completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        qsid++;

                    }
                }
                else if (radioButton1.Checked)
                {
                     string s = qsid + "," + from + "," + to + "," + qs + "," + ans + "," + ano + "\n";
                     File.AppendAllText(qspath, s);
                     MessageBox.Show("You Have Sent The Question Successfully", "proces completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     qsid++;                   
                }             
            }
        }
    }
}

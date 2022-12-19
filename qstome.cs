using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace project
{
    public partial class qstome : Form
    {
        private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";

        
        public qstome()
        {
            InitializeComponent();
        }

        private void qstome_Load(object sender, EventArgs e)
        {          
            string[] arr = File.ReadAllLines(qspath);
            int cnt = 1,num=0;
            if (arr.Length == 0 || arr[0] == null)
            {
                Questions.Text += "There Is No Quesions !\n";
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                string[]s=arr[i].Split(',');                            
                if (s[2] == UI.str)
                {
                    num++;
                    if (s[5] == "YES")
                    {
                       s[1] = "Unknown";
                    }
                    string ans =cnt.ToString()+ " : "+ " Question From " + s[1] + " : " + s[3] + System.Environment.NewLine;
                    string a ="You : "+ s[4] + System.Environment.NewLine;                  
                    Questions.Text += ans;
                    Questions.Text += a;
                    Questions.Text += System.Environment.NewLine;
                    cnt++;
                }               
            }
            if (num == 0)
            {
                Questions.Text += "There Is No Question Now !! \n";
            }

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

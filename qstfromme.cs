using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class qstfromme : Form
    {
        private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";
        public qstfromme()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qstfromme_Load(object sender, EventArgs e)
        {         
            string[] arr = File.ReadAllLines(qspath);
            int cnt = 1;
            int num = 0;
            if (arr.Length == 0)
            {
                fromme.Text += "There Is No Quesions !\n";
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                string[] s = arr[i].Split(',');
                if (s[1] == UI.str)
                {
                    num++;
                    string ans = cnt.ToString() + " : " + " Question From You "  + " : " + s[3] + System.Environment.NewLine;
                    string a = s[2] +" : " + s[4] + System.Environment.NewLine;
                    fromme.Text += ans;
                    fromme.Text += a;
                    fromme.Text += System.Environment.NewLine;
                    cnt++;
                }
            }
            if (num == 0)
            {
                fromme.Text += "There Is No Question Now !! \n";
            }
        }

        private void fromme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

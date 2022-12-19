using Guna.UI2.WinForms;
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
    public partial class listusers : Form
    {
        private static string path = @"D:\project\user.txt";

        public listusers()
        {
            InitializeComponent();
        }
        private void listusers_Load(object sender, EventArgs e)
        {
            string[] arr = File.ReadAllLines(path);
            for (int i = 0; i < arr.Length; i++)
            {
                string[] s = arr[i].Trim().Split(',');
                listuserstxt.Text += i + 1.ToString() + " : " + s[2].ToString() + "\n" + "\n";
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void listusers_Load_1(object sender, EventArgs e)
        {
            string[] arr = File.ReadAllLines(path);
            for (int i = 0; i < arr.Length; i++)
            {
                string[] s = arr[i].Trim().Split(',');
                if (s[1] != "-")
                {
                    listuserstxt.Text += (i + 1).ToString() + " : " + s[1] + System.Environment.NewLine;
                }
            }
        }
    }
}

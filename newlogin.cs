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

namespace project
{
    public partial class newlogin : Form
    {
        public static string  usern;
        public static string un = "";
        private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";

        public newlogin()
        {
            InitializeComponent();
        }
        public static bool search(string s1, string s2)
        {
            foreach (string line in File.ReadLines(path))
            {
              string[]arr=line.Split(',');
                if (arr[1] == s1 && arr[2] == s2)
                    return true;

            }
            return false;
        }
        private void checkBxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxshowpassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = username.Text;
            string s2 = password.Text;
            if (!search(s1, s2))
            {
                MessageBox.Show("Invalid Password OR Username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
            else
            {
                un = username.Text;
                username.Text = "";
                password.Text = "";
                Hide();
                new UI().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            username.Focus();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (checkBxshowpassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            new register().Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

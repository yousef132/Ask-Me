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
    public partial class register : Form
    {
        private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";
        public static int userid = 1;
        public static string usnm;
        public static string un = "";    
        public register()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }      
        private void checkBxshowpassword_CheckedChanged(object sender, EventArgs e)//show password
        {
            if (checkBxshowpassword.Checked)
            {
                password.PasswordChar = '\0';
                conpassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                conpassword.PasswordChar = '*';
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            password.Text = "";
            conpassword.Text = "";
            username.Text = "";
        }
        private void label6_Click(object sender, EventArgs e)//go to login
        {
            new newlogin().Show(); 
            Hide();
        }
        private void conpassword_TextChanged(object sender, EventArgs e)
        {
            if (checkBxshowpassword.Checked)
            {
                password.PasswordChar = '\0';
                conpassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                conpassword.PasswordChar = '*';
            }
        }
        public static bool search(string s1, string s2)
        {
            foreach (string line in File.ReadLines(path))
            {
                string[] arr = line.Split(',');
                if (arr[1] == s1 && arr[2] == s2)
                    return true;
            }
            return false;
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            if (checkBxshowpassword.Checked)
            {
                password.PasswordChar = '\0';
                conpassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                conpassword.PasswordChar = '*';
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)//end
        {
            Application.Exit(); ;
        }

        private void button1_Click_1(object sender, EventArgs e)//register
        {
            string contents = File.ReadAllText(path);
            if (username.Text.Trim() == "" || password.Text.Trim() == "" || conpassword.Text == "" || (!rbyes.Checked && !rbno.Checked))
            {
                MessageBox.Show("The Information Is Not Complete Yet ", "Registration Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Text == "-" || password.Text == "-")
            {
                MessageBox.Show("This Password Is Not Allowed  ", "Registration Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (password.Text != conpassword.Text)
            {
                MessageBox.Show("Password doesn't match  ", "Registration Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // password.Text = "";
                conpassword.Text = "";
                password.Focus();
            }
            else if (search(password.Text,username.Text))
            {
                MessageBox.Show("You Have Entered Used Password OR Username.  ", "Registration Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbno.Checked)
                {
                    string s = userid + "," + username.Text + "," + password.Text + "," + rbno.Text + "\n";
                    File.AppendAllText(path, s);
                }
                else
                {
                    string s = userid + "," + username.Text + "," + password.Text + "," + rbyes.Text + "\n";
                    File.AppendAllText(path, s);
                }
                MessageBox.Show("Your Account has been Successfuly Created  ", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userid++;
                un = username.Text;
                password.Text = "";
                conpassword.Text = "";
                username.Text = "";
                Hide();
                new UI().Show();
                //home q = new home();
                //q.TopLevel = false;
                //UI.p[0].Controls.Add(q);
                //q.BringToFront();
                //q.Show();
            }
        }

        private void rbno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)//clear
        {
            password.Text = "";
            conpassword.Text = "";
            username.Text = "";
            username.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new newlogin().Show();
            Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

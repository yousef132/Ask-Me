using FontAwesome.Sharp;
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
    public partial class UI : Form
    {
      //  private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";
        public static string str = "";
        public List<Panel> p = new List<Panel>();
        public UI()
        {
            InitializeComponent();
        }   

        private void btn_qs_to_me_Click(object sender, EventArgs e)
        {
            fun();
            //172, 126, 241
            btn_qs_to_me.ForeColor = btn_qs_to_me.IconColor = Color.FromArgb(172, 126, 241);
            formtitle.Text = "Questio To Me";
            formtitle.ForeColor= Color.FromArgb(172, 126, 241);
            //curformicon=Icon.me
            qstome q = new qstome();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();   
            q.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public static bool find(string s1)
        {
            foreach (string line in File.ReadLines(path))
            {
                string[] arr = line.Split(',');
                if (arr[1] == s1)
                { return true; }
            }
            return false;
        }
        private void UI_Load(object sender, EventArgs e)
        {
            if (register.un.Length > 0)
                label1.Text = register.un;
             else if (newlogin.un.Length > 0)
                label1.Text = newlogin.un;
            str = label1.Text;
        }

        private void btn_ask_qs_Click(object sender, EventArgs e)
        {
            fun();
            // 249, 88, 155
            btn_ask_qs.ForeColor = btn_ask_qs.IconColor = Color.FromArgb(249, 88, 155);
            formtitle.Text = "Ask Question";
            formtitle.ForeColor = Color.FromArgb(249, 88, 155);
            askqs q = new askqs();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();
            q.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // 202, 255, 138
            fun();
            btn_logout.ForeColor = btn_logout.IconColor = Color.FromArgb(202, 255, 138);
            string usname = UI.str;
            if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {             
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_qs_from_me_Click(object sender, EventArgs e)
        {
            fun();
            //249, 118, 176
            btn_qs_from_me.ForeColor = btn_qs_from_me.IconColor = Color.FromArgb(249, 118, 176);
            formtitle.Text = "Questio From Me";
            formtitle.ForeColor = Color.FromArgb(249, 118, 176);
            qstfromme q = new qstfromme();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();
            q.Show();
        }

        private void btn_ans_qs_Click(object sender, EventArgs e)
        {
            //253, 138, 114
            fun();
            btn_ans_qs.ForeColor = btn_ans_qs.IconColor = Color.FromArgb(253, 138, 114);
            formtitle.Text = "Answer Question";
            formtitle.ForeColor = Color.FromArgb(253, 138, 114);
            answerqs q = new answerqs();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();
            q.Show();
        }
        private void fun()
        {
            btn_ask_qs.ForeColor = btn_ask_qs.IconColor = Color.White;
            btn_ans_qs.ForeColor = btn_ans_qs.IconColor = Color.White;
            btn_qs_to_me.ForeColor = btn_qs_to_me.IconColor = Color.White;
            btn_qs_from_me.ForeColor = btn_qs_from_me.IconColor = Color.White;
            btn_delet_qs.ForeColor = btn_delet_qs.IconColor = Color.White;
            btn_list_users.ForeColor = btn_list_users.IconColor = Color.White;
            btn_logout.ForeColor = btn_logout.IconColor = Color.White;
           
        }
        private void btn_list_users_Click(object sender, EventArgs e)
        {
            fun();
            btn_list_users.ForeColor =btn_list_users.IconColor= Color.FromArgb(24, 161, 251);
            formtitle.Text = "List System Users";
            formtitle.ForeColor = Color.FromArgb(24, 161, 251);
            listusers q = new listusers();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();
            q.Show();
        }
        private void btn_delet_qs_Click(object sender, EventArgs e)
        {
            fun();
            btn_delet_qs.ForeColor = btn_delet_qs.IconColor = Color.FromArgb(95, 77, 221);
            formtitle.Text = "Delete Question";
            formtitle.ForeColor = Color.FromArgb(95, 77, 221);
            deletquestion q = new deletquestion();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();
            q.Show();

        }
        private void formtitle_Click(object sender, EventArgs e)
        {

        }
        public void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void curformicon_Click(object sender, EventArgs e)
        {
            panel2.Show();         
        }
        private void home_Click(object sender, EventArgs e)
        {
            fun();
            home q = new home();
            q.TopLevel = false;
            panel2.Controls.Add(q);
            q.BringToFront();
            q.Show();
            formtitle.Text = "Home";
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
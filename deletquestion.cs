using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace project
{
    public partial class deletquestion : Form
    {
        //You have to change the path of the 2 files with the files path in your pc
        private static string qspath = @"D:\project\question.txt";
        public deletquestion()
        {
            InitializeComponent();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<string> tmp = new List<string>();
            string[] lines = File.ReadAllLines(qspath);
            bool ok = true;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] s = lines[i].Split(',');
                if (s[1] == UI.str && s[3] == qstxt.Text)
                {
                    ok = false;
                    continue;
                }
                tmp.Add(lines[i]);
            }
            if (ok)
            {
                MessageBox.Show("There Is No Question Like This !! ", "Deletation Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
            else
            {
                File.WriteAllLines(qspath, tmp);
                MessageBox.Show("The Question Deleted Successfully !! ", "Deletation Completed!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

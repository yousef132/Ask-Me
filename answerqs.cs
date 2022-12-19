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
using System.Windows.Shapes;
using static System.Windows.Forms.LinkLabel;

namespace project
{
    public partial class answerqs : Form
    {
        private static string qspath = @"D:\project\question.txt";
        private static string path = @"D:\project\user.txt";
        public answerqs()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {      
            string[] lines = File.ReadAllLines(qspath);
            bool flage = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] arr = lines[i].Split(',');
                if (arr[2] == UI.str && arr[3] == txtqs.Text)
                {
                    flage = true;
                    if(arr[4]!= "Not Answered Yet .")
                    {
                        MessageBox.Show("This Question Is Already Answer OR Question Is Incorrect !!", "proces Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        lines[i] = lines[i].Replace(arr[4], ansqs.Text);
                    }                                     
                }
            }
            if (!flage)
            {
                MessageBox.Show("There Is No Question Like this !!", "proces Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.WriteAllLines(qspath, lines);
                MessageBox.Show("The Question Is Completely Answered .", "proces Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}

using System.Runtime.Remoting.Lifetime;
using System;

namespace project
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new FontAwesome.Sharp.IconButton();
            this.panelmenue = new System.Windows.Forms.Panel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_list_users = new FontAwesome.Sharp.IconButton();
            this.btn_ask_qs = new FontAwesome.Sharp.IconButton();
            this.btn_delet_qs = new FontAwesome.Sharp.IconButton();
            this.btn_ans_qs = new FontAwesome.Sharp.IconButton();
            this.btn_qs_from_me = new FontAwesome.Sharp.IconButton();
            this.btn_qs_to_me = new FontAwesome.Sharp.IconButton();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxperson = new FontAwesome.Sharp.IconPictureBox();
            this.formtitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelmenue.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxperson)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 127);
            this.panel1.TabIndex = 2;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.White;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.IconSize = 100;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(37, 22);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(125, 91);
            this.home.TabIndex = 0;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panelmenue
            // 
            this.panelmenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelmenue.Controls.Add(this.btn_logout);
            this.panelmenue.Controls.Add(this.btn_list_users);
            this.panelmenue.Controls.Add(this.btn_ask_qs);
            this.panelmenue.Controls.Add(this.btn_delet_qs);
            this.panelmenue.Controls.Add(this.btn_ans_qs);
            this.panelmenue.Controls.Add(this.btn_qs_from_me);
            this.panelmenue.Controls.Add(this.btn_qs_to_me);
            this.panelmenue.Controls.Add(this.panel1);
            this.panelmenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenue.Location = new System.Drawing.Point(0, 0);
            this.panelmenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenue.Name = "panelmenue";
            this.panelmenue.Size = new System.Drawing.Size(223, 1012);
            this.panelmenue.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btn_logout.IconColor = System.Drawing.Color.White;
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logout.IconSize = 32;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 793);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_logout.Size = new System.Drawing.Size(223, 89);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_list_users
            // 
            this.btn_list_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_list_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_list_users.FlatAppearance.BorderSize = 0;
            this.btn_list_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_list_users.ForeColor = System.Drawing.Color.White;
            this.btn_list_users.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.btn_list_users.IconColor = System.Drawing.Color.White;
            this.btn_list_users.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_list_users.IconSize = 32;
            this.btn_list_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list_users.Location = new System.Drawing.Point(0, 682);
            this.btn_list_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_list_users.Name = "btn_list_users";
            this.btn_list_users.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_list_users.Size = new System.Drawing.Size(223, 111);
            this.btn_list_users.TabIndex = 8;
            this.btn_list_users.Text = "List system users";
            this.btn_list_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_list_users.UseVisualStyleBackColor = false;
            this.btn_list_users.Click += new System.EventHandler(this.btn_list_users_Click);
            // 
            // btn_ask_qs
            // 
            this.btn_ask_qs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_ask_qs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ask_qs.FlatAppearance.BorderSize = 0;
            this.btn_ask_qs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ask_qs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ask_qs.ForeColor = System.Drawing.Color.White;
            this.btn_ask_qs.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
            this.btn_ask_qs.IconColor = System.Drawing.Color.White;
            this.btn_ask_qs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ask_qs.IconSize = 32;
            this.btn_ask_qs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ask_qs.Location = new System.Drawing.Point(0, 571);
            this.btn_ask_qs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ask_qs.Name = "btn_ask_qs";
            this.btn_ask_qs.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_ask_qs.Size = new System.Drawing.Size(223, 111);
            this.btn_ask_qs.TabIndex = 7;
            this.btn_ask_qs.Text = "Ask question";
            this.btn_ask_qs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ask_qs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ask_qs.UseVisualStyleBackColor = false;
            this.btn_ask_qs.Click += new System.EventHandler(this.btn_ask_qs_Click);
            // 
            // btn_delet_qs
            // 
            this.btn_delet_qs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_delet_qs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delet_qs.FlatAppearance.BorderSize = 0;
            this.btn_delet_qs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delet_qs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_delet_qs.ForeColor = System.Drawing.Color.White;
            this.btn_delet_qs.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_delet_qs.IconColor = System.Drawing.Color.White;
            this.btn_delet_qs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delet_qs.IconSize = 32;
            this.btn_delet_qs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet_qs.Location = new System.Drawing.Point(0, 460);
            this.btn_delet_qs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delet_qs.Name = "btn_delet_qs";
            this.btn_delet_qs.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_delet_qs.Size = new System.Drawing.Size(223, 111);
            this.btn_delet_qs.TabIndex = 6;
            this.btn_delet_qs.Text = "Delete question";
            this.btn_delet_qs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delet_qs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delet_qs.UseVisualStyleBackColor = false;
            this.btn_delet_qs.Click += new System.EventHandler(this.btn_delet_qs_Click);
            // 
            // btn_ans_qs
            // 
            this.btn_ans_qs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_ans_qs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ans_qs.FlatAppearance.BorderSize = 0;
            this.btn_ans_qs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ans_qs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ans_qs.ForeColor = System.Drawing.Color.White;
            this.btn_ans_qs.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btn_ans_qs.IconColor = System.Drawing.Color.White;
            this.btn_ans_qs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ans_qs.IconSize = 32;
            this.btn_ans_qs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ans_qs.Location = new System.Drawing.Point(0, 349);
            this.btn_ans_qs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ans_qs.Name = "btn_ans_qs";
            this.btn_ans_qs.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_ans_qs.Size = new System.Drawing.Size(223, 111);
            this.btn_ans_qs.TabIndex = 5;
            this.btn_ans_qs.Text = "Answer question";
            this.btn_ans_qs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ans_qs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ans_qs.UseVisualStyleBackColor = false;
            this.btn_ans_qs.Click += new System.EventHandler(this.btn_ans_qs_Click);
            // 
            // btn_qs_from_me
            // 
            this.btn_qs_from_me.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_qs_from_me.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qs_from_me.FlatAppearance.BorderSize = 0;
            this.btn_qs_from_me.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qs_from_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_qs_from_me.ForeColor = System.Drawing.Color.White;
            this.btn_qs_from_me.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.btn_qs_from_me.IconColor = System.Drawing.Color.White;
            this.btn_qs_from_me.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_qs_from_me.IconSize = 32;
            this.btn_qs_from_me.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qs_from_me.Location = new System.Drawing.Point(0, 238);
            this.btn_qs_from_me.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qs_from_me.Name = "btn_qs_from_me";
            this.btn_qs_from_me.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_qs_from_me.Size = new System.Drawing.Size(223, 111);
            this.btn_qs_from_me.TabIndex = 4;
            this.btn_qs_from_me.Text = "Questions from me";
            this.btn_qs_from_me.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qs_from_me.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qs_from_me.UseVisualStyleBackColor = false;
            this.btn_qs_from_me.Click += new System.EventHandler(this.btn_qs_from_me_Click);
            // 
            // btn_qs_to_me
            // 
            this.btn_qs_to_me.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_qs_to_me.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qs_to_me.FlatAppearance.BorderSize = 0;
            this.btn_qs_to_me.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qs_to_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_qs_to_me.ForeColor = System.Drawing.Color.White;
            this.btn_qs_to_me.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.btn_qs_to_me.IconColor = System.Drawing.Color.White;
            this.btn_qs_to_me.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_qs_to_me.IconSize = 32;
            this.btn_qs_to_me.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qs_to_me.Location = new System.Drawing.Point(0, 127);
            this.btn_qs_to_me.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qs_to_me.Name = "btn_qs_to_me";
            this.btn_qs_to_me.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btn_qs_to_me.Size = new System.Drawing.Size(223, 111);
            this.btn_qs_to_me.TabIndex = 3;
            this.btn_qs_to_me.Text = "Questions to me";
            this.btn_qs_to_me.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qs_to_me.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qs_to_me.UseVisualStyleBackColor = false;
            this.btn_qs_to_me.Click += new System.EventHandler(this.btn_qs_to_me_Click);
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.paneltitlebar.Controls.Add(this.iconButton2);
            this.paneltitlebar.Controls.Add(this.label1);
            this.paneltitlebar.Controls.Add(this.picboxperson);
            this.paneltitlebar.Controls.Add(this.formtitle);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(223, 0);
            this.paneltitlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(980, 91);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitlebar_Paint);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(912, 13);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(65, 48);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(670, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picboxperson
            // 
            this.picboxperson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.picboxperson.ForeColor = System.Drawing.Color.PowderBlue;
            this.picboxperson.IconChar = FontAwesome.Sharp.IconChar.User;
            this.picboxperson.IconColor = System.Drawing.Color.PowderBlue;
            this.picboxperson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picboxperson.IconSize = 49;
            this.picboxperson.Location = new System.Drawing.Point(611, 22);
            this.picboxperson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxperson.Name = "picboxperson";
            this.picboxperson.Size = new System.Drawing.Size(53, 49);
            this.picboxperson.TabIndex = 2;
            this.picboxperson.TabStop = false;
            // 
            // formtitle
            // 
            this.formtitle.AutoSize = true;
            this.formtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formtitle.Location = new System.Drawing.Point(90, 35);
            this.formtitle.Name = "formtitle";
            this.formtitle.Size = new System.Drawing.Size(64, 25);
            this.formtitle.TabIndex = 1;
            this.formtitle.Text = "Home";
            this.formtitle.Click += new System.EventHandler(this.formtitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(223, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 921);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 1012);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelmenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI";
            this.Load += new System.EventHandler(this.UI_Load);
            this.panel1.ResumeLayout(false);
            this.panelmenue.ResumeLayout(false);
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxperson)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelmenue;
        private FontAwesome.Sharp.IconButton btn_logout;
        private FontAwesome.Sharp.IconButton btn_list_users;
        private FontAwesome.Sharp.IconButton btn_ask_qs;
        private FontAwesome.Sharp.IconButton btn_delet_qs;
        private FontAwesome.Sharp.IconButton btn_ans_qs;
        private FontAwesome.Sharp.IconButton btn_qs_from_me;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Label formtitle;
        private FontAwesome.Sharp.IconButton btn_qs_to_me;
        private FontAwesome.Sharp.IconPictureBox picboxperson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton home;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
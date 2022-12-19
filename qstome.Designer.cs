namespace project
{
    partial class qstome
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
            this.Questions = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // Questions
            // 
            this.Questions.BorderRadius = 25;
            this.Questions.BorderThickness = 0;
            this.Questions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Questions.DefaultText = "";
            this.Questions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Questions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Questions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Questions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Questions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Questions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Questions.Font = new System.Drawing.Font("Tahoma", 18F);
            this.Questions.ForeColor = System.Drawing.Color.White;
            this.Questions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Questions.Location = new System.Drawing.Point(0, 0);
            this.Questions.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.Questions.Multiline = true;
            this.Questions.Name = "Questions";
            this.Questions.PasswordChar = '\0';
            this.Questions.PlaceholderText = "";
            this.Questions.ReadOnly = true;
            this.Questions.SelectedText = "";
            this.Questions.Size = new System.Drawing.Size(980, 921);
            this.Questions.TabIndex = 0;
            this.Questions.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // qstome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(980, 921);
            this.Controls.Add(this.Questions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "qstome";
            this.Text = "qstome";
            this.Load += new System.EventHandler(this.qstome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Questions;
    }
}
namespace project
{
    partial class qstfromme
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
            this.fromme = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // fromme
            // 
            this.fromme.AutoScroll = true;
            this.fromme.BorderThickness = 0;
            this.fromme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fromme.DefaultText = "";
            this.fromme.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fromme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fromme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fromme.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fromme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.fromme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fromme.Font = new System.Drawing.Font("Tahoma", 18F);
            this.fromme.ForeColor = System.Drawing.Color.White;
            this.fromme.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fromme.Location = new System.Drawing.Point(0, 0);
            this.fromme.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.fromme.Multiline = true;
            this.fromme.Name = "fromme";
            this.fromme.PasswordChar = '\0';
            this.fromme.PlaceholderText = "";
            this.fromme.ReadOnly = true;
            this.fromme.SelectedText = "";
            this.fromme.Size = new System.Drawing.Size(980, 921);
            this.fromme.TabIndex = 1;
            this.fromme.TextChanged += new System.EventHandler(this.fromme_TextChanged);
            // 
            // qstfromme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(980, 921);
            this.Controls.Add(this.fromme);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "qstfromme";
            this.Text = "qstfromme";
            this.Load += new System.EventHandler(this.qstfromme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox fromme;
    }
}
namespace project
{
    partial class listusers
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
            this.listuserstxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // listuserstxt
            // 
            this.listuserstxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.listuserstxt.BorderRadius = 25;
            this.listuserstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listuserstxt.DefaultText = "";
            this.listuserstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.listuserstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.listuserstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listuserstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listuserstxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listuserstxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.listuserstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listuserstxt.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.listuserstxt.ForeColor = System.Drawing.Color.White;
            this.listuserstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listuserstxt.Location = new System.Drawing.Point(0, 0);
            this.listuserstxt.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.listuserstxt.Multiline = true;
            this.listuserstxt.Name = "listuserstxt";
            this.listuserstxt.PasswordChar = '\0';
            this.listuserstxt.PlaceholderText = "";
            this.listuserstxt.ReadOnly = true;
            this.listuserstxt.SelectedText = "";
            this.listuserstxt.Size = new System.Drawing.Size(980, 921);
            this.listuserstxt.TabIndex = 2;
            this.listuserstxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // listusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(980, 921);
            this.Controls.Add(this.listuserstxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listusers";
            this.Text = "listusers";
            this.Load += new System.EventHandler(this.listusers_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox listuserstxt;
    }
}
namespace LibraryOfMakers
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.LoginUsr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GuestLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.DarkOrange;
            this.Username.Location = new System.Drawing.Point(41, 128);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(65, 15);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkOrange;
            this.Password.Location = new System.Drawing.Point(41, 179);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // UsernameText
            // 
            this.UsernameText.BackColor = System.Drawing.Color.Tomato;
            this.UsernameText.Location = new System.Drawing.Point(155, 125);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(148, 20);
            this.UsernameText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.Tomato;
            this.PasswordText.Location = new System.Drawing.Point(155, 172);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(148, 20);
            this.PasswordText.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Chocolate;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(228, 228);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Chocolate;
            this.buttonLogin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Location = new System.Drawing.Point(150, 228);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginUsr
            // 
            this.LoginUsr.AutoSize = true;
            this.LoginUsr.BackColor = System.Drawing.Color.Transparent;
            this.LoginUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsr.ForeColor = System.Drawing.Color.DarkOrange;
            this.LoginUsr.Location = new System.Drawing.Point(145, 73);
            this.LoginUsr.Name = "LoginUsr";
            this.LoginUsr.Size = new System.Drawing.Size(73, 25);
            this.LoginUsr.TabIndex = 6;
            this.LoginUsr.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Library of Makers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(103, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Not a member? insert your data and  click here . . .";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GuestLogin
            // 
            this.GuestLogin.BackColor = System.Drawing.Color.Tan;
            this.GuestLogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.GuestLogin.Location = new System.Drawing.Point(3, 267);
            this.GuestLogin.Name = "GuestLogin";
            this.GuestLogin.Size = new System.Drawing.Size(94, 23);
            this.GuestLogin.TabIndex = 16;
            this.GuestLogin.Text = "GUEST LOGIN";
            this.GuestLogin.UseVisualStyleBackColor = false;
            this.GuestLogin.Click += new System.EventHandler(this.GuestLogin_Click);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 294);
            this.Controls.Add(this.GuestLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginUsr);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LoginUser";
            this.Text = "LoginUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label LoginUsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GuestLogin;
    }
}
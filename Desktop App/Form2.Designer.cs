namespace Desktop_App
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Username = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.Label();
            this.login_name = new System.Windows.Forms.TextBox();
            this.login_password1 = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 33);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(325, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 72);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log in to your \r\n    Account\r\n  \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_Username
            // 
            this.login_Username.AutoSize = true;
            this.login_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Username.Location = new System.Drawing.Point(46, 221);
            this.login_Username.Name = "login_Username";
            this.login_Username.Size = new System.Drawing.Size(73, 16);
            this.login_Username.TabIndex = 3;
            this.login_Username.Text = "Username:";
            this.login_Username.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_password
            // 
            this.login_password.AutoSize = true;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(49, 298);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(70, 16);
            this.login_password.TabIndex = 4;
            this.login_password.Text = "Password:\r\n";
            this.login_password.Click += new System.EventHandler(this.login_password_Click);
            // 
            // login_name
            // 
            this.login_name.Location = new System.Drawing.Point(46, 254);
            this.login_name.Multiline = true;
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(230, 30);
            this.login_name.TabIndex = 5;
            this.login_name.TextChanged += new System.EventHandler(this.login_name_TextChanged);
            // 
            // login_password1
            // 
            this.login_password1.Location = new System.Drawing.Point(46, 327);
            this.login_password1.Multiline = true;
            this.login_password1.Name = "login_password1";
            this.login_password1.Size = new System.Drawing.Size(230, 30);
            this.login_password1.TabIndex = 6;
            this.login_password1.TextChanged += new System.EventHandler(this.login_password1_TextChanged);
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_Btn.Location = new System.Drawing.Point(116, 387);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(100, 40);
            this.Login_Btn.TabIndex = 7;
            this.Login_Btn.Text = "LOGIN";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.DodgerBlue;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup.Location = new System.Drawing.Point(116, 522);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(100, 41);
            this.signup.TabIndex = 8;
            this.signup.Text = "Sign UP";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Not yet a member?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter your library registration number and password for \r\nlogin in your account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Desktop_App.Properties.Resources.img3;
            this.pictureBox1.Location = new System.Drawing.Point(116, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(350, 575);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.login_password1);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login_Username;
        private System.Windows.Forms.Label login_password;
        private System.Windows.Forms.TextBox login_name;
        private System.Windows.Forms.TextBox login_password1;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
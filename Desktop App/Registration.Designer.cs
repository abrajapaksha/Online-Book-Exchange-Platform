namespace Desktop_App
{
    partial class Registration
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
            this.Register_Pconfirm = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Join_btn = new System.Windows.Forms.Button();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.Register_Username = new System.Windows.Forms.TextBox();
            this.Join_password = new System.Windows.Forms.Label();
            this.Join_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register_email = new System.Windows.Forms.TextBox();
            this.Join_email = new System.Windows.Forms.Label();
            this.Sign_In = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 33);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register_Pconfirm
            // 
            this.Register_Pconfirm.AutoSize = true;
            this.Register_Pconfirm.Location = new System.Drawing.Point(196, 387);
            this.Register_Pconfirm.Name = "Register_Pconfirm";
            this.Register_Pconfirm.Size = new System.Drawing.Size(101, 17);
            this.Register_Pconfirm.TabIndex = 23;
            this.Register_Pconfirm.Text = "Show password";
            this.Register_Pconfirm.UseVisualStyleBackColor = true;
            this.Register_Pconfirm.CheckedChanged += new System.EventHandler(this.Register_Pconfirm_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "If you already have a account enter your library registration \r\nnumber and passwo" +
    "rd for login in your account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Join_btn
            // 
            this.Join_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Join_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Join_btn.Location = new System.Drawing.Point(108, 410);
            this.Join_btn.Name = "Join_btn";
            this.Join_btn.Size = new System.Drawing.Size(100, 41);
            this.Join_btn.TabIndex = 20;
            this.Join_btn.Text = "Join";
            this.Join_btn.UseVisualStyleBackColor = false;
            this.Join_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register_Password
            // 
            this.Register_Password.Location = new System.Drawing.Point(38, 351);
            this.Register_Password.Multiline = true;
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.Size = new System.Drawing.Size(230, 30);
            this.Register_Password.TabIndex = 18;
            // 
            // Register_Username
            // 
            this.Register_Username.Location = new System.Drawing.Point(38, 288);
            this.Register_Username.Multiline = true;
            this.Register_Username.Name = "Register_Username";
            this.Register_Username.Size = new System.Drawing.Size(230, 30);
            this.Register_Username.TabIndex = 17;
            // 
            // Join_password
            // 
            this.Join_password.AutoSize = true;
            this.Join_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_password.Location = new System.Drawing.Point(41, 332);
            this.Join_password.Name = "Join_password";
            this.Join_password.Size = new System.Drawing.Size(70, 16);
            this.Join_password.TabIndex = 16;
            this.Join_password.Text = "Password:\r\n";
            // 
            // Join_username
            // 
            this.Join_username.AutoSize = true;
            this.Join_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_username.Location = new System.Drawing.Point(41, 258);
            this.Join_username.Name = "Join_username";
            this.Join_username.Size = new System.Drawing.Size(73, 16);
            this.Join_username.TabIndex = 15;
            this.Join_username.Text = "Username:";
            this.Join_username.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Join the library";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Register_email
            // 
            this.Register_email.Location = new System.Drawing.Point(38, 213);
            this.Register_email.Multiline = true;
            this.Register_email.Name = "Register_email";
            this.Register_email.Size = new System.Drawing.Size(230, 30);
            this.Register_email.TabIndex = 25;
            this.Register_email.TextChanged += new System.EventHandler(this.Register_email_TextChanged);
            // 
            // Join_email
            // 
            this.Join_email.AutoSize = true;
            this.Join_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_email.Location = new System.Drawing.Point(41, 184);
            this.Join_email.Name = "Join_email";
            this.Join_email.Size = new System.Drawing.Size(90, 16);
            this.Join_email.TabIndex = 24;
            this.Join_email.Text = "Email Adress:";
            // 
            // Sign_In
            // 
            this.Sign_In.BackColor = System.Drawing.Color.ForestGreen;
            this.Sign_In.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sign_In.Location = new System.Drawing.Point(108, 483);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(100, 43);
            this.Sign_In.TabIndex = 26;
            this.Sign_In.Text = "Sign In";
            this.Sign_In.UseVisualStyleBackColor = false;
            this.Sign_In.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Desktop_App.Properties.Resources.img3;
            this.pictureBox1.Location = new System.Drawing.Point(108, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 536);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.Register_email);
            this.Controls.Add(this.Join_email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Register_Pconfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Join_btn);
            this.Controls.Add(this.Register_Password);
            this.Controls.Add(this.Register_Username);
            this.Controls.Add(this.Join_password);
            this.Controls.Add(this.Join_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Register_Pconfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Join_btn;
        private System.Windows.Forms.TextBox Register_Password;
        private System.Windows.Forms.TextBox Register_Username;
        private System.Windows.Forms.Label Join_password;
        private System.Windows.Forms.Label Join_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Register_email;
        private System.Windows.Forms.Label Join_email;
        private System.Windows.Forms.Button Sign_In;
    }
}
namespace Desktop_App
{
    partial class RequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Username = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.last_Name = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ownerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 33);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 72);
            this.label2.TabIndex = 14;
            this.label2.Text = "Request  for \r\n     Book\r\n  \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_Username
            // 
            this.login_Username.AutoSize = true;
            this.login_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Username.Location = new System.Drawing.Point(45, 143);
            this.login_Username.Name = "login_Username";
            this.login_Username.Size = new System.Drawing.Size(75, 16);
            this.login_Username.TabIndex = 15;
            this.login_Username.Text = "First Name:";
            // 
            // login_password
            // 
            this.login_password.AutoSize = true;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(45, 287);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(53, 16);
            this.login_password.TabIndex = 16;
            this.login_password.Text = "Adress:\r\n";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(42, 171);
            this.first_name.Multiline = true;
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(230, 30);
            this.first_name.TabIndex = 17;
            this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(42, 316);
            this.Adres.Multiline = true;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(230, 30);
            this.Adres.TabIndex = 18;
            this.Adres.TextChanged += new System.EventHandler(this.Adres_TextChanged);
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.Red;
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_Btn.Location = new System.Drawing.Point(97, 498);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(100, 40);
            this.Login_Btn.TabIndex = 19;
            this.Login_Btn.Text = "REQUEST";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name:";
            // 
            // last_Name
            // 
            this.last_Name.Location = new System.Drawing.Point(42, 254);
            this.last_Name.Multiline = true;
            this.last_Name.Name = "last_Name";
            this.last_Name.Size = new System.Drawing.Size(230, 30);
            this.last_Name.TabIndex = 25;
            this.last_Name.TextChanged += new System.EventHandler(this.last_Name_TextChanged);
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(42, 387);
            this.mobile.Multiline = true;
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(230, 30);
            this.mobile.TabIndex = 27;
            this.mobile.TextChanged += new System.EventHandler(this.mobile_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mobile Number:\r\n";
            // 
            // ownerID
            // 
            this.ownerID.Location = new System.Drawing.Point(42, 452);
            this.ownerID.Multiline = true;
            this.ownerID.Name = "ownerID";
            this.ownerID.Size = new System.Drawing.Size(230, 30);
            this.ownerID.TabIndex = 29;
            this.ownerID.TextChanged += new System.EventHandler(this.ownerID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Owner ID:\r\n";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 540);
            this.Controls.Add(this.ownerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.last_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_Username);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login_Username;
        private System.Windows.Forms.Label login_password;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox last_Name;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ownerID;
        private System.Windows.Forms.Label label5;
    }
}
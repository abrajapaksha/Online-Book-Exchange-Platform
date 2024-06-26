namespace Desktop_App
{
    partial class addbooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CLEAR = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.published = new System.Windows.Forms.DateTimePicker();
            this.Author = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ADD_Picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADD_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(343, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 459);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADD BOOK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 361);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.CLEAR);
            this.panel2.Controls.Add(this.DELETE);
            this.panel2.Controls.Add(this.UPDATE);
            this.panel2.Controls.Add(this.ADD);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.published);
            this.panel2.Controls.Add(this.Author);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ADD_Picture);
            this.panel2.Location = new System.Drawing.Point(18, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 459);
            this.panel2.TabIndex = 1;
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.Gold;
            this.CLEAR.Location = new System.Drawing.Point(162, 369);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(100, 58);
            this.CLEAR.TabIndex = 13;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Gold;
            this.DELETE.Location = new System.Drawing.Point(56, 369);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(100, 58);
            this.DELETE.TabIndex = 12;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Gold;
            this.UPDATE.Location = new System.Drawing.Point(162, 295);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(100, 58);
            this.UPDATE.TabIndex = 11;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Gold;
            this.ADD.Location = new System.Drawing.Point(55, 295);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(100, 58);
            this.ADD.TabIndex = 10;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.status.Location = new System.Drawing.Point(140, 226);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(168, 21);
            this.status.TabIndex = 9;
            // 
            // published
            // 
            this.published.Location = new System.Drawing.Point(140, 178);
            this.published.Name = "published";
            this.published.Size = new System.Drawing.Size(168, 20);
            this.published.TabIndex = 8;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(140, 98);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(168, 30);
            this.Author.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(140, 37);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(168, 32);
            this.Title.TabIndex = 6;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Published :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author :\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Title :\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADD_Picture
            // 
            this.ADD_Picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ADD_Picture.Location = new System.Drawing.Point(22, 21);
            this.ADD_Picture.Name = "ADD_Picture";
            this.ADD_Picture.Size = new System.Drawing.Size(100, 107);
            this.ADD_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ADD_Picture.TabIndex = 0;
            this.ADD_Picture.TabStop = false;
            this.ADD_Picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addbooks";
            this.Size = new System.Drawing.Size(881, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADD_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ADD_Picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker published;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.ComboBox status;
    }
}

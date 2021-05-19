namespace RestapiCSharp
{
    partial class Books
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
            this.button_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DISLIKE = new System.Windows.Forms.Button();
            this.button_LIKE = new System.Windows.Forms.Button();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.button_UPDATE = new System.Windows.Forms.Button();
            this.button_POST = new System.Windows.Forms.Button();
            this.button_GET_ID = new System.Windows.Forms.Button();
            this.button_GET = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_DISLIKE);
            this.panel1.Controls.Add(this.button_LIKE);
            this.panel1.Controls.Add(this.textBox_Text);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.button_DELETE);
            this.panel1.Controls.Add(this.button_UPDATE);
            this.panel1.Controls.Add(this.button_POST);
            this.panel1.Controls.Add(this.button_GET_ID);
            this.panel1.Controls.Add(this.button_GET);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 307);
            this.panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(478, 276);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(101, 23);
            this.button_logout.TabIndex = 12;
            this.button_logout.Text = "Kijelentkezés";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Könyv neve";
            // 
            // button_DISLIKE
            // 
            this.button_DISLIKE.Location = new System.Drawing.Point(83, 217);
            this.button_DISLIKE.Name = "button_DISLIKE";
            this.button_DISLIKE.Size = new System.Drawing.Size(75, 23);
            this.button_DISLIKE.TabIndex = 9;
            this.button_DISLIKE.Text = "Dislike";
            this.button_DISLIKE.UseVisualStyleBackColor = true;
            this.button_DISLIKE.Click += new System.EventHandler(this.Button_DISLIKE_Click);
            // 
            // button_LIKE
            // 
            this.button_LIKE.Location = new System.Drawing.Point(3, 217);
            this.button_LIKE.Name = "button_LIKE";
            this.button_LIKE.Size = new System.Drawing.Size(74, 23);
            this.button_LIKE.TabIndex = 8;
            this.button_LIKE.Text = "Like";
            this.button_LIKE.UseVisualStyleBackColor = true;
            this.button_LIKE.Click += new System.EventHandler(this.Button_LIKE_Click);
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(164, 275);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(273, 20);
            this.textBox_Text.TabIndex = 7;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(12, 191);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(129, 20);
            this.textBox_ID.TabIndex = 6;
            // 
            // button_DELETE
            // 
            this.button_DELETE.Location = new System.Drawing.Point(12, 140);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(129, 23);
            this.button_DELETE.TabIndex = 5;
            this.button_DELETE.Text = "TÖRLÉS";
            this.button_DELETE.UseVisualStyleBackColor = true;
            this.button_DELETE.Click += new System.EventHandler(this.Button_DELETE_Click);
            // 
            // button_UPDATE
            // 
            this.button_UPDATE.Location = new System.Drawing.Point(13, 109);
            this.button_UPDATE.Name = "button_UPDATE";
            this.button_UPDATE.Size = new System.Drawing.Size(128, 23);
            this.button_UPDATE.TabIndex = 4;
            this.button_UPDATE.Text = "MÓDOSÍT";
            this.button_UPDATE.UseVisualStyleBackColor = true;
            this.button_UPDATE.Click += new System.EventHandler(this.Button_UPDATE_Click);
            // 
            // button_POST
            // 
            this.button_POST.Location = new System.Drawing.Point(13, 78);
            this.button_POST.Name = "button_POST";
            this.button_POST.Size = new System.Drawing.Size(128, 23);
            this.button_POST.TabIndex = 3;
            this.button_POST.Text = "POSZTOLÁS";
            this.button_POST.UseVisualStyleBackColor = true;
            this.button_POST.Click += new System.EventHandler(this.Button_POST_Click);
            // 
            // button_GET_ID
            // 
            this.button_GET_ID.Location = new System.Drawing.Point(13, 46);
            this.button_GET_ID.Name = "button_GET_ID";
            this.button_GET_ID.Size = new System.Drawing.Size(128, 23);
            this.button_GET_ID.TabIndex = 2;
            this.button_GET_ID.Text = "ID SZERINTI LEK.";
            this.button_GET_ID.UseVisualStyleBackColor = true;
            this.button_GET_ID.Click += new System.EventHandler(this.Button_GET_ID_Click);
            // 
            // button_GET
            // 
            this.button_GET.Location = new System.Drawing.Point(13, 13);
            this.button_GET.Name = "button_GET";
            this.button_GET.Size = new System.Drawing.Size(128, 23);
            this.button_GET.TabIndex = 1;
            this.button_GET.Text = "LEKÉRDEZÉS";
            this.button_GET.UseVisualStyleBackColor = true;
            this.button_GET.Click += new System.EventHandler(this.Button_GET_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(164, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 251);
            this.listBox1.TabIndex = 0;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(606, 307);
            this.Controls.Add(this.panel1);
            this.Name = "Books";
            this.Text = "Books";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Text;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.Button button_UPDATE;
        private System.Windows.Forms.Button button_POST;
        private System.Windows.Forms.Button button_GET_ID;
        private System.Windows.Forms.Button button_GET;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_DISLIKE;
        private System.Windows.Forms.Button button_LIKE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_logout;
    }
}
namespace RestapiCSharp
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Logname = new System.Windows.Forms.TextBox();
            this.textBox_Passwd = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bejelentkezés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználói név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó";
            // 
            // textBox_Logname
            // 
            this.textBox_Logname.Location = new System.Drawing.Point(163, 110);
            this.textBox_Logname.Name = "textBox_Logname";
            this.textBox_Logname.Size = new System.Drawing.Size(142, 20);
            this.textBox_Logname.TabIndex = 3;
            this.textBox_Logname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Passwd
            // 
            this.textBox_Passwd.Location = new System.Drawing.Point(163, 173);
            this.textBox_Passwd.Name = "textBox_Passwd";
            this.textBox_Passwd.PasswordChar = '*';
            this.textBox_Passwd.Size = new System.Drawing.Size(142, 20);
            this.textBox_Passwd.TabIndex = 4;
            this.textBox_Passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(195, 210);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(75, 23);
            this.button_Enter.TabIndex = 5;
            this.button_Enter.Text = "Belépés";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.Button_Enter_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 258);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.textBox_Passwd);
            this.Controls.Add(this.textBox_Logname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Logname;
        private System.Windows.Forms.TextBox textBox_Passwd;
        private System.Windows.Forms.Button button_Enter;
    }
}
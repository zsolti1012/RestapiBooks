using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestapiCSharp
{
    public partial class Login : Form
    {
        static public string log;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Enter_Click(object sender, EventArgs e)
        {
            if (!(textBox_Logname.Text == "abcd" && textBox_Passwd.Text == "1234"))
            {
                MessageBox.Show("Helytelen bejelentkezési adatok!");
            }
            else {
                if (textBox_Logname.Text=="")
                {
                    MessageBox.Show("Felhasználói név  megadása kötelező!");
                }
                else
                {
                    log = textBox_Logname.Text + "|" + textBox_Passwd.Text;
                    this.Hide();
                    Books books = new Books();
                    books.ShowDialog();
                    this.Close();
             
                   
                    
                    
                    
                    
                }
            }
        }
    }
}

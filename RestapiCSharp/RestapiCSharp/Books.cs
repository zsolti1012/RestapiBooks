using System;
using RestSharp;
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
    
    public partial class Books : Form
    {
        String URL = "http://localhost:8080/PHP/";
        String ROUTE = "index.php";
        static public String LOG=Login.log;

        static Random rnd = new Random();
        
        public Books()
        {
            InitializeComponent();
           
            
        }





        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Rating { get; set; }
            public int Length { get; set; }
            public int ReleaseYear { get; set; }
           
        }

        private void Button_GET_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE + "?log=" + LOG, Method.GET);
            IRestResponse<List<Book>> response = client.Execute<List<Book>>(request);
            listBox1.Items.Add("ID" + "\t" + "Név" + "\t"+"\t" + "Év" + "\t" + "Pontszám");
            listBox1.Items.Add("----------------------------------------------------------------------------------------");
            if (response.Content == "")
            {
                MessageBox.Show("Kapcsolódási hiba!");
                return;
            }
            if (response.Content.Substring(1, response.Content.Length - 2) != "WRONG LOG INFO")
            {
                foreach (Book book in response.Data)
                   
                    listBox1.Items.Add(book.Id + "\t" + book.Name+"\t"+book.ReleaseYear+"\t"+book.Rating);
            }
            else MessageBox.Show(response.Content);
        }

        private void Button_GET_ID_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String idRoute = ROUTE + "?log=" + LOG + "&id=" + textBox_ID.Text;
            var request = new RestRequest(idRoute, Method.GET);
            IRestResponse<Book> response = client.Execute<Book>(request);
            if (response.Content == "")
            {
                MessageBox.Show("Kapcsolódási hiba!");
                return;
            }
            if (response.Content.Substring(1, response.Content.Length - 2) != "WRONG LOG INFO")
            {
                if (response.Content != "[]")
                {
                    var content = response.Content.Split(',')[2].Split(':')[1].ToString();
                    textBox_Text.Text = content.Substring(1, content.Length - 2);
                }
                else MessageBox.Show("Wrong ID");
            }
            else MessageBox.Show(response.Content);
            
        }

        private void Button_POST_Click(object sender, EventArgs e)
        {
            if (textBox_Text.Text != "")
            {
                var client = new RestClient(URL);
                var request = new RestRequest(ROUTE + "?log=" + LOG, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new Book
                {

                    Name = textBox_Text.Text,
                    Rating = 0,
                    Length = rnd.Next(15, 256),
                    ReleaseYear = rnd.Next(1945, 2019)
                });
                IRestResponse response = client.Execute(request);
                if (response.Content == "")
                {
                    MessageBox.Show("Kapcsolódási hiba!");
                    return;
                }
                if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                    MessageBox.Show(response.Content);
                Button_GET_Click(sender, e);
            }
            else MessageBox.Show("Cím megadása kötelező.");
            Button_GET_Click(sender, e);
        }

        private void Button_UPDATE_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String idRoute = ROUTE + "?log=" + LOG + "&id=" + textBox_ID.Text;
            var request = new RestRequest(idRoute, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Book
            {
                Name = textBox_Text.Text,
                Rating = rnd.Next(6),
                Length = rnd.Next(15, 256),
                ReleaseYear = rnd.Next(1945, 2018)
            });
            IRestResponse response = client.Execute(request);
            if (response.Content == "")
            {
                MessageBox.Show("Kapcsolódási hiba!");
                return;
            }
            if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                MessageBox.Show(response.Content);
            Button_GET_Click(sender, e);
        }

        private void Button_DELETE_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String idRoute = ROUTE + "?log=" + LOG + "&id=" + textBox_ID.Text;
            var request = new RestRequest(idRoute, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(LOG);
            IRestResponse response = client.Execute(request);
            if (response.Content == "")
            {
                MessageBox.Show("Kapcsolódási hiba!");
                return;
            }
            if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                MessageBox.Show(response.Content);
            Button_GET_Click(sender, e);
        }
        string tempName;
        int temprating, templength, tempreleaseYear,tmpid;

        private void Button_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            this.Close();
            login.ShowDialog();
            
        }

        private void Button_DISLIKE_Click(object sender, EventArgs e)
        {
            likeordislike();
            if (temprating>0)
            {
                var client = new RestClient(URL);
                String idRoute = ROUTE + "?log=" + LOG + "&id=" + textBox_ID.Text;
                var request = new RestRequest(idRoute, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new Book
                {
                    Name = tempName,
                    Rating = temprating - 1,
                    Length = templength,
                    ReleaseYear = tempreleaseYear
                }); ;
                IRestResponse response = client.Execute(request);
                if (response.Content == "")
                {
                    MessageBox.Show("Kapcsolódási hiba!");
                    return;
                }
                if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                    MessageBox.Show(response.Content);
                Button_GET_Click(sender, e);
            }

            
        }

        

        private void Button_LIKE_Click(object sender, EventArgs e)
        {

            likeordislike();
            var client = new RestClient(URL);
            String idRoute = ROUTE + "?log=" + LOG + "&id=" + textBox_ID.Text;
            var request = new RestRequest(idRoute, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Book
            {
                Name = tempName,
                Rating = temprating + 1,
                Length = templength,
                ReleaseYear = tempreleaseYear
            }) ;;
            IRestResponse response = client.Execute(request);
            if (response.Content == "")
            {
                MessageBox.Show("Kapcsolódási hiba!");
                return;
            }
            if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                MessageBox.Show(response.Content);

            Button_GET_Click(sender, e);
        }


        public void likeordislike()
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE + "?log=" + LOG, Method.GET);
            IRestResponse<List<Book>> response = client.Execute<List<Book>>(request);
            if (response.Content == "")
            {
                MessageBox.Show("Kapcsolódási hiba!");
                return;
            }
            if (response.Content.Substring(1, response.Content.Length - 2) != "WRONG LOG INFO")
            {
                int number;
                foreach (Book book in response.Data)
                    
                    if (int.TryParse(textBox_ID.Text, out number)&&int.Parse(textBox_ID.Text) == book.Id)
                    {
                        tmpid = int.Parse(textBox_ID.Text);
                        tempName = book.Name;
                        temprating = book.Rating;
                        tempreleaseYear = book.ReleaseYear;
                        templength = book.Length;
                    }

            }
            else MessageBox.Show(response.Content);

            
        }
        
    }
}

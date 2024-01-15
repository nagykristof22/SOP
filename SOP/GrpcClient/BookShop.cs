using Grpc.Core;
using Grpc.Net.Client;

namespace GrpcClient
{
    public partial class BookShop : Form
    {
        static readonly string address = "https://localhost:5001";
        GrpcChannel channel = GrpcChannel.ForAddress(address);
        public KonyvSziget.KonyvSzigetClient Client;
        private bool isLoggedIn = false;
        private int userId;

        public BookShop()
        {
            InitializeComponent();
            Client = new KonyvSziget.KonyvSzigetClient(channel);
            InitializeDataGridViewColumns();
        }

        private void kolcsonBTN_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                new ADD(this).Show();
            }
            else
            {
                MessageBox.Show("K�rlek jelentkezz be el�sz�r!");
            }

        }

        private void InitializeDataGridViewColumns()
        {
            bookDGV.Columns.Clear();
            bookDGV.RowHeadersVisible = false;
            bookDGV.Columns.Add("id", "ID");
            bookDGV.Columns.Add("name", "C�m");
            bookDGV.Columns.Add("writer", "Szerz�");
            bookDGV.Columns.Add("category", "Kateg�ria");
            bookDGV.Columns.Add("description", "Le�r�s");
        }

        private async void listBTN_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                try
                {
                    Empty empty = new Empty();
                    var responseStream = Client.List(empty);

                    await foreach (var book in responseStream.ResponseStream.ReadAllAsync())
                    {

                        bookDGV.Rows.Add(book.Id, book.Name, book.Writer, book.Category, book.Description);
                    }
                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
                {
                    MessageBox.Show("Szerverhez val� csatlakoz�s sikertelen!");
                }
                catch (RpcException ex)
                {
                    MessageBox.Show($"Szerveroldali hiba: {ex.Status.Detail}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba t�rt�nt: {ex}");
                }
            }
            else
            {
                MessageBox.Show("K�rlek jelentkezz be el�sz�r!");
            }

        }

        private void beleptoolStripLabel1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            loginForm.ShowDialog();

            if (loginForm.IsLoggedIn)
            {
                isLoggedIn = true;
                userId = loginForm.UserId;
                beleptoolStripLabel1.Visible = false;
                kolcsonBTN.Visible = true;
                listBTN.Visible = true;
            }
            else
            {
                isLoggedIn = false;
            }
        }

       


    }
}
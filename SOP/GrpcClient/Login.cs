using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpcClient
{
    public partial class Login : Form
    {
        BookShop szia;
        KonyvSziget.KonyvSzigetClient Client;
        public bool IsLoggedIn { get; private set; }
        public int UserId { get; private set; }

        public Login(BookShop helo)
        {
            InitializeComponent();
            this.szia = helo;
            this.Client = szia.Client;
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            try
            {
               
                LoginRequest loginRequest = new LoginRequest
                {
                    Username = usernameBox.Text,
                    Password = passwordBOX.Text
                };

                
                LoginResponse loginResponse = Client.Login(loginRequest);

                
                if (loginResponse.Success)
                {
                    MessageBox.Show($"Sikeres bejelentkezés! Üzenet: {loginResponse.Message}");

                    IsLoggedIn = true;
                    this.Close();

                }
                else
                {
                    
                    MessageBox.Show($"Sikertelen bejelentkezés! Üzenet: {loginResponse.Message}");
                }
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
            {
                MessageBox.Show("Szerver nem elérhető!");
            }
            catch (Exception)
            {
                MessageBox.Show("Váratlan hiba!");
            }

            IsLoggedIn = true;
            

        }

        private void regLB_Click(object sender, EventArgs e)
        {
            new Register(szia).Show();
            this.Close();
        }


    }
}

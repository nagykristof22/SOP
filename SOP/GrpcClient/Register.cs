using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpcClient
{
    public partial class Register : Form
    {
        BookShop szia;
        KonyvSziget.KonyvSzigetClient Client;
        public Register(BookShop helo)
        {
            InitializeComponent();
            this.szia = helo;
            this.Client = szia.Client;
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
           try{
                RegisterRequest registerRequest = new RegisterRequest
                {
                    Username = usernameBOX.Text,
                    Email = emailBOX.Text,
                    Password = passwordBOX.Text
                };

                RegisterResponse registerResponse = Client.Register(registerRequest);

                if (registerResponse.Success)
                {
                    MessageBox.Show(registerResponse.Message);
                    new Login(szia).Show();
                    this.Close();
            }
            else
            {
                MessageBox.Show(registerResponse.Message);
            }
        }
        catch (RpcException ex) when(ex.StatusCode == StatusCode.Unavailable)
            {
                MessageBox.Show("Szerver nem elérhető!");
            }
        catch (Exception)
        {
            MessageBox.Show("Váratlan hiba!");
        }
}

        private void lgLB_Click(object sender, EventArgs e)
        {
            new Login(szia).Show();
            this.Close();
        }
    }
}

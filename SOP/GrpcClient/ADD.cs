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
    public partial class ADD : Form
    {
        BookShop szia;
        KonyvSziget.KonyvSzigetClient Client;
        public ADD(BookShop helo)
        {
            InitializeComponent();
            this.szia = helo;
            this.Client = szia.Client;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            

            try
            {
                AddRequest book = new AddRequest
                {
                    Name = nameBOX.Text,
                    Writer = writerBOX.Text,
                    Category = catBox.Text,
                    Description = descriptionBOX.Text

                };
               
                AddResponse response = Client.AddBook(book);

                if (response.Success)
                {
                    MessageBox.Show(response.Message);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.Message);
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
        }
    }
}

using Grpc.Core;
using GrpcServer;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;
using System.Data.Common;

namespace GrpcServer.Services
{
    public class BookService : KonyvSziget.KonyvSzigetBase
    {
        private static readonly string connection =
        "server=localhost;" +
        "user=root;" +
        "password=;" +
        "database=bookland";
        MySqlConnection connect = new MySqlConnection(connection);
        static List<Books> BookList = new List<Books>();

        public override async Task<LoginResponse> Login(LoginRequest request, ServerCallContext context)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
                {
                    return new LoginResponse
                    {
                        Success = false,
                        Message = "Hi�nyz� felhaszn�l�n�v vagy jelsz�."
                    };
                }

                using MySqlConnection connect = new MySqlConnection(connection);
                await connect.OpenAsync();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@username", request.Username);
                cmd.Parameters.AddWithValue("@password", request.Password);

                int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                if (count > 0)
                {
                    return new LoginResponse
                    {
                        Success = true,
                        Message = "Sikeres bejelentkez�s."
                    };
                }
                else
                {
                    return new LoginResponse
                    {
                        Success = false,
                        Message = "Hib�s felhaszn�l�n�v vagy jelsz�."
                    };
                }
            }
            catch (Exception ex)
            {
                return new LoginResponse
                {
                    Success = false,
                    Message = "Hiba t�rt�nt a bejelentkez�s sor�n."
                };
            }
        }

        public override async Task<RegisterResponse> Register(RegisterRequest request, ServerCallContext context)
        {
            try
            {
                using MySqlConnection connect = new MySqlConnection(connection);
                await connect.OpenAsync();

                string usernameCheckQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand usernameCheckCmd = new MySqlCommand(usernameCheckQuery, connect);
                usernameCheckCmd.Parameters.AddWithValue("@username", request.Username);

                int usernameCount = Convert.ToInt32(await usernameCheckCmd.ExecuteScalarAsync());

                if (usernameCount > 0)
                {
                    return new RegisterResponse
                    {
                        Success = false,
                        Message = "A felhaszn�l�n�v m�r foglalt."
                    };
                }

                string insertQuery = "INSERT INTO users (username, email, password) " +
                                     "VALUES (@username, @email, @password)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connect);
                insertCmd.Parameters.AddWithValue("@username", request.Username);
                insertCmd.Parameters.AddWithValue("@email", request.Email);
                insertCmd.Parameters.AddWithValue("@password", request.Password);

                int rowsAffected = await insertCmd.ExecuteNonQueryAsync();

                return new RegisterResponse
                {
                    Success = rowsAffected > 0,
                    Message = rowsAffected > 0 ? "Sikeres regisztr�ci�" : "Sikertelen regisztr�ci�"
                };
            }
            catch (Exception ex)
            {
                return new RegisterResponse
                {
                    Success = false,
                    Message = "Hiba t�rt�nt a regisztr�ci� sor�n."
                };
            }
        }

        public override async Task<AddResponse> AddBook(AddRequest request, ServerCallContext context)
        {
            string addQuery = "INSERT INTO `books`(`name`, `writer`, `category`, `description`) VALUES (@name, @writer, @category, @description)";

            if (string.IsNullOrEmpty(request.Name) ||
                string.IsNullOrEmpty(request.Writer) ||
                string.IsNullOrEmpty(request.Category)
               )
            {
                return new AddResponse { Success = false, Message = "K�rem t�lts�n ki minden mez�t!" };
            }

            try
            {
                connect.Open();


                // K�nyv hozz�ad�sa az adatb�zishoz
                using (var cmd = new MySqlCommand(addQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@name", request.Name);
                    cmd.Parameters.AddWithValue("@writer", request.Writer);
                    cmd.Parameters.AddWithValue("@category", request.Category);
                    cmd.Parameters.AddWithValue("@description", request.Description);
                    cmd.ExecuteNonQuery();
                }

                return new AddResponse { Success = true, Message = "Sikeres k�nyv hozz�ad�s!" };
            }
            catch (Exception)
            {
                return new AddResponse { Success = false, Message = "Adatb�zis hiba vagy nem el�rhet�!" };
            }
            finally
            {
                connect.Close();
            }
        }

        public override async Task List(Empty empty, IServerStreamWriter<Books> streamResponse, ServerCallContext context)
        {
            try
            {
                using MySqlConnection connect = new MySqlConnection(connection);
                await connect.OpenAsync();

                string query = "SELECT * FROM books";
                using (var cmd = new MySqlCommand(query, connect))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var books = new Books
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name"),
                                Writer = reader.GetString("writer"),
                                Category = reader.GetString("category"),
                                Description = reader.GetString("description"),
                            };
                            await streamResponse.WriteAsync(books);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba a List met�dusban: {ex}");
                throw;
            }
        }











    }

}
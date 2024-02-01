using System.Data.SqlClient;
namespace AnimeMediaProyect
{
    public class DatabaseConnection
    {
        static string connectionString = @"Server=tcp:mapservices.database.windows.net,1433;Initial Catalog=mapDataBase;Persist Security Info=False;User ID=admin123;Password=Admin321;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        static SqlConnection connection = new SqlConnection(connectionString);
        public static void OpenConnet()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }

        }

        public static List<User> SentQuery(string query)
        {
            OpenConnet();
            var user = ExcuteQuery(query, connection);
            closeConnection(connection);
            return user;
        }

        public static void closeConnection(SqlConnection connection)
        {
            connection.Close();
            System.Console.WriteLine("Conexión finalizada.");
        }

        public static List<User> ExcuteQuery(string query, SqlConnection connection)
        {
            var user = new List<User>();
            try
            {
                var command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Add(new User
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Usuario = reader["usuario"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar " + ex.Message);
            }
            return user;
        }
    }


}


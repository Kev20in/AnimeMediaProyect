using System.Data;
using System.Data.SqlClient;

namespace AnimeMediaProyect
{
    public class LoginServices{
        DatabaseConnection connection = new DatabaseConnection();

        public async Task<LoginResponse> Authentication( LoginRequest user)
        {
            var loginResponse = new LoginResponse();
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("loginUser", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
                
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usuario", user.Usuario);
            command.Parameters.AddWithValue("@contrasena", user.Contrasena);

            var reader = await command.ExecuteReaderAsync();
            while( await reader.ReadAsync()){
            loginResponse = new LoginResponse{
                ResponseMessage = (string)reader["mensaje"],
                ResponseStatus = (int)reader["status"],
                User = user,
                Token = "Token123"
            };
            };
            };
            return loginResponse;
        }
 
    }

}
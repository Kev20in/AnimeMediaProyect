using System.Data;
using System.Data.SqlClient;

namespace AnimeMediaProyect
{
    public class UserServices{
        DatabaseConnection connection = new DatabaseConnection();
        public async Task<List<User>> GetUsers()
        {
            var userList = new List<User>();
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("listarUsuarios", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
                
            command.CommandType = CommandType.StoredProcedure;
            var reader = await command.ExecuteReaderAsync();
            while( await reader.ReadAsync()){
                var users = new User{
                        Id = (int)reader["id"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        Usuario = (string)reader["usuario"],
                        Estatus = (bool)reader["estatus"]
                    };
                userList.Add(users);

            };

            };
            return userList;
        }
        public async Task<User> GetUserByName(string name)
        {
            var users = new User();
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("buscarUsuarioPorNombre", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
                
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", name);
            var reader = await command.ExecuteReaderAsync();
            while( await reader.ReadAsync()){
                 users = new User{
                        Id = (int)reader["id"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        Usuario = (string)reader["usuario"],
                        Estatus = (bool)reader["estatus"]
                    };

            };

            };
            return users;
        }      
        public async Task<User> GetUserById(int id)
        {
            var users = new User();
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("buscarUsuarioPorId", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
                
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            var reader = await command.ExecuteReaderAsync();
            while( await reader.ReadAsync()){
                 users = new User{
                        Id = (int)reader["id"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        Usuario = (string)reader["usuario"],
                        Estatus = (bool)reader["estatus"]
                    };

            };

            };
            return users;
        }      
        public async Task<User> AddUser(Register newUser)
        {
            var users = new User();
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("nuevoUsuario", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
                
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", newUser.Nombre);
            command.Parameters.AddWithValue("@apellido", newUser.Apellido);
            command.Parameters.AddWithValue("@usuario", newUser.Usuario);
            command.Parameters.AddWithValue("@contrasena", newUser.Contrasena);
            command.Parameters.AddWithValue("@estatus", newUser.Estatus);
            var reader = await command.ExecuteReaderAsync();
            while( await reader.ReadAsync()){
                users = new User{
                        Id = (int)reader["id"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        Usuario = (string)reader["usuario"],
                        Estatus = (bool)reader["estatus"]
                    };
            };

            };
            return users;
        }
        public async Task<User> UpdateUser(User updateUser)
        {
            var users = new User();
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("editarUsuario", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
                
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", updateUser.Id);
            command.Parameters.AddWithValue("@nombre", updateUser.Nombre);
            command.Parameters.AddWithValue("@apellido", updateUser.Apellido);
            command.Parameters.AddWithValue("@usuario", updateUser.Usuario);
            command.Parameters.AddWithValue("@estatus", updateUser.Estatus);
            var reader = await command.ExecuteReaderAsync();
            while( await reader.ReadAsync()){
                users = new User{
                        Id = (int)reader["id"],
                        Nombre = (string)reader["Nombre"],
                        Apellido = (string)reader["Apellido"],
                        Usuario = (string)reader["usuario"],
                        Estatus = (bool)reader["estatus"]
                    };
            };

            };
            return users;
        }
        public async Task<User> DeleteUser(User user)
        {
            var sql = new SqlConnection(connection.SqlConnection());
            using (var command = new SqlCommand("eliminarUsuario", sql)){
            try
            {
                await sql.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", user.Id);
            await command.ExecuteReaderAsync();
            };
            return user;
        }      
        }
    }

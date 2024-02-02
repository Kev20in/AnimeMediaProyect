using System.Data.SqlClient;
namespace AnimeMediaProyect
{
    public class DatabaseConnection
    {
        private string connectionString = string.Empty;
        public void GetConnetionString(){
            var builder = new ConfigurationBuilder().SetBasePath
            (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            connectionString = builder.GetSection("ConnectionStrings:DbConnection").Value;
        }

        public string SqlConnection(){
           // connectionString = @"Server=tcp:mapservices.database.windows.net,1433;Initial Catalog=mapDataBase;Persist Security Info=False;User ID=admin123;Password=Admin321;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            GetConnetionString();
            return connectionString;
        }
    }


}


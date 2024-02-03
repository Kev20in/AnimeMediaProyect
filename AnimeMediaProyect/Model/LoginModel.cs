using System.Text.Json.Serialization;

namespace AnimeMediaProyect
{
    public class LoginRequest{
    public string Usuario  { get; set; }
    public string Contrasena { get; set; }
    }

    public class LoginResponse{
        public string ResponseMessage { get; set; }
        public int ResponseStatus { get; set; }
        public LoginRequest User { get; set; }
        public string Token { get; set; }
    }
}
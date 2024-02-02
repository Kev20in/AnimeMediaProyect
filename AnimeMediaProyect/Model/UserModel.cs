namespace AnimeMediaProyect
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public bool Estatus { get; set; }
    }

    public class Register
    {        
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool Estatus { get; set; }

    }

}
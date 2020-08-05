namespace parkDB
{


    // CLASE PARA EL MODELADO DE USUARIOS
    // UTILIZADA PARA ALMACENAR LA INFORMACION LOCALMENTE
    // Y REDUCIR EL NÚMERO DE PETICIONES A LA BASE DE DATOS


    public class Usuario
    {
        public Usuario() { }
        public string UsuarioID { get; set; } = "";
        public string Contraseña { get; set; } = "";
        public string Nombres { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Email { get; set; } = "";
        public string Puesto { get; set; } = "";
        public double Salario { get; set; } = 0.0;
        public bool Administrador { get; set; } = false;
        public string Avatar { get; set; } = "";
        public override string ToString()
        {
            return $"ID: {UsuarioID}\nNombre Completo: {Nombres} {Apellidos}";
        }
    }
}

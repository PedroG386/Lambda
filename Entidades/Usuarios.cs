using System;

namespace Entidades
{
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contraseña { get; set; }
        public int id_rol { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Activo { get; set; }
        public string Usuario { get; set; }
    }
}

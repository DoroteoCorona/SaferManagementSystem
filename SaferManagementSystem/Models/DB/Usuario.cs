using System;
using System.Collections.Generic;

#nullable disable

namespace SaferManagementSystem.Models.DB
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Numeroempleado { get; set; }
        public string Email { get; set; }
        public int SexoId { get; set; }
        public string Puesto { get; set; }
        public string Posicion { get; set; }
        public int DepartamentoId { get; set; }
        public string Contraseña { get; set; }
        public string Privilegio { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}

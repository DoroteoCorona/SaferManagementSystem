using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace SaferManagementSystem.Models.DB
{
    public partial class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
        
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
       
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
       
        public int Numeroempleado { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
       
        public string Email { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
        
        public int SexoId { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
        
        public string Puesto { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
       
        public string Posicion { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
        
        public int DepartamentoId { get; set; }

        [Required(ErrorMessage = "Compo obligatorio")]
       
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "Privilegio")]
        public string Privilegio { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}

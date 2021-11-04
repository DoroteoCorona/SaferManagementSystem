using System;
using System.Collections.Generic;

#nullable disable

namespace SaferManagementSystem.Models.DB
{
    public partial class RObservacion
    {
        public int Id { get; set; }
        public DateTime FechaRe { get; set; }
        public int UsuarioId { get; set; }
        public int DepartamentoId { get; set; }
        public int AreaId { get; set; }
        public string ObseA { get; set; }
        public int PersonasRetro { get; set; }
        public string Descripcion { get; set; }
        public string AccionRealizada { get; set; }
        public string TipoObservacion { get; set; }
        public int AspectoId { get; set; }
        public int ComportamientoId { get; set; }
        public string Criticidad { get; set; }
        public string ResponsableSeguimiento { get; set; }
        public string Estatus { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}

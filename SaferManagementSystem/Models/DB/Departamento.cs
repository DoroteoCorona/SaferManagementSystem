using System;
using System.Collections.Generic;

#nullable disable

namespace SaferManagementSystem.Models.DB
{
    public partial class Departamento
    {
        public int DepartamentoId { get; set; }
        public string NomDeartamento { get; set; }

        public virtual RObservacion RObservacion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

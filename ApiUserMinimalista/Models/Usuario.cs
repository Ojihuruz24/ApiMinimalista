using System;
using System.Collections.Generic;

namespace ApiUserMinimalista.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Correo { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int? Edad { get; set; }
    }
}

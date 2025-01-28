using System;
using System.Collections.Generic;

namespace ApiUserMinimalista.Models
{
    public partial class Clima
    {
        public int Id { get; set; }
        public string TipoClima { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public string Precipitacion { get; set; } = null!;
        public string Temperatura { get; set; } = null!;
        public int? InfluenciaMar { get; set; }
    }
}

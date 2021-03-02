using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class Trgovina
    {
        public int IdTrgovina { get; set; }
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$",ErrorMessage = "has an invalid format.Format: ###-###-####")]
        public string NazivTrgovina { get; set; }
        public int VrstaRobe { get; set; }

        public virtual VrstaRobe VrstaRobeNavigation { get; set; }
    }
}

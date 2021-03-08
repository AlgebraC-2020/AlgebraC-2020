using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaPoklona.Models
{
    [Keyless]
    public partial class OstvareniPromet
    {
        public string Naziv { get; set; }
        public string VrstaRobe { get; set; }
        public double UkupnoLovePoVrstiRobe { get; set; }
    }

}

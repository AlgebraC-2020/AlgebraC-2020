using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace BazaPoklona.Models
{
    [Keyless]
    public class OstvareniPrometViewModel
    {
        public string NazivRobe { get; set; }

        public string VrstaRobe { get; set; }

        public string UkupnoLovePoVrstiRobe { get; set; }
    }
}
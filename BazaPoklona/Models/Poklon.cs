using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class Poklon
    {
        public int IdPoklon { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Naziv mora biti do ukljucivo 40 znakova")]
        public string Naziv { get; set; }

        [Required]
        public int VrstaRobe { get; set; }

        [Required]
        [Display(Name = "Poklon kupljen")] //DisplayNameFor
        public bool Kupljen { get; set; }

        [Range(0, 999.99)]
        public double Cijena { get; set; }  //primjena iz float u double
        public virtual VrstaRobe VrstaRobeNavigation { get; set; }
    }
}

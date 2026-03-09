using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Facture
    {
        [Key]
        public int IdFacture { get; set; }

        [Required, MaxLength(80)]
        public string NumeroFacture { get; set; }

        [Required]
        public DateTime DateFacture { get; set; } = DateTime.Now;

        [Required]
        public double MontantTotal { get; set; }
    }
}

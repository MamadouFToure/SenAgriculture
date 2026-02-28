using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Champ
    {
        [Key]
        public int IdChamp { get; set; }

        [Required]
        public double Superficie { get; set; }

        [Required]
        public double Superficulture { get; set; }


    }
}

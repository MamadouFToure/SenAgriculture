using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Departement
    {

        [Key]
        public int IdDepartement { get; set; }

        [Required, MaxLength(100)]
        public string Nom { get; set; }

        public int? IdRegion { get; set; }

        [ForeignKey("IdRegion")]
        public virtual Region Region { get; set; }
    }
}

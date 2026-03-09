using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Categorie
    {
        [Key] public int Id { get; set; }
        public int IdCategorie { get; set; }

        [Required, MaxLength(100)]
        public string LibelleCategorie { get; set; }

        [Required, MaxLength(2000)]
        public string DescriptionCategorie { get; set; }

        //une categorie peut avoir plusieurs produits
        public virtual ICollection<Produit> Produits { get; set; }
    }
}

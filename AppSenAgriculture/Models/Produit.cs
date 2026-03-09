using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Produit
    {
        [Key]
        public int IdProduit { get; set; }

        [Required, MaxLength(100)]
        public string LibelleProduit { get; set; }
        [StringLength(5000), Required]
        public string DescriptionProduit { get; set; }

        public double PrixUnuitaireMin { get; set; }

        public double PrixUnuitaireMax { get; set; }

        public int IdUniteMesure { get; set; }

        [ForeignKey("IdUniteMesure")]

        public virtual UniteMesure UniteMesure { get; set; }

        //cle etrangere
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        //un produit appartient a une categorie : propriete de navigation
        public virtual Categorie Categorie { get; set; }

        public virtual ICollection<DetailsCommande> DetailsCommandes { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class stock
    {
        public int IdStock { get; set; }       
        public DateTime Date { get; set; }
        public DateTime DateSortieStock { get; set; }
        public int Qte { get; set; }
        public int PU { get; set; }
        //cle etrangere
        public int IdProduit { get; set; }
        public virtual Produit Produit { get; set; }
    }
}

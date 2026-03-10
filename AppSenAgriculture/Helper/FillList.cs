using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Helper
{
    public class FillList
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        /// <summary>
        /// chargement sur une liste des unites de mesure
        /// </summary>
        /// <returns></returns>
        public List<ListItem> fillUniteMesure()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.UnitesMesures.ToList();
            laListe.Add(new ListItem 
            { 
                Value =  null,
                Text = "Selectionner....." 
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdUnite.ToString(),
                    Text = t.LibelleUnite.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }


        /// <summary>
        /// chargement sur une liste des categories de produit
        /// </summary>
        /// <returns></returns>

        public List<ListItem> fillCategorie()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Categories.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner....."
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdCategorie.ToString(),
                    Text = t.DescriptionCategorie.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }

        /// <summary>
        /// chargement sur une liste des produits
        /// </summary>
        /// <returns></returns>
        public List<ListItem> fillProduit()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Produits.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner....."
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdProduit.ToString(),
                    Text = t.LibelleProduit.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }
    }
}

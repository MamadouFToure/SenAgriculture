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
                    Text = t.LibelleCategorie.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }
    

    public List<ListItem> fillClient()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Clients.ToList();
            laListe.Add(new ListItem { Value = null, Text = "Selectionner....." });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdUtilisateur.ToString(),
                    Text = t.NomCompletUtilisateur.ToString()
                });
            }
            return laListe;
        }

        public List<ListItem> fillCommande()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Commandes.ToList();
            laListe.Add(new ListItem { Value = null, Text = "Selectionner....." });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdCommande.ToString(),
                    Text = t.NumeroCommande.ToString()
                });
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
            laListe.Add(new ListItem { Value = null, Text = "Selectionner....." });
            foreach (var t in liste)
            {
                laListe.Add(new ListItem
                {
                    Value = t.IdProduit.ToString(),
                    Text = t.LibelleProduit.ToString()
                });
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

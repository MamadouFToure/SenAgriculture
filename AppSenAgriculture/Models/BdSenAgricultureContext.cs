using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;  

namespace AppSenAgriculture.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenAgricultureContext:DbContext
    {
        public BdSenAgricultureContext():base("conSenAgriculture")
        { 
        }
                                       
        // Définition des tables de la base de données
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<UniteMesure> UnitesMesures { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Cultivateur> Cultivateurs { get; set; }
        public DbSet<Facilitateur> Facilitateurs { get; set; }
        public DbSet<Agriculteur> Agriculteurs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<DetailsCommande> DetailCommandes { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Stock>   Stocks { get; set; }
        public DbSet<Lieu> Lieux { get; set; }
        public DbSet<Td_Erreur> td_Erreurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

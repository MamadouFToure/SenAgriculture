using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BdSenAgricultureContext:DbContext
    {
        public BdSenAgricultureContext():base("conSenAgriculture")
        {

        }
                                       
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<UniteMesure> UnitesMesures { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Cultivateur> Cultivateurs { get; set; }
        public DbSet<Facilitateur> Facilitateurs { get; set; }
        public DbSet<Client> Clients { get; set; }


    }
}

namespace AppSenAgriculture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Admins",
                c => new
                    {
                        IdAdmin = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MotDePasse = c.String(nullable: false, maxLength: 255),
                        DateCreation = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdAdmin);
            
            CreateTable(
                "Agriculteurs",
                c => new
                    {
                        IdAgriculteur = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MotDePasse = c.String(nullable: false, maxLength: 255),
                        Telephone = c.String(maxLength: 20),
                        Adresse = c.String(maxLength: 255),
                        DateCreation = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdAgriculteur);
            
            CreateTable(
                "Categories",
                c => new
                    {
                        IdCategorie = c.Int(nullable: false, identity: true),
                        NomCategorie = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                        DateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCategorie);
            
            CreateTable(
                "Clients",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MotDePasse = c.String(nullable: false, maxLength: 255),
                        Telephone = c.String(maxLength: 20),
                        Adresse = c.String(maxLength: 255),
                        DateCreation = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdClient);
            
            CreateTable(
                "Commandes",
                c => new
                    {
                        IdCommande = c.Int(nullable: false, identity: true),
                        IdClient = c.Int(nullable: false),
                        DateCommande = c.DateTime(nullable: false),
                        MontantTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Statut = c.String(maxLength: 50),
                        DateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCommande)
                .ForeignKey("Clients", t => t.IdClient, cascadeDelete: true)
                .Index(t => t.IdClient);
            
            CreateTable(
                "Cultivateurs",
                c => new
                    {
                        IdCultivateur = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MotDePasse = c.String(nullable: false, maxLength: 255),
                        Telephone = c.String(maxLength: 20),
                        Adresse = c.String(maxLength: 255),
                        DateCreation = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdCultivateur);
            
            CreateTable(
                "Departements",
                c => new
                    {
                        IdDepartement = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        IdRegion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDepartement)
                .ForeignKey("Regions", t => t.IdRegion, cascadeDelete: true)
                .Index(t => t.IdRegion);
            
            CreateTable(
                "DetailsCommandes",
                c => new
                    {
                        IdDetailsCommande = c.Int(nullable: false, identity: true),
                        IdCommande = c.Int(nullable: false),
                        IdProduit = c.Int(nullable: false),
                        Quantite = c.Int(nullable: false),
                        PrixUnitaire = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontantTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdDetailsCommande)
                .ForeignKey("Commandes", t => t.IdCommande, cascadeDelete: true)
                .ForeignKey("Produits", t => t.IdProduit, cascadeDelete: true)
                .Index(t => t.IdCommande)
                .Index(t => t.IdProduit);
            
            CreateTable(
                "Factures",
                c => new
                    {
                        IdFacture = c.Int(nullable: false, identity: true),
                        IdCommande = c.Int(nullable: false),
                        NumeroFacture = c.String(nullable: false, maxLength: 50),
                        DateFacture = c.DateTime(nullable: false),
                        MontantTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StatutPaiement = c.String(maxLength: 50),
                        DateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdFacture)
                .ForeignKey("Commandes", t => t.IdCommande, cascadeDelete: true)
                .Index(t => t.IdCommande);
            
            CreateTable(
                "Facilitateurs",
                c => new
                    {
                        IdFacilitateur = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MotDePasse = c.String(nullable: false, maxLength: 255),
                        Telephone = c.String(maxLength: 20),
                        Adresse = c.String(maxLength: 255),
                        DateCreation = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdFacilitateur);
            
            CreateTable(
                "Lieux",
                c => new
                    {
                        IdLieu = c.Int(nullable: false, identity: true),
                        NomLieu = c.String(nullable: false, maxLength: 100),
                        AdresseLieu = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.IdLieu);
            
            CreateTable(
                "Produits",
                c => new
                    {
                        IdProduit = c.Int(nullable: false, identity: true),
                        NomProduit = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantiteStock = c.Int(nullable: false),
                        IdCategorie = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduit)
                .ForeignKey("Categories", t => t.IdCategorie, cascadeDelete: true)
                .Index(t => t.IdCategorie);
            
            CreateTable(
                "Regions",
                c => new
                    {
                        IdRegion = c.Int(nullable: false, identity: true),
                        NomRegion = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IdRegion);
            
            CreateTable(
                "Stocks",
                c => new
                    {
                        IdStock = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(nullable: false),
                        Quantite = c.Int(nullable: false),
                        DateMouvement = c.DateTime(nullable: false),
                        TypeMouvement = c.String(maxLength: 50),
                        Commentaire = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.IdStock)
                .ForeignKey("Produits", t => t.IdProduit, cascadeDelete: true)
                .Index(t => t.IdProduit);
            
            CreateTable(
                "UnitesMesures",
                c => new
                    {
                        IdUnite = c.Int(nullable: false, identity: true),
                        NomUnite = c.String(nullable: false, maxLength: 50),
                        Symbole = c.String(maxLength: 10),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.IdUnite);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Stocks", "IdProduit", "Produits");
            DropForeignKey("Produits", "IdCategorie", "Categories");
            DropForeignKey("DetailsCommandes", "IdProduit", "Produits");
            DropForeignKey("DetailsCommandes", "IdCommande", "Commandes");
            DropForeignKey("Factures", "IdCommande", "Commandes");
            DropForeignKey("Commandes", "IdClient", "Clients");
            DropForeignKey("Departements", "IdRegion", "Regions");
            DropIndex("UnitesMesures", new[] { "IdUnite" });
            DropIndex("Stocks", new[] { "IdProduit" });
            DropIndex("Regions", new[] { "IdRegion" });
            DropIndex("Produits", new[] { "IdCategorie" });
            DropIndex("Departements", new[] { "IdRegion" });
            DropIndex("Factures", new[] { "IdCommande" });
            DropIndex("DetailsCommandes", new[] { "IdProduit" });
            DropIndex("DetailsCommandes", new[] { "IdCommande" });
            DropIndex("Commandes", new[] { "IdClient" });
            DropTable("UnitesMesures");
            DropTable("Stocks");
            DropTable("Regions");
            DropTable("Produits");
            DropTable("Lieux");
            DropTable("Facilitateurs");
            DropTable("Factures");
            DropTable("DetailsCommandes");
            DropTable("Departements");
            DropTable("Cultivateurs");
            DropTable("Clients");
            DropTable("Categories");
            DropTable("Commandes");
            DropTable("Agriculteurs");
            DropTable("Admins");
        }
    }
}

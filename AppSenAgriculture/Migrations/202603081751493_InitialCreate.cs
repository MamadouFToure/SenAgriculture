namespace AppSenAgriculture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        IdUtilisateur = c.Int(nullable: false, identity: true),
                        NomCompletUtilisateur = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        AdresseUtilisateur = c.String(maxLength: 300, storeType: "nvarchar"),
                        EmailUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        TelUtilisateur = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        IdentifiantUtilisateur = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        MotDePasseUtilisateur = c.String(nullable: false, maxLength: 300, storeType: "nvarchar"),
                        Id = c.Int(),
                        ProfessionClient = c.String(maxLength: 100, storeType: "nvarchar"),
                        OrganisationFacilitateur = c.String(maxLength: 150, storeType: "nvarchar"),
                        NineaCultivateur = c.String(maxLength: 20, storeType: "nvarchar"),
                        RccmCultivateur = c.String(maxLength: 30, storeType: "nvarchar"),
                        ExploitationAgriculteur = c.String(maxLength: 200, storeType: "nvarchar"),
                        LocalisationAgriculteur = c.String(maxLength: 200, storeType: "nvarchar"),
                        SuperficieAgriculteur = c.Double(),
                        TypeAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        RegionAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        DepartementAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        CommuneAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        VilleVillageAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdUtilisateur);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCategorie = c.Int(nullable: false),
                        LibelleCategorie = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        DescriptionCategorie = c.String(nullable: false, maxLength: 2000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        IdProduit = c.Int(nullable: false, identity: true),
                        LibelleProduit = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        DescriptionProduit = c.String(nullable: false, maxLength: 5000, storeType: "nvarchar"),
                        PrixUnuitaireMin = c.Double(nullable: false),
                        PrixUnuitaireMax = c.Double(nullable: false),
                        IdUniteMesure = c.Int(nullable: false),
                        CategorieId = c.Int(nullable: false),
                        Agriculteur_IdUtilisateur = c.Int(),
                    })
                .PrimaryKey(t => t.IdProduit)
                .ForeignKey("dbo.Categories", t => t.CategorieId, cascadeDelete: true)
                .ForeignKey("dbo.UniteMesures", t => t.IdUniteMesure, cascadeDelete: true)
                .ForeignKey("dbo.Utilisateurs", t => t.Agriculteur_IdUtilisateur)
                .Index(t => t.IdUniteMesure)
                .Index(t => t.CategorieId)
                .Index(t => t.Agriculteur_IdUtilisateur);
            
            CreateTable(
                "dbo.DetailsCommandes",
                c => new
                    {
                        IdDetailsCommande = c.Int(nullable: false, identity: true),
                        IdCommande = c.Int(nullable: false),
                        IdProduit = c.Int(nullable: false),
                        Quantite = c.Double(nullable: false),
                        PrixUnitaire = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetailsCommande)
                .ForeignKey("dbo.Commandes", t => t.IdCommande, cascadeDelete: true)
                .ForeignKey("dbo.Produits", t => t.IdProduit, cascadeDelete: true)
                .Index(t => t.IdCommande)
                .Index(t => t.IdProduit);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        IdCommande = c.Int(nullable: false, identity: true),
                        NumeroCommande = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        DateModificationCommande = c.DateTime(precision: 0),
                        DateCommande = c.DateTime(nullable: false, precision: 0),
                        IsCommande = c.Boolean(nullable: false),
                        IdClient = c.Int(),
                    })
                .PrimaryKey(t => t.IdCommande)
                .ForeignKey("dbo.Utilisateurs", t => t.IdClient)
                .Index(t => t.IdClient);
            
            CreateTable(
                "dbo.UniteMesures",
                c => new
                    {
                        IdUnite = c.Int(nullable: false, identity: true),
                        CodeUnite = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        LibelleUnite = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdUnite);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        IdDepartement = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        IdRegion = c.Int(),
                    })
                .PrimaryKey(t => t.IdDepartement)
                .ForeignKey("dbo.Regions", t => t.IdRegion)
                .Index(t => t.IdRegion);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        IdRegion = c.Int(nullable: false, identity: true),
                        NomRegion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdRegion);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        IdFacture = c.Int(nullable: false, identity: true),
                        NumeroFacture = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        DateFacture = c.DateTime(nullable: false, precision: 0),
                        MontantTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdFacture);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        IdStock = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 0),
                        DatePaiment = c.DateTime(nullable: false, precision: 0),
                        DateSortieStock = c.DateTime(nullable: false, precision: 0),
                        Qte = c.Int(nullable: false),
                        PU = c.Int(nullable: false),
                        IdProduit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdStock)
                .ForeignKey("dbo.Produits", t => t.IdProduit, cascadeDelete: true)
                .Index(t => t.IdProduit);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "Agriculteur_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Stocks", "IdProduit", "dbo.Produits");
            DropForeignKey("dbo.Departements", "IdRegion", "dbo.Regions");
            DropForeignKey("dbo.Produits", "IdUniteMesure", "dbo.UniteMesures");
            DropForeignKey("dbo.DetailsCommandes", "IdProduit", "dbo.Produits");
            DropForeignKey("dbo.DetailsCommandes", "IdCommande", "dbo.Commandes");
            DropForeignKey("dbo.Commandes", "IdClient", "dbo.Utilisateurs");
            DropForeignKey("dbo.Produits", "CategorieId", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "IdProduit" });
            DropIndex("dbo.Departements", new[] { "IdRegion" });
            DropIndex("dbo.Commandes", new[] { "IdClient" });
            DropIndex("dbo.DetailsCommandes", new[] { "IdProduit" });
            DropIndex("dbo.DetailsCommandes", new[] { "IdCommande" });
            DropIndex("dbo.Produits", new[] { "Agriculteur_IdUtilisateur" });
            DropIndex("dbo.Produits", new[] { "CategorieId" });
            DropIndex("dbo.Produits", new[] { "IdUniteMesure" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Factures");
            DropTable("dbo.Regions");
            DropTable("dbo.Departements");
            DropTable("dbo.UniteMesures");
            DropTable("dbo.Commandes");
            DropTable("dbo.DetailsCommandes");
            DropTable("dbo.Produits");
            DropTable("dbo.Categories");
            DropTable("dbo.Utilisateurs");
        }
    }
}

// Appli WinForms : connexion (frmConnexion) puis menu principal (FrmMDI). Comptes : Client, Facilitateur, Agriculteur. Paramètres : Lieu, Facture, Catégorie, Produit.
using AppSenAgriculture.Helper;
using AppSenAgriculture.Models;
using AppSenAgriculture.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }
        /// <summary>
        /// Creation du Super Admin
        /// </summary>

        private static void CreateAdmin()
        {
            BdSenAgricultureContext db = new BdSenAgricultureContext();
            var leAdmin = db.Admins.ToList();
            if (leAdmin.Count == 0)
            {
                Admin a = new Admin();
                a.IdentifiantUtilisateur = "Admin";
                a.AdresseUtilisateur = "Admin";
                a.EmailUtilisateur = "Admin@gmail.com";
                a.TelUtilisateur = "771234567";
                a.MotDePasseUtilisateur = PasswordSecurity.HashPassword("P@sser123");
                a.NomCompletUtilisateur = "Admin";
                db.Admins.Add(a);
                db.SaveChanges();
            }
                    
        }
    }
}

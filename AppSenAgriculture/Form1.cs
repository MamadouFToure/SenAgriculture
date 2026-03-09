using AppSenAgriculture.Helper;
using AppSenAgriculture.Models;
using AppSenAgriculture.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    public partial class frmConnexion : Form
    {
        
        public frmConnexion()
        {
            InitializeComponent();
            // Forcer le masquage du mot de passe
            txtMotDePasse.UseSystemPasswordChar = true;
            txtMotDePasse.PasswordChar = '●';
        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            Utils.WriteFileError("teste des erreurs");
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                BdSenAgricultureContext db = new BdSenAgricultureContext();
                var leUser = db.Utilisateurs.Where(a => a.IdentifiantUtilisateur.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();
                if (leUser != null)
                {
                    MessageBox.Show($"Utilisateur trouvé: {leUser.IdentifiantUtilisateur}\nMot de passe saisi: {txtMotDePasse.Text}\nHash stocké: {leUser.MotDePasseUtilisateur}\nProfil test...");
                    // Utiliser PasswordSecurity pour la vérification SHA256
                    if (PasswordSecurity.VerifyPassword(txtMotDePasse.Text, leUser.MotDePasseUtilisateur))
                    {
                        frmMDI f = new frmMDI();
                        //if (db.Admins.Find(leUser.IdUtilisateur) != null)
                        if (db.Admins.Where(a => a.IdUtilisateur == leUser.IdUtilisateur).FirstOrDefault() != null)
                        {
                            f.profil = "Admin";
                        }
                        else if (db.Clients.Where(a => a.IdUtilisateur == leUser.IdUtilisateur).FirstOrDefault() != null)
                        {
                            f.profil = "Client";
                        }
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou Mot de pass incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Identifiant ou Mot de pass incorrect");
                }  

            }
            catch(Exception ex)
            {
                Utils.WriteLogSystem(ex.ToString(), "Form1-btnSeConnecter_Click");
            }
            

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

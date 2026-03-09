using AppSenAgriculture.Models;
using AppSenAgriculture.Helper;
using AppSenAgriculture.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Account
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();

        private void ResetForm()
        {
            txtNomComplet.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentifiant.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtIdentifiant.Text = string.Empty ;
            dgClients.DataSource = db.Clients.Select(a => new
            {
                a.IdUtilisateur,
                a.NomCompletUtilisateur,
                a.IdentifiantUtilisateur,
                a.ProfessionClient,
                a.TelUtilisateur,
                a.EmailUtilisateur
            }).ToList();
            txtNomComplet.Focus();
        }
        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void lblProfession_Click(object sender, EventArgs e)
        {

        }
      
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Client ut = new Client();
            
            // Générer un mot de passe temporaire sécurisé
            string tempPassword = PasswordSecurity.GenerateTemporaryPassword();
            ut.MotDePasseUtilisateur = PasswordSecurity.HashPassword(tempPassword);

            ut.AdresseUtilisateur= txtAdresse.Text;
            ut.EmailUtilisateur = txtEmail.Text;
            ut.TelUtilisateur = txtTelephone.Text;
            ut.IdentifiantUtilisateur = txtIdentifiant.Text;
            ut.NomCompletUtilisateur=txtNomComplet.Text;
            ut.ProfessionClient = textProfession.Text;
            db.Clients.Add(ut);
            db.SaveChanges();
            
            MessageBox.Show($"Client ajouté avec succès!\nMot de passe temporaire: {tempPassword}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm(); 



        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

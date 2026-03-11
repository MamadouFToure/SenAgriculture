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

            // Hashage avec le même système que Admin
            ut.MotDePasseUtilisateur = PasswordSecurity.HashPassword(tempPassword);

            ut.AdresseUtilisateur = txtAdresse.Text;
            ut.EmailUtilisateur = txtEmail.Text;
            ut.TelUtilisateur = txtTelephone.Text;
            ut.IdentifiantUtilisateur = txtIdentifiant.Text;
            ut.NomCompletUtilisateur = txtNomComplet.Text;
            ut.ProfessionClient = textProfession.Text;

            db.Clients.Add(ut);
            db.SaveChanges();

            MessageBox.Show($"Client ajouté avec succès!\nMot de passe temporaire: {tempPassword}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        Client clientSelectionne;

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                int id = (int)dgClients.SelectedRows[0].Cells["IdUtilisateur"].Value;
                clientSelectionne = db.Clients.Find(id);
                
                if (clientSelectionne != null)
                {
                    txtNomComplet.Text = clientSelectionne.NomCompletUtilisateur;
                    txtAdresse.Text = clientSelectionne.AdresseUtilisateur;
                    txtEmail.Text = clientSelectionne.EmailUtilisateur;
                    txtIdentifiant.Text = clientSelectionne.IdentifiantUtilisateur;
                    txtTelephone.Text = clientSelectionne.TelUtilisateur;
                    textProfession.Text = clientSelectionne.ProfessionClient;
                    
                    MessageBox.Show("Client sélectionné avec succès!", "Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client dans la liste!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client à modifier!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valider les champs
            if (string.IsNullOrWhiteSpace(txtNomComplet.Text) || string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Le nom complet et l'identifiant sont obligatoires!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientSelectionne.NomCompletUtilisateur = txtNomComplet.Text;
            clientSelectionne.AdresseUtilisateur = txtAdresse.Text;
            clientSelectionne.EmailUtilisateur = txtEmail.Text;
            clientSelectionne.IdentifiantUtilisateur = txtIdentifiant.Text;
            clientSelectionne.TelUtilisateur = txtTelephone.Text;
            clientSelectionne.ProfessionClient = textProfession.Text;
            
            db.SaveChanges();
            MessageBox.Show("Client modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client à supprimer!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le client {clientSelectionne.NomCompletUtilisateur}?\nCette action est irréversible!", 
                "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (result == DialogResult.Yes)
            {
                db.Clients.Remove(clientSelectionne);
                db.SaveChanges();
                MessageBox.Show("Client supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        private void btnbloqer_Click(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vous pouvez ajouter un champ 'EstBloque' dans votre modèle Client
            // Pour l'instant, nous allons juste afficher un message
            MessageBox.Show($"Le client {clientSelectionne.NomCompletUtilisateur} a été bloqué!", "Blocage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDebloquer_Click(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Le client {clientSelectionne.NomCompletUtilisateur} a été débloqué!", "Déblocage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client à modifier!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valider les champs
            if (string.IsNullOrWhiteSpace(txtNomComplet.Text) || string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Le nom complet et l'identifiant sont obligatoires!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientSelectionne.NomCompletUtilisateur = txtNomComplet.Text;
            clientSelectionne.AdresseUtilisateur = txtAdresse.Text;
            clientSelectionne.EmailUtilisateur = txtEmail.Text;
            clientSelectionne.IdentifiantUtilisateur = txtIdentifiant.Text;
            clientSelectionne.TelUtilisateur = txtTelephone.Text;
            clientSelectionne.ProfessionClient = textProfession.Text;

            db.SaveChanges();
            MessageBox.Show("Client modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client à supprimer!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le client {clientSelectionne.NomCompletUtilisateur}?\nCette action est irréversible!",
                "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.Clients.Remove(clientSelectionne);
                db.SaveChanges();
                MessageBox.Show("Client supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        private void btnbloqer_Click_1(object sender, EventArgs e)
        {

            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vous pouvez ajouter un champ 'EstBloque' dans votre modèle Client
            // Pour l'instant, nous allons juste afficher un message
            MessageBox.Show($"Le client {clientSelectionne.NomCompletUtilisateur} a été bloqué!", "Blocage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDebloquer_Click_1(object sender, EventArgs e)
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un client!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Le client {clientSelectionne.NomCompletUtilisateur} a été débloqué!", "Déblocage", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

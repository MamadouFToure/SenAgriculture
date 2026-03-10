using AppSenAgriculture.Models;
using AppSenAgriculture.Security;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Account
{
    // Formulaire de gestion des facilitateurs
    public partial class frmFacilitateur : Form
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        private Facilitateur facilitateurSelectionne;

        public frmFacilitateur()
        {
            InitializeComponent();
        }

        private void frmFacilitateur_Load(object sender, EventArgs e)
        {
            ChargerFacilitateurs();
        }

        private void ChargerFacilitateurs()
        {
            dgFacilitateurs.DataSource = db.Facilitateurs.Select(f => new
            {
                f.IdUtilisateur,
                f.NomCompletUtilisateur,
                f.IdentifiantUtilisateur,
                f.OrganisationFacilitateur,
                f.TelUtilisateur,
                f.EmailUtilisateur
            }).ToList();
        }

        private void EffacerChamps()
        {
            txtNomComplet.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtIdentifiant.Clear();
            txtOrganisation.Clear();
            facilitateurSelectionne = null;
            ChargerFacilitateurs();
            txtNomComplet.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomComplet.Text) ||
                string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Le nom complet et l'identifiant sont obligatoires.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Facilitateur f = new Facilitateur();

            string tempPassword = PasswordSecurity.GenerateTemporaryPassword();
            f.MotDePasseUtilisateur = PasswordSecurity.HashPassword(tempPassword);

            f.NomCompletUtilisateur = txtNomComplet.Text;
            f.AdresseUtilisateur = txtAdresse.Text;
            f.EmailUtilisateur = txtEmail.Text;
            f.TelUtilisateur = txtTelephone.Text;
            f.IdentifiantUtilisateur = txtIdentifiant.Text;
            f.OrganisationFacilitateur = txtOrganisation.Text;

            db.Facilitateurs.Add(f);
            db.SaveChanges();

            MessageBox.Show("Facilitateur ajouté avec succès.\nMot de passe temporaire : " + tempPassword,
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EffacerChamps();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgFacilitateurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un facilitateur dans la liste.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgFacilitateurs.SelectedRows[0].Cells["IdUtilisateur"].Value;
            facilitateurSelectionne = db.Facilitateurs.Find(id);

            if (facilitateurSelectionne != null)
            {
                txtNomComplet.Text = facilitateurSelectionne.NomCompletUtilisateur;
                txtAdresse.Text = facilitateurSelectionne.AdresseUtilisateur;
                txtEmail.Text = facilitateurSelectionne.EmailUtilisateur;
                txtTelephone.Text = facilitateurSelectionne.TelUtilisateur;
                txtIdentifiant.Text = facilitateurSelectionne.IdentifiantUtilisateur;
                txtOrganisation.Text = facilitateurSelectionne.OrganisationFacilitateur;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (facilitateurSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un facilitateur.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomComplet.Text) ||
                string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Le nom complet et l'identifiant sont obligatoires.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            facilitateurSelectionne.NomCompletUtilisateur = txtNomComplet.Text;
            facilitateurSelectionne.AdresseUtilisateur = txtAdresse.Text;
            facilitateurSelectionne.EmailUtilisateur = txtEmail.Text;
            facilitateurSelectionne.TelUtilisateur = txtTelephone.Text;
            facilitateurSelectionne.IdentifiantUtilisateur = txtIdentifiant.Text;
            facilitateurSelectionne.OrganisationFacilitateur = txtOrganisation.Text;

            db.SaveChanges();

            MessageBox.Show("Facilitateur modifié avec succès.", "Succès",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            EffacerChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (facilitateurSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un facilitateur.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce facilitateur ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.Facilitateurs.Remove(facilitateurSelectionne);
                db.SaveChanges();

                MessageBox.Show("Facilitateur supprimé avec succès.", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                EffacerChamps();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EffacerChamps();
        }
    }
}

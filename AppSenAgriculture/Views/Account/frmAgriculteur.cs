using AppSenAgriculture.Models;
using AppSenAgriculture.Security;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Account
{
    // CRUD agriculteurs : compte (nom, email, tel, identifiant) + exploitation, localisation, superficie, type, région, département, commune, ville. Mot de passe temporaire à l’ajout.
    public partial class frmAgriculteur : Form
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();
        private Agriculteur agriculteurSelectionne;

        public frmAgriculteur()
        {
            InitializeComponent();
        }

        private void frmAgriculteur_Load(object sender, EventArgs e)
        {
            ChargerRegions();
            ChargerAgriculteurs();
        }

        private void ChargerAgriculteurs()
        {
            dgAgriculteurs.DataSource = db.Agriculteurs.Select(a => new
            {
                a.IdUtilisateur,
                a.NomCompletUtilisateur,
                a.IdentifiantUtilisateur,
                a.TypeAgriculteur,
                a.RegionAgriculteur,
                a.TelUtilisateur
            }).ToList();
        }

        private void ChargerRegions()
        {
            var regions = db.Regions.OrderBy(r => r.NomRegion).ToList();
            cbRegion.Items.Clear();
            foreach (var r in regions)
            {
                cbRegion.Items.Add(r.NomRegion);
            }

            var departements = db.Departements.OrderBy(d => d.Nom).ToList();
            cbDepartement.Items.Clear();
            foreach (var d in departements)
            {
                cbDepartement.Items.Add(d.Nom);
            }
        }

        private void EffacerChamps()
        {
            txtNomComplet.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtIdentifiant.Clear();
            txtExploitation.Clear();
            txtLocalisation.Clear();
            txtSuperficie.Clear();
            txtType.Clear();
            cbRegion.SelectedIndex = -1;
            cbDepartement.SelectedIndex = -1;
            txtCommune.Clear();
            txtVilleVillage.Clear();
            agriculteurSelectionne = null;
            ChargerAgriculteurs();
            txtNomComplet.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomComplet.Text) || string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Le nom complet et l'identifiant sont obligatoires.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Agriculteur a = new Agriculteur();
            string tempPassword = PasswordSecurity.GenerateTemporaryPassword();
            a.MotDePasseUtilisateur = PasswordSecurity.HashPassword(tempPassword);

            a.NomCompletUtilisateur = txtNomComplet.Text;
            a.AdresseUtilisateur = txtAdresse.Text;
            a.EmailUtilisateur = txtEmail.Text;
            a.TelUtilisateur = txtTelephone.Text;
            a.IdentifiantUtilisateur = txtIdentifiant.Text;
            a.ExploitationAgriculteur = txtExploitation.Text;
            a.LocalisationAgriculteur = txtLocalisation.Text;
            double.TryParse(txtSuperficie.Text, out double sup);
            a.SuperficieAgriculteur = sup;
            a.TypeAgriculteur = txtType.Text;
            a.RegionAgriculteur = cbRegion.SelectedItem != null ? cbRegion.SelectedItem.ToString() : string.Empty;
            a.DepartementAgriculteur = cbDepartement.SelectedItem != null ? cbDepartement.SelectedItem.ToString() : string.Empty;
            a.CommuneAgriculteur = txtCommune.Text;
            a.VilleVillageAgriculteur = txtVilleVillage.Text;

            db.Agriculteurs.Add(a);
            db.SaveChanges();

            MessageBox.Show("Agriculteur ajouté avec succès.\nMot de passe temporaire : " + tempPassword,
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EffacerChamps();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgAgriculteurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un agriculteur dans la liste.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgAgriculteurs.SelectedRows[0].Cells["IdUtilisateur"].Value;
            agriculteurSelectionne = db.Agriculteurs.Find(id);

            if (agriculteurSelectionne != null)
            {
                txtNomComplet.Text = agriculteurSelectionne.NomCompletUtilisateur;
                txtAdresse.Text = agriculteurSelectionne.AdresseUtilisateur;
                txtEmail.Text = agriculteurSelectionne.EmailUtilisateur;
                txtTelephone.Text = agriculteurSelectionne.TelUtilisateur;
                txtIdentifiant.Text = agriculteurSelectionne.IdentifiantUtilisateur;
                txtExploitation.Text = agriculteurSelectionne.ExploitationAgriculteur;
                txtLocalisation.Text = agriculteurSelectionne.LocalisationAgriculteur;
                txtSuperficie.Text = agriculteurSelectionne.SuperficieAgriculteur.ToString();
                txtType.Text = agriculteurSelectionne.TypeAgriculteur;
                cbRegion.Text = agriculteurSelectionne.RegionAgriculteur;
                cbDepartement.Text = agriculteurSelectionne.DepartementAgriculteur;
                txtCommune.Text = agriculteurSelectionne.CommuneAgriculteur;
                txtVilleVillage.Text = agriculteurSelectionne.VilleVillageAgriculteur;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (agriculteurSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un agriculteur.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomComplet.Text) || string.IsNullOrWhiteSpace(txtIdentifiant.Text))
            {
                MessageBox.Show("Le nom complet et l'identifiant sont obligatoires.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            agriculteurSelectionne.NomCompletUtilisateur = txtNomComplet.Text;
            agriculteurSelectionne.AdresseUtilisateur = txtAdresse.Text;
            agriculteurSelectionne.EmailUtilisateur = txtEmail.Text;
            agriculteurSelectionne.TelUtilisateur = txtTelephone.Text;
            agriculteurSelectionne.IdentifiantUtilisateur = txtIdentifiant.Text;
            agriculteurSelectionne.ExploitationAgriculteur = txtExploitation.Text;
            agriculteurSelectionne.LocalisationAgriculteur = txtLocalisation.Text;
            double.TryParse(txtSuperficie.Text, out double sup);
            agriculteurSelectionne.SuperficieAgriculteur = sup;
            agriculteurSelectionne.TypeAgriculteur = txtType.Text;
            agriculteurSelectionne.RegionAgriculteur = cbRegion.SelectedItem != null ? cbRegion.SelectedItem.ToString() : string.Empty;
            agriculteurSelectionne.DepartementAgriculteur = cbDepartement.SelectedItem != null ? cbDepartement.SelectedItem.ToString() : string.Empty;
            agriculteurSelectionne.CommuneAgriculteur = txtCommune.Text;
            agriculteurSelectionne.VilleVillageAgriculteur = txtVilleVillage.Text;

            db.SaveChanges();
            MessageBox.Show("Agriculteur modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EffacerChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (agriculteurSelectionne == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un agriculteur.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer cet agriculteur ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Agriculteurs.Remove(agriculteurSelectionne);
                db.SaveChanges();
                MessageBox.Show("Agriculteur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EffacerChamps();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EffacerChamps();
        }
    }
}

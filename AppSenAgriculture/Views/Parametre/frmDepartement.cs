using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AppSenAgriculture.Models;

namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmDepartement : Form
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        public frmDepartement()
        {
            InitializeComponent();
        }

        private void frmDepartement_Load(object sender, EventArgs e)
        {
            ChargerRegions();
            ChargerDepartements();
        }

        private void ChargerDepartements()
        {
            dgvDepartement.DataSource = db.Departements
                .Include(d => d.Region)
                .ToList();

            dgvDepartement.Columns["IdDepartement"].HeaderText = "ID";
            dgvDepartement.Columns["Nom"].HeaderText = "Nom Département";
            dgvDepartement.Columns["IdRegion"].HeaderText = "ID Région";
            dgvDepartement.Columns["Region"].Visible = false; // Cacher l'objet Region
        }

        private void ChargerRegions()
        {
            cmbRegion.DataSource = db.Regions.ToList();
            cmbRegion.DisplayMember = "NomRegion";  // ✅ Nom exact du modèle Region
            cmbRegion.ValueMember = "IdRegion";     // ✅ Nom exact du modèle Region
        }
        /// <summary>
        /// Ajoute un nouveau départemen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomDepartement.Text.Trim()))
            {
                MessageBox.Show("Veuillez entrer un nom de département.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Departement dept = new Departement();
            dept.Nom = txtNomDepartement.Text.Trim();          // ✅ "Nom" pas "NomDepartement"
            dept.IdRegion = Convert.ToInt32(cmbRegion.SelectedValue);

            db.Departements.Add(dept);
            db.SaveChanges();

            MessageBox.Show("Département ajouté avec succès !", "Succès",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChargerDepartements();
            Vider();
        }

        /// <summary>
        /// modifie un département sélectionné dans le DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDepartement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un département.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvDepartement.SelectedRows[0].Cells["IdDepartement"].Value);
            Departement dept = db.Departements.Find(id);

            if (dept != null)
            {
                dept.Nom = txtNomDepartement.Text.Trim();      // ✅ "Nom"
                dept.IdRegion = Convert.ToInt32(cmbRegion.SelectedValue);
                db.SaveChanges();

                MessageBox.Show("Département modifié avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChargerDepartements();
                Vider();
            }
        }

        /// <summary>
        /// supprime un département sélectionné dans le DataGridView après confirmation de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDepartement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un département.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Confirmer la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvDepartement.SelectedRows[0].Cells["IdDepartement"].Value);
                Departement dept = db.Departements.Find(id);

                db.Departements.Remove(dept);
                db.SaveChanges();

                MessageBox.Show("Département supprimé !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChargerDepartements();
                Vider();
            }
        }
        /// <summary>
        /// détecte le clic sur une ligne du DataGridView et affiche les détails du département sélectionné dans les champs de saisie pour modification ou suppression ultérieure. Les champs sont pré-remplis avec le nom du département et la région associée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDepartement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomDepartement.Text = dgvDepartement.SelectedRows[0].Cells["Nom"].Value.ToString();
                cmbRegion.SelectedValue = dgvDepartement.SelectedRows[0].Cells["IdRegion"].Value;
            }
        }

        /// <summary>
        /// vidange les champs de saisie pour permettre l'ajout d'un nouveau département ou la réinitialisation des champs après une modification ou suppression. Les champs sont réinitialisés à des valeurs par défaut (nom vide et première région sélectionnée).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }
        /// <summary>
        /// vidange les champs de saisie pour permettre l'ajout d'un nouveau département ou la réinitialisation des champs après une modification ou suppression. Les champs sont réinitialisés à des valeurs par défaut (nom vide et première région sélectionnée).
        /// </summary>

        private void Vider()
        {
            txtNomDepartement.Text = "";
            cmbRegion.SelectedIndex = 0;
            txtNomDepartement.Focus();
        }
    }
}

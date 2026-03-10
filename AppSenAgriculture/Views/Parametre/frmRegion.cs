using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenAgriculture.Models;

namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmRegion : Form
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        public frmRegion()
        {
            InitializeComponent();
        }

        private void ChargerRegions()
        {
            dgvRegion.DataSource = db.Regions.ToList();
            dgvRegion.Columns["IdRegion"].HeaderText = "ID";
            dgvRegion.Columns["NomRegion"].HeaderText = "Nom Région";
            dgvRegion.Columns["Departements"].Visible = false; // Cacher la collection
        }

        private void Vider()
        {
            txtNomRegion.Text = "";
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            ChargerRegions();
        }

        private void txtNomRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomRegion.Text.Trim()))
            {
                MessageBox.Show("Veuillez entrer un nom de région.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Models.Region region = new Models.Region();
            region.NomRegion = txtNomRegion.Text.Trim();

            db.Regions.Add(region);
            db.SaveChanges();

            MessageBox.Show("Région ajoutée avec succès !", "Succès",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChargerRegions();
            Vider();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvRegion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une région.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvRegion.SelectedRows[0].Cells["IdRegion"].Value);
            Models.Region region = db.Regions.Find(id);

            if (region != null)
            {
                region.NomRegion = txtNomRegion.Text.Trim();
                db.SaveChanges();

                MessageBox.Show("Région modifiée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChargerRegions();
                Vider();
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (dgvRegion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une région.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Confirmer la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvRegion.SelectedRows[0].Cells["IdRegion"].Value);
                Models.Region region = db.Regions.Find(id);

                db.Regions.Remove(region);
                db.SaveChanges();

                MessageBox.Show("Région supprimée !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChargerRegions();
                Vider();
            }
        }

        private void dgvRegion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomRegion.Text = dgvRegion.SelectedRows[0].Cells["NomRegion"].Value.ToString();
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }
    }
}

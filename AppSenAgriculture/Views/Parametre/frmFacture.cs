using AppSenAgriculture.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Parametre
{
    // Formulaire de gestion des factures
    public partial class frmFacture : Form
    {
        BdSenAgricultureContext db = new BdSenAgricultureContext();
        private Facture factureSelectionnee;

        public frmFacture()
        {
            InitializeComponent();
        }

        private void frmFacture_Load(object sender, EventArgs e)
        {
            ChargerFactures();
        }

        private void ChargerFactures()
        {
            dgFactures.DataSource = db.Factures.ToList();
        }

        private void EffacerChamps()
        {
            txtNumero.Clear();
            dtpDate.Value = DateTime.Now;
            txtMontant.Clear();
            factureSelectionnee = null;
            ChargerFactures();
            txtNumero.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Le numéro de facture est obligatoire.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtMontant.Text, out double montant) || montant < 0)
            {
                MessageBox.Show("Montant invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Facture f = new Facture
            {
                NumeroFacture = txtNumero.Text,
                DateFacture = dtpDate.Value,
                MontantTotal = montant
            };

            db.Factures.Add(f);
            db.SaveChanges();

            MessageBox.Show("Facture ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EffacerChamps();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgFactures.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une facture dans la liste.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = int.Parse(dgFactures.CurrentRow.Cells["IdFacture"].Value.ToString());
            factureSelectionnee = db.Factures.Find(id);

            if (factureSelectionnee != null)
            {
                txtNumero.Text = factureSelectionnee.NumeroFacture;
                dtpDate.Value = factureSelectionnee.DateFacture;
                txtMontant.Text = factureSelectionnee.MontantTotal.ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (factureSelectionnee == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une facture.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Le numéro de facture est obligatoire.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtMontant.Text, out double montant) || montant < 0)
            {
                MessageBox.Show("Montant invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            factureSelectionnee.NumeroFacture = txtNumero.Text;
            factureSelectionnee.DateFacture = dtpDate.Value;
            factureSelectionnee.MontantTotal = montant;

            db.SaveChanges();

            MessageBox.Show("Facture modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EffacerChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (factureSelectionnee == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une facture.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer cette facture ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Factures.Remove(factureSelectionnee);
                db.SaveChanges();
                MessageBox.Show("Facture supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EffacerChamps();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EffacerChamps();
        }
    }
}

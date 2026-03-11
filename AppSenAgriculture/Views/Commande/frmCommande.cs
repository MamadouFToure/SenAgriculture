using AppSenAgriculture.Helper;
using AppSenAgriculture.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Commande
{
    public partial class frmCommande : Form
    {
        public frmCommande()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();
        FillList fillList = new FillList();

        private void ResetForm()
        {
            cbbClient.DataSource = fillList.fillClient();
            cbbClient.DisplayMember = "Text";
            cbbClient.ValueMember = "Value";

            dgCommande.DataSource = db.Commandes.Select(c => new
            {
                c.IdCommande,
                c.NumeroCommande,
                c.DateCommande,
                c.DateModificationCommande,
                c.IsCommande,
                Client = c.Client.NomCompletUtilisateur
            }).ToList();

            txtNumeroCommande.Text = string.Empty;
            dtpDateCommande.Value = DateTime.Now;
            chkIsCommande.Checked = false;
            txtNumeroCommande.Focus();
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Models.Commande c = new Models.Commande();
            c.NumeroCommande = txtNumeroCommande.Text;
            c.DateCommande = dtpDateCommande.Value;
            c.IsCommande = chkIsCommande.Checked;
            c.IdClient = int.Parse(cbbClient.SelectedValue.ToString());
            db.Commandes.Add(c);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCommande.CurrentRow.Cells[0].Value.ToString());
            var c = db.Commandes.Find(id);
            txtNumeroCommande.Text = c.NumeroCommande;
            dtpDateCommande.Value = c.DateCommande;
            chkIsCommande.Checked = c.IsCommande;
            cbbClient.SelectedValue = c.IdClient.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCommande.CurrentRow.Cells[0].Value.ToString());
            var c = db.Commandes.Find(id);
            c.NumeroCommande = txtNumeroCommande.Text;
            c.DateCommande = dtpDateCommande.Value;
            c.IsCommande = chkIsCommande.Checked;
            c.IdClient = int.Parse(cbbClient.SelectedValue.ToString());
            c.DateModificationCommande = DateTime.Now;
            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCommande.CurrentRow.Cells[0].Value.ToString());
            var c = db.Commandes.Find(id);
            db.Commandes.Remove(c);
            db.SaveChanges();
            ResetForm();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Commandes.ToList();
            if (!string.IsNullOrEmpty(txtRNumeroCommande.Text))
            {
                liste = liste.Where(c => c.NumeroCommande.ToUpper()
                         .Contains(txtRNumeroCommande.Text.ToUpper())).ToList();
            }
            dgCommande.DataSource = liste.Select(c => new
            {
                c.IdCommande,
                c.NumeroCommande,
                c.DateCommande,
                c.DateModificationCommande,
                c.IsCommande,
                Client = db.Clients.Find(c.IdClient) != null ?
                         db.Clients.Find(c.IdClient).NomCompletUtilisateur : ""
            }).ToList();
        }
    }
}
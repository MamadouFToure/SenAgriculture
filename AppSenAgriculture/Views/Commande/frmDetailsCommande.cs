using AppSenAgriculture.Helper;
using AppSenAgriculture.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Commande
{
    public partial class frmDetailsCommande : Form
    {
        public frmDetailsCommande()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();
        FillList fillList = new FillList();

        private void ResetForm()
        {
            cbbCommande.DataSource = fillList.fillCommande();
            cbbCommande.DisplayMember = "Text";
            cbbCommande.ValueMember = "Value";

            cbbProduit.DataSource = fillList.fillProduit();
            cbbProduit.DisplayMember = "Text";
            cbbProduit.ValueMember = "Value";

            dgDetailsCommande.DataSource = db.DetailCommandes.Select(d => new
            {
                d.IdDetailsCommande,
                Commande = d.Commande.NumeroCommande,
                Produit = d.Produit.LibelleProduit,
                d.Quantite,
                d.PrixUnitaire,
                SousTotal = d.Quantite * d.PrixUnitaire
            }).ToList();

            txtQuantite.Text = string.Empty;
            txtPrixUnitaire.Text = string.Empty;
            lblTotal.Text = "Total : 0 FCFA";
            txtQuantite.Focus();
        }

        private void frmDetailsCommande_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DetailsCommande d = new DetailsCommande();
            d.IdCommande = int.Parse(cbbCommande.SelectedValue.ToString());
            d.IdProduit = int.Parse(cbbProduit.SelectedValue.ToString());
            d.Quantite = double.Parse(txtQuantite.Text);
            d.PrixUnitaire = double.Parse(txtPrixUnitaire.Text);
            db.DetailCommandes.Add(d);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgDetailsCommande.CurrentRow.Cells[0].Value.ToString());
            var d = db.DetailCommandes.Find(id);
            cbbCommande.SelectedValue = d.IdCommande.ToString();
            cbbProduit.SelectedValue = d.IdProduit.ToString();
            txtQuantite.Text = d.Quantite.ToString();
            txtPrixUnitaire.Text = d.PrixUnitaire.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgDetailsCommande.CurrentRow.Cells[0].Value.ToString());
            var d = db.DetailCommandes.Find(id);
            d.IdCommande = int.Parse(cbbCommande.SelectedValue.ToString());
            d.IdProduit = int.Parse(cbbProduit.SelectedValue.ToString());
            d.Quantite = double.Parse(txtQuantite.Text);
            d.PrixUnitaire = double.Parse(txtPrixUnitaire.Text);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgDetailsCommande.CurrentRow.Cells[0].Value.ToString());
            var d = db.DetailCommandes.Find(id);
            db.DetailCommandes.Remove(d);
            db.SaveChanges();
            ResetForm();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.DetailCommandes.ToList();
            if (!string.IsNullOrEmpty(txtRProduit.Text))
            {
                liste = liste.Where(d => d.Produit.LibelleProduit.ToUpper()
                         .Contains(txtRProduit.Text.ToUpper())).ToList();
            }
            dgDetailsCommande.DataSource = liste.Select(d => new
            {
                d.IdDetailsCommande,
                Commande = d.Commande.NumeroCommande,
                Produit = d.Produit.LibelleProduit,
                d.Quantite,
                d.PrixUnitaire,
                SousTotal = d.Quantite * d.PrixUnitaire
            }).ToList();
        }

        private void cbbCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCommande.SelectedValue != null && cbbCommande.SelectedValue.ToString() != "")
            {
                int idCommande;
                if (int.TryParse(cbbCommande.SelectedValue.ToString(), out idCommande))
                {
                    var liste = db.DetailCommandes.Where(d => d.IdCommande == idCommande).ToList();
                    dgDetailsCommande.DataSource = liste.Select(d => new
                    {
                        d.IdDetailsCommande,
                        Commande = d.Commande.NumeroCommande,
                        Produit = d.Produit.LibelleProduit,
                        d.Quantite,
                        d.PrixUnitaire,
                        SousTotal = d.Quantite * d.PrixUnitaire
                    }).ToList();
                    double total = liste.Sum(d => d.Quantite * d.PrixUnitaire);
                    lblTotal.Text = "Total : " + total.ToString("N0") + " FCFA";
                }
            }
        }
    }
}
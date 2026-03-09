using AppSenAgriculture.Helper;
using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmProduit : Form
    {
        public frmProduit()
        {
            InitializeComponent();
        }
        BdSenAgricultureContext db = new BdSenAgricultureContext();
        FillList fillList = new FillList();

        private void ResetForm()
        {
            cbbUniteMesure.DataSource = fillList.fillUniteMesure();
            cbbUniteMesure.DisplayMember = "Text";
            cbbUniteMesure.ValueMember = "Value";

            cbbCategorie.DataSource = fillList.fillCategorie();
            cbbCategorie.DisplayMember = "Text";
            cbbCategorie.ValueMember = "Value";

            dgProduit.DataSource = db.Produits.Select(u => new
            {
                u.IdProduit,
                u.LibelleProduit,
                u.DescriptionProduit,
                u.PrixUnuitaireMin,
                u.PrixUnuitaireMax,
                Categorie = u.Categorie.DescriptionCategorie,
                UniteMesure = u.UniteMesure.LibelleUnite
            }).ToList();

            txtDescription.Text =string.Empty;
            txtPrixUMax.Text = string.Empty;
            txtPrixUMin.Text = string.Empty;
            txtLibelle.Text = string.Empty;

            txtLibelle.Focus();

        }
        private void frmProduit_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
            p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PrixUnuitaireMin = double.Parse(txtPrixUMin.Text);
            p.PrixUnuitaireMax = double.Parse(txtPrixUMax.Text);
            db.Produits.Add(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            txtDescription.Text = p.DescriptionProduit;
            txtLibelle.Text = p.LibelleProduit;
            txtPrixUMax.Text = p.PrixUnuitaireMax.ToString();
            txtPrixUMin.Text = p.PrixUnuitaireMin.ToString();
            cbbCategorie.SelectedIndex = p.CategorieId;
            cbbUniteMesure.SelectedIndex = p.IdUniteMesure;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
            p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PrixUnuitaireMin = double.Parse(txtPrixUMin.Text);
            p.PrixUnuitaireMax = double.Parse(txtPrixUMax.Text);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            db.Produits.Remove(p);
            db.SaveChanges();
            ResetForm();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Produits.ToList();

            if(!string.IsNullOrEmpty(txtRLibelle.Text))
            {
                liste = liste.Where(a => a.LibelleProduit.ToUpper().Contains(txtRLibelle.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRDescription.Text))
            {
                liste = liste.Where(a => a.DescriptionProduit.ToUpper().Contains(txtRDescription.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRPrixUMin.Text))
            {
                int price = int.Parse(txtRPrixUMin.Text);
                liste = liste.Where(a => a.PrixUnuitaireMin >= price).ToList();
            }
            dgProduit.DataSource = liste.Select(u => new
            {
                u.IdProduit,
                u.LibelleProduit,
                u.DescriptionProduit,
                u.PrixUnuitaireMin,
                u.PrixUnuitaireMax,
                Categorie = db.Categories.Find(u.CategorieId).DescriptionCategorie,
                UniteMesure = db.UnitesMesures.Find(u.IdUniteMesure).LibelleUnite
            }).ToList();
        }
    }
}

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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();
        FillList fillList = new FillList();

        private void ResetForm()
        {
            // Charger le ComboBox Produit
            cbbProduit.DataSource = fillList.fillProduit();
            cbbProduit.DisplayMember = "Text";
            cbbProduit.ValueMember = "Value";

            // Charger le DataGridView
            dgStock.DataSource = db.Stocks.Select(s => new
            {
                s.IdStock,
                s.Date,
                s.DatePaiment,
                s.DateSortieStock,
                s.Qte,
                s.PU,
                Produit = s.Produit.LibelleProduit
            }).ToList();

            // Vider les champs
            dtpDate.Value = DateTime.Now;
            dtpDatePaiment.Value = DateTime.Now;
            dtpDateSortieStock.Value = DateTime.Now;
            txtQte.Text = string.Empty;
            txtPU.Text = string.Empty;

            txtQte.Focus();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Date = dtpDate.Value;
            s.DatePaiment = dtpDatePaiment.Value;
            s.DateSortieStock = dtpDateSortieStock.Value;
            s.Qte = int.Parse(txtQte.Text);
            s.PU = int.Parse(txtPU.Text);
            s.IdProduit = int.Parse(cbbProduit.SelectedValue.ToString());
            db.Stocks.Add(s);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgStock.CurrentRow.Cells[0].Value.ToString());
            var s = db.Stocks.Find(id);
            dtpDate.Value = s.Date;
            dtpDatePaiment.Value = s.DatePaiment;
            dtpDateSortieStock.Value = s.DateSortieStock;
            txtQte.Text = s.Qte.ToString();
            txtPU.Text = s.PU.ToString();
            cbbProduit.SelectedValue = s.IdProduit.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgStock.CurrentRow.Cells[0].Value.ToString());
            var s = db.Stocks.Find(id);
            s.Date = dtpDate.Value;
            s.DatePaiment = dtpDatePaiment.Value;
            s.DateSortieStock = dtpDateSortieStock.Value;
            s.Qte = int.Parse(txtQte.Text);
            s.PU = int.Parse(txtPU.Text);
            s.IdProduit = int.Parse(cbbProduit.SelectedValue.ToString());
            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgStock.CurrentRow.Cells[0].Value.ToString());
            var s = db.Stocks.Find(id);
            db.Stocks.Remove(s);
            db.SaveChanges();
            ResetForm();
        }
    }
}

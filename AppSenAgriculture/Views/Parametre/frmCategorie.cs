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
    public partial class frmCategorie : Form
    {
        public frmCategorie()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            DgCaterogie.DataSource = db.Categories.ToList();
        }
        //Pour vider les champs 
        public void effacerChamps()
        {
            txtDescription.Clear();
            txtLibelle.Clear();
            DgCaterogie.DataSource = db.Categories.ToList();
            txtLibelle.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Categorie cat = new Categorie()
            {
                LibelleCategorie = txtLibelle.Text,
                DescriptionCategorie = txtDescription.Text
            };
            db.Categories.Add(cat);
            db.SaveChanges();
            effacerChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgCaterogie.CurrentRow.Cells[0].Value.ToString());
            Categorie cat = db.Categories.Find(id);
            if (cat != null)
            {
                cat.LibelleCategorie = txtLibelle.Text;
                cat.DescriptionCategorie = txtDescription.Text;
                db.SaveChanges();
                effacerChamps();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgCaterogie.CurrentRow.Cells[0].Value.ToString());
            Categorie cat = db.Categories.Find(id);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
                effacerChamps();
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = DgCaterogie.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = DgCaterogie.CurrentRow.Cells[2].Value.ToString();
        }
    }
    }

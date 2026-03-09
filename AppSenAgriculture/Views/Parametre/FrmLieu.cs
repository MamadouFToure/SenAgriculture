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
    public partial class FrmLieu : Form
    {
        // Contexte de la base de donnee
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        public FrmLieu()
        {
            InitializeComponent();
        }

        // Au chargement du formulaire 
        private void FrmLieu_Load(object sender, EventArgs e)
        {
            ChargerLieux();
        }

        // Charge les lieux 
        private void ChargerLieux()
        {
            dgLieux.DataSource = db.Lieux.ToList();
        }

        // Vide les champs 
        private void EffacerChamps()
        {
            txtNom.Clear();
            txtAdresse.Clear();
            ChargerLieux();
            txtNom.Focus();
        }

        // Ajoute 
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Lieu lieu = new Lieu()
            {
                NomLieu = txtNom.Text,
                AdresseLieu = txtAdresse.Text
            };

            db.Lieux.Add(lieu);
            db.SaveChanges();
            EffacerChamps();
        }

        // Modifie 
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgLieux.CurrentRow == null) return;

            int id = int.Parse(dgLieux.CurrentRow.Cells[0].Value.ToString());
            Lieu lieu = db.Lieux.Find(id);

            if (lieu != null)
            {
                lieu.NomLieu = txtNom.Text;
                lieu.AdresseLieu = txtAdresse.Text;
                db.SaveChanges();
                EffacerChamps();
            }
        }

        // Supprime 
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgLieux.CurrentRow == null) return;

            int id = int.Parse(dgLieux.CurrentRow.Cells[0].Value.ToString());
            Lieu lieu = db.Lieux.Find(id);

            if (lieu != null)
            {
                db.Lieux.Remove(lieu);
                db.SaveChanges();
                EffacerChamps();
            }
        }

        
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgLieux.CurrentRow == null) return;

            txtNom.Text = dgLieux.CurrentRow.Cells[1].Value.ToString();
            txtAdresse.Text = dgLieux.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

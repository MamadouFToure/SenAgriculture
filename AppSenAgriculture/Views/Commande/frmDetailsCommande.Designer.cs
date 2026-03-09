namespace AppSenAgriculture.Views.Commande
{
    partial class frmDetailsCommande
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCommande = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbProduit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrixUnitaire = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgDetailsCommande = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRProduit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailsCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Text = "Commande";
            
            this.cbbCommande.FormattingEnabled = true;
            this.cbbCommande.Location = new System.Drawing.Point(18, 32);
            this.cbbCommande.Name = "cbbCommande";
            this.cbbCommande.Size = new System.Drawing.Size(265, 21);
            this.cbbCommande.SelectedIndexChanged += new System.EventHandler(this.cbbCommande_SelectedIndexChanged);
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Text = "Produit";
            
            this.cbbProduit.FormattingEnabled = true;
            this.cbbProduit.Location = new System.Drawing.Point(18, 80);
            this.cbbProduit.Name = "cbbProduit";
            this.cbbProduit.Size = new System.Drawing.Size(265, 21);
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Text = "Quantité";
            
            this.txtQuantite.Location = new System.Drawing.Point(18, 128);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(265, 20);
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Text = "Prix Unitaire";
            
            this.txtPrixUnitaire.Location = new System.Drawing.Point(18, 176);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(265, 20);
            
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(16, 210);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Total : 0 FCFA";
            
            this.btnSelectionner.Location = new System.Drawing.Point(18, 240);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(77, 25);
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            
            this.btnAjouter.Location = new System.Drawing.Point(18, 270);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(77, 25);
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            
            this.btnModifier.Location = new System.Drawing.Point(100, 270);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(77, 25);
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            
            this.btnSupprimer.Location = new System.Drawing.Point(182, 270);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(77, 25);
            this.btnSupprimer.Text = "S&upprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtRProduit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(322, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 72);
            this.groupBox1.Text = "Recherche";
            
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 13);
            this.label5.Name = "label5";
            this.label5.Text = "Produit";
            
            this.txtRProduit.Location = new System.Drawing.Point(62, 29);
            this.txtRProduit.Name = "txtRProduit";
            this.txtRProduit.Size = new System.Drawing.Size(170, 20);
           
            this.btnRechercher.Location = new System.Drawing.Point(684, 26);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(77, 25);
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            
            this.dgDetailsCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailsCommande.Location = new System.Drawing.Point(322, 89);
            this.dgDetailsCommande.Name = "dgDetailsCommande";
            this.dgDetailsCommande.RowHeadersWidth = 51;
            this.dgDetailsCommande.RowTemplate.Height = 24;
            this.dgDetailsCommande.Size = new System.Drawing.Size(797, 375);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 480);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgDetailsCommande);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbProduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCommande);
            this.Controls.Add(this.label1);
            this.Name = "frmDetailsCommande";
            this.Text = "Détails Commande";
            this.Load += new System.EventHandler(this.frmDetailsCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailsCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrixUnitaire;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgDetailsCommande;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRProduit;
        private System.Windows.Forms.Label label5;
    }
}
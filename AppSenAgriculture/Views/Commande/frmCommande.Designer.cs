namespace AppSenAgriculture.Views.Commande
{
    partial class frmCommande
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
            this.txtNumeroCommande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateCommande = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.chkIsCommande = new System.Windows.Forms.CheckBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgCommande = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRNumeroCommande = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Text = "Numéro Commande";
            
            this.txtNumeroCommande.Location = new System.Drawing.Point(18, 32);
            this.txtNumeroCommande.Name = "txtNumeroCommande";
            this.txtNumeroCommande.Size = new System.Drawing.Size(265, 20);
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Text = "Date Commande";
            
            this.dtpDateCommande.Location = new System.Drawing.Point(18, 78);
            this.dtpDateCommande.Name = "dtpDateCommande";
            this.dtpDateCommande.Size = new System.Drawing.Size(265, 20);
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Text = "Client";
            
            this.cbbClient.FormattingEnabled = true;
            this.cbbClient.Location = new System.Drawing.Point(18, 126);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(265, 21);
            
            this.chkIsCommande.AutoSize = true;
            this.chkIsCommande.Location = new System.Drawing.Point(18, 162);
            this.chkIsCommande.Name = "chkIsCommande";
            this.chkIsCommande.Text = "Commande validée";
            
            this.btnSelectionner.Location = new System.Drawing.Point(18, 195);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(77, 25);
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            
            this.btnAjouter.Location = new System.Drawing.Point(18, 225);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(77, 25);
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            
            this.btnModifier.Location = new System.Drawing.Point(100, 225);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(77, 25);
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            
            this.btnSupprimer.Location = new System.Drawing.Point(182, 225);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(77, 25);
            this.btnSupprimer.Text = "S&upprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtRNumeroCommande);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(322, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 72);
            this.groupBox1.Text = "Recherche";
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 13);
            this.label4.Name = "label4";
            this.label4.Text = "Numéro Commande";
            
            this.txtRNumeroCommande.Location = new System.Drawing.Point(62, 29);
            this.txtRNumeroCommande.Name = "txtRNumeroCommande";
            this.txtRNumeroCommande.Size = new System.Drawing.Size(170, 20);
            
            this.btnRechercher.Location = new System.Drawing.Point(684, 26);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(77, 25);
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            
            this.dgCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCommande.Location = new System.Drawing.Point(322, 89);
            this.dgCommande.Name = "dgCommande";
            this.dgCommande.RowHeadersWidth = 51;
            this.dgCommande.RowTemplate.Height = 24;
            this.dgCommande.Size = new System.Drawing.Size(797, 375);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 480);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCommande);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.chkIsCommande);
            this.Controls.Add(this.cbbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateCommande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCommande);
            this.Controls.Add(this.label1);
            this.Name = "frmCommande";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbClient;
        private System.Windows.Forms.CheckBox chkIsCommande;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgCommande;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRNumeroCommande;
        private System.Windows.Forms.Label label4;
    }
}
namespace AppSenAgriculture.Views.Account
{
    partial class frmAgriculteur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNomComplet = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblExploitation = new System.Windows.Forms.Label();
            this.txtExploitation = new System.Windows.Forms.TextBox();
            this.lblLocalisation = new System.Windows.Forms.Label();
            this.txtLocalisation = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.lblCommune = new System.Windows.Forms.Label();
            this.txtCommune = new System.Windows.Forms.TextBox();
            this.lblVilleVillage = new System.Windows.Forms.Label();
            this.txtVilleVillage = new System.Windows.Forms.TextBox();
            this.dgAgriculteurs = new System.Windows.Forms.DataGridView();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgriculteurs)).BeginInit();
            this.SuspendLayout();
            //
            // lblNom
            //
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(68, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom complet";
            //
            // txtNomComplet
            //
            this.txtNomComplet.Location = new System.Drawing.Point(12, 28);
            this.txtNomComplet.MaxLength = 100;
            this.txtNomComplet.Name = "txtNomComplet";
            this.txtNomComplet.Size = new System.Drawing.Size(240, 20);
            this.txtNomComplet.TabIndex = 1;
            //
            // lblAdresse
            //
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 54);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse";
            //
            // txtAdresse
            //
            this.txtAdresse.Location = new System.Drawing.Point(12, 70);
            this.txtAdresse.MaxLength = 300;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(240, 20);
            this.txtAdresse.TabIndex = 3;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(12, 112);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 5;
            //
            // lblTelephone
            //
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(12, 138);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Téléphone";
            //
            // txtTelephone
            //
            this.txtTelephone.Location = new System.Drawing.Point(12, 154);
            this.txtTelephone.MaxLength = 20;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(240, 20);
            this.txtTelephone.TabIndex = 7;
            //
            // lblIdentifiant
            //
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(12, 180);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 8;
            this.lblIdentifiant.Text = "Identifiant";
            //
            // txtIdentifiant
            //
            this.txtIdentifiant.Location = new System.Drawing.Point(12, 196);
            this.txtIdentifiant.MaxLength = 100;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(240, 20);
            this.txtIdentifiant.TabIndex = 9;
            //
            // lblExploitation
            //
            this.lblExploitation.AutoSize = true;
            this.lblExploitation.Location = new System.Drawing.Point(12, 222);
            this.lblExploitation.Name = "lblExploitation";
            this.lblExploitation.Size = new System.Drawing.Size(62, 13);
            this.lblExploitation.TabIndex = 10;
            this.lblExploitation.Text = "Exploitation";
            //
            // txtExploitation
            //
            this.txtExploitation.Location = new System.Drawing.Point(12, 238);
            this.txtExploitation.MaxLength = 200;
            this.txtExploitation.Name = "txtExploitation";
            this.txtExploitation.Size = new System.Drawing.Size(240, 20);
            this.txtExploitation.TabIndex = 11;
            //
            // lblLocalisation
            //
            this.lblLocalisation.AutoSize = true;
            this.lblLocalisation.Location = new System.Drawing.Point(12, 264);
            this.lblLocalisation.Name = "lblLocalisation";
            this.lblLocalisation.Size = new System.Drawing.Size(58, 13);
            this.lblLocalisation.TabIndex = 12;
            this.lblLocalisation.Text = "Localisation";
            //
            // txtLocalisation
            //
            this.txtLocalisation.Location = new System.Drawing.Point(12, 280);
            this.txtLocalisation.MaxLength = 200;
            this.txtLocalisation.Name = "txtLocalisation";
            this.txtLocalisation.Size = new System.Drawing.Size(240, 20);
            this.txtLocalisation.TabIndex = 13;
            //
            // lblSuperficie
            //
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(12, 306);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(55, 13);
            this.lblSuperficie.TabIndex = 14;
            this.lblSuperficie.Text = "Superficie";
            //
            // txtSuperficie
            //
            this.txtSuperficie.Location = new System.Drawing.Point(12, 322);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(240, 20);
            this.txtSuperficie.TabIndex = 15;
            //
            // lblType
            //
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(268, 12);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type";
            //
            // txtType
            //
            this.txtType.Location = new System.Drawing.Point(268, 28);
            this.txtType.MaxLength = 80;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 17;
            //
            // lblRegion
            //
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(268, 54);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 18;
            this.lblRegion.Text = "Région";
            //
            // txtRegion
            //
            this.txtRegion.Location = new System.Drawing.Point(268, 70);
            this.txtRegion.MaxLength = 80;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 20);
            this.txtRegion.TabIndex = 19;
            //
            // lblDepartement
            //
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.Location = new System.Drawing.Point(268, 96);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(66, 13);
            this.lblDepartement.TabIndex = 20;
            this.lblDepartement.Text = "Département";
            //
            // txtDepartement
            //
            this.txtDepartement.Location = new System.Drawing.Point(268, 112);
            this.txtDepartement.MaxLength = 80;
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(200, 20);
            this.txtDepartement.TabIndex = 21;
            //
            // lblCommune
            //
            this.lblCommune.AutoSize = true;
            this.lblCommune.Location = new System.Drawing.Point(268, 138);
            this.lblCommune.Name = "lblCommune";
            this.lblCommune.Size = new System.Drawing.Size(53, 13);
            this.lblCommune.TabIndex = 22;
            this.lblCommune.Text = "Commune";
            //
            // txtCommune
            //
            this.txtCommune.Location = new System.Drawing.Point(268, 154);
            this.txtCommune.MaxLength = 80;
            this.txtCommune.Name = "txtCommune";
            this.txtCommune.Size = new System.Drawing.Size(200, 20);
            this.txtCommune.TabIndex = 23;
            //
            // lblVilleVillage
            //
            this.lblVilleVillage.AutoSize = true;
            this.lblVilleVillage.Location = new System.Drawing.Point(268, 180);
            this.lblVilleVillage.Name = "lblVilleVillage";
            this.lblVilleVillage.Size = new System.Drawing.Size(62, 13);
            this.lblVilleVillage.TabIndex = 24;
            this.lblVilleVillage.Text = "Ville/Village";
            //
            // txtVilleVillage
            //
            this.txtVilleVillage.Location = new System.Drawing.Point(268, 196);
            this.txtVilleVillage.MaxLength = 80;
            this.txtVilleVillage.Name = "txtVilleVillage";
            this.txtVilleVillage.Size = new System.Drawing.Size(200, 20);
            this.txtVilleVillage.TabIndex = 25;
            //
            // dgAgriculteurs
            //
            this.dgAgriculteurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAgriculteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgriculteurs.Location = new System.Drawing.Point(484, 28);
            this.dgAgriculteurs.MultiSelect = false;
            this.dgAgriculteurs.Name = "dgAgriculteurs";
            this.dgAgriculteurs.ReadOnly = true;
            this.dgAgriculteurs.RowHeadersWidth = 62;
            this.dgAgriculteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAgriculteurs.Size = new System.Drawing.Size(420, 380);
            this.dgAgriculteurs.TabIndex = 26;
            //
            // btnSelectionner
            //
            this.btnSelectionner.Location = new System.Drawing.Point(484, 2);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(90, 24);
            this.btnSelectionner.TabIndex = 27;
            this.btnSelectionner.Text = "&Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            //
            // btnAjouter
            //
            this.btnAjouter.Location = new System.Drawing.Point(12, 358);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 28);
            this.btnAjouter.TabIndex = 28;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            //
            // btnModifier
            //
            this.btnModifier.Location = new System.Drawing.Point(93, 358);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 28);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            //
            // btnSupprimer
            //
            this.btnSupprimer.Location = new System.Drawing.Point(174, 358);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 28);
            this.btnSupprimer.TabIndex = 30;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            //
            // btnReset
            //
            this.btnReset.Location = new System.Drawing.Point(268, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 28);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "&Réinitialiser";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // frmAgriculteur
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 420);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.dgAgriculteurs);
            this.Controls.Add(this.txtVilleVillage);
            this.Controls.Add(this.lblVilleVillage);
            this.Controls.Add(this.txtCommune);
            this.Controls.Add(this.lblCommune);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.lblDepartement);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtLocalisation);
            this.Controls.Add(this.lblLocalisation);
            this.Controls.Add(this.txtExploitation);
            this.Controls.Add(this.lblExploitation);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomComplet);
            this.Controls.Add(this.lblNom);
            this.Name = "frmAgriculteur";
            this.Text = "Agriculteur";
            this.Load += new System.EventHandler(this.frmAgriculteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgriculteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNomComplet;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblExploitation;
        private System.Windows.Forms.TextBox txtExploitation;
        private System.Windows.Forms.Label lblLocalisation;
        private System.Windows.Forms.TextBox txtLocalisation;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.Label lblCommune;
        private System.Windows.Forms.TextBox txtCommune;
        private System.Windows.Forms.Label lblVilleVillage;
        private System.Windows.Forms.TextBox txtVilleVillage;
        private System.Windows.Forms.DataGridView dgAgriculteurs;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnReset;
    }
}

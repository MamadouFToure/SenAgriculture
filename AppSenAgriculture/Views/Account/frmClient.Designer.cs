namespace AppSenAgriculture.Views.Account
{
    partial class frmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomComplet = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.textProfession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbloqer = new System.Windows.Forms.Button();
            this.btnDebloquer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomComplet
            // 
            this.txtNomComplet.Location = new System.Drawing.Point(12, 49);
            this.txtNomComplet.MaxLength = 100;
            this.txtNomComplet.Name = "txtNomComplet";
            this.txtNomComplet.Size = new System.Drawing.Size(314, 20);
            this.txtNomComplet.TabIndex = 9;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 24);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(68, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom Prenom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(12, 285);
            this.txtIdentifiant.MaxLength = 100;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(314, 20);
            this.txtIdentifiant.TabIndex = 19;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(12, 225);
            this.txtTelephone.MaxLength = 20;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(314, 20);
            this.txtTelephone.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 165);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(12, 105);
            this.txtAdresse.MaxLength = 300;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(314, 20);
            this.txtAdresse.TabIndex = 16;
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(12, 260);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(53, 13);
            this.lblProfession.TabIndex = 15;
            this.lblProfession.Text = "Identifiant";
            this.lblProfession.Click += new System.EventHandler(this.lblProfession_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(12, 200);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 80);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 12;
            this.lblAdresse.Text = "Adresse";
            // 
            // dgClients
            // 
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(398, 49);
            this.dgClients.MultiSelect = false;
            this.dgClients.Name = "dgClients";
            this.dgClients.ReadOnly = true;
            this.dgClients.RowHeadersWidth = 62;
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(541, 492);
            this.dgClients.TabIndex = 20;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(398, 5);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(100, 32);
            this.btnSelectionner.TabIndex = 21;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(281, 509);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 32);
            this.btnSupprimer.TabIndex = 24;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(281, 461);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 32);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(281, 412);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 32);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // textProfession
            // 
            this.textProfession.Location = new System.Drawing.Point(9, 351);
            this.textProfession.MaxLength = 100;
            this.textProfession.Name = "textProfession";
            this.textProfession.Size = new System.Drawing.Size(317, 20);
            this.textProfession.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Profession";
            // 
            // btnbloqer
            // 
            this.btnbloqer.Location = new System.Drawing.Point(540, 5);
            this.btnbloqer.Name = "btnbloqer";
            this.btnbloqer.Size = new System.Drawing.Size(100, 32);
            this.btnbloqer.TabIndex = 27;
            this.btnbloqer.Text = "&Bloquer";
            this.btnbloqer.UseVisualStyleBackColor = true;
            this.btnbloqer.Click += new System.EventHandler(this.btnbloqer_Click_1);
            // 
            // btnDebloquer
            // 
            this.btnDebloquer.Location = new System.Drawing.Point(688, 5);
            this.btnDebloquer.Name = "btnDebloquer";
            this.btnDebloquer.Size = new System.Drawing.Size(100, 32);
            this.btnDebloquer.TabIndex = 28;
            this.btnDebloquer.Text = "&Debloquer";
            this.btnDebloquer.UseVisualStyleBackColor = true;
            this.btnDebloquer.Click += new System.EventHandler(this.btnDebloquer_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(822, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 32);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "&Reinitialiser";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDebloquer);
            this.Controls.Add(this.btnbloqer);
            this.Controls.Add(this.textProfession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomComplet);
            this.Controls.Add(this.lblNom);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomComplet;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox textProfession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbloqer;
        private System.Windows.Forms.Button btnDebloquer;
        private System.Windows.Forms.Button btnReset;
    }
}
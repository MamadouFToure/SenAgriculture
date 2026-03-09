namespace AppSenAgriculture.Views.Parametre
{
    partial class frmCategorie
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
            this.DgCaterogie = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgCaterogie)).BeginInit();
            this.SuspendLayout();
            // 
            // DgCaterogie
            // 
            this.DgCaterogie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCaterogie.Location = new System.Drawing.Point(283, 32);
            this.DgCaterogie.Margin = new System.Windows.Forms.Padding(2);
            this.DgCaterogie.Name = "DgCaterogie";
            this.DgCaterogie.RowHeadersWidth = 62;
            this.DgCaterogie.RowTemplate.Height = 28;
            this.DgCaterogie.Size = new System.Drawing.Size(583, 436);
            this.DgCaterogie.TabIndex = 0;
            // 
            // Libelle
            // 
            this.Libelle.AutoSize = true;
            this.Libelle.Location = new System.Drawing.Point(27, 44);
            this.Libelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(37, 13);
            this.Libelle.TabIndex = 1;
            this.Libelle.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(29, 65);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(233, 20);
            this.txtLibelle.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(27, 112);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(29, 133);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 103);
            this.txtDescription.TabIndex = 4;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(184, 26);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(77, 25);
            this.btnSelectionner.TabIndex = 5;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(184, 294);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(77, 21);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(184, 260);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(77, 21);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(184, 328);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(77, 21);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "S&upprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 476);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.Libelle);
            this.Controls.Add(this.DgCaterogie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCategorie";
            this.Text = " Categorie";
            this.Load += new System.EventHandler(this.frmCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCaterogie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgCaterogie;
        private System.Windows.Forms.Label Libelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}
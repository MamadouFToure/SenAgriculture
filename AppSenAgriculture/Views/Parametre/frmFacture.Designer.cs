namespace AppSenAgriculture.Views.Parametre
{
    partial class frmFacture
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
            this.dgFactures = new System.Windows.Forms.DataGridView();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactures)).BeginInit();
            this.SuspendLayout();
            //
            // dgFactures
            //
            this.dgFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactures.Location = new System.Drawing.Point(283, 32);
            this.dgFactures.Margin = new System.Windows.Forms.Padding(2);
            this.dgFactures.MultiSelect = false;
            this.dgFactures.Name = "dgFactures";
            this.dgFactures.ReadOnly = true;
            this.dgFactures.RowHeadersWidth = 62;
            this.dgFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFactures.Size = new System.Drawing.Size(583, 436);
            this.dgFactures.TabIndex = 0;
            //
            // lblNumero
            //
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(27, 44);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numéro facture";
            //
            // txtNumero
            //
            this.txtNumero.Location = new System.Drawing.Point(29, 65);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.MaxLength = 80;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(233, 20);
            this.txtNumero.TabIndex = 2;
            //
            // lblDate
            //
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 98);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(29, 116);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 20);
            this.dtpDate.TabIndex = 4;
            //
            // lblMontant
            //
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(27, 152);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 5;
            this.lblMontant.Text = "Montant";
            //
            // txtMontant
            //
            this.txtMontant.Location = new System.Drawing.Point(29, 170);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(233, 20);
            this.txtMontant.TabIndex = 6;
            //
            // btnSelectionner
            //
            this.btnSelectionner.Location = new System.Drawing.Point(184, 26);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(77, 25);
            this.btnSelectionner.TabIndex = 7;
            this.btnSelectionner.Text = "&Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            //
            // btnAjouter
            //
            this.btnAjouter.Location = new System.Drawing.Point(184, 260);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(77, 21);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            //
            // btnModifier
            //
            this.btnModifier.Location = new System.Drawing.Point(184, 294);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(77, 21);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            //
            // btnSupprimer
            //
            this.btnSupprimer.Location = new System.Drawing.Point(184, 328);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(77, 21);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "S&upprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            //
            // btnReset
            //
            this.btnReset.Location = new System.Drawing.Point(29, 210);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(233, 25);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Réinitialiser";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // frmFacture
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 476);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dgFactures);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFacture";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.frmFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFactures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgFactures;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnReset;
    }
}

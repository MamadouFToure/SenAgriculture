namespace AppSenAgriculture.Views.Parametre
{
    partial class frmDepartement
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
            this.txtNomDepartement = new System.Windows.Forms.TextBox();
            this.lblNomDepartement = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.dgvDepartement = new System.Windows.Forms.DataGridView();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartement)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomDepartement
            // 
            this.txtNomDepartement.Location = new System.Drawing.Point(12, 57);
            this.txtNomDepartement.Name = "txtNomDepartement";
            this.txtNomDepartement.Size = new System.Drawing.Size(260, 20);
            this.txtNomDepartement.TabIndex = 9;
            // 
            // lblNomDepartement
            // 
            this.lblNomDepartement.AutoSize = true;
            this.lblNomDepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNomDepartement.Location = new System.Drawing.Point(12, 33);
            this.lblNomDepartement.Name = "lblNomDepartement";
            this.lblNomDepartement.Size = new System.Drawing.Size(109, 15);
            this.lblNomDepartement.TabIndex = 8;
            this.lblNomDepartement.Text = "Nom Departement";
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(15, 125);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(257, 21);
            this.cmbRegion.TabIndex = 11;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRegion.Location = new System.Drawing.Point(15, 100);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(47, 15);
            this.lblRegion.TabIndex = 10;
            this.lblRegion.Text = "Region";
            // 
            // dgvDepartement
            // 
            this.dgvDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartement.Location = new System.Drawing.Point(412, 48);
            this.dgvDepartement.Name = "dgvDepartement";
            this.dgvDepartement.Size = new System.Drawing.Size(438, 390);
            this.dgvDepartement.TabIndex = 15;
            this.dgvDepartement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartement_CellClick);
            // 
            // btnVider
            // 
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVider.Location = new System.Drawing.Point(276, 362);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(97, 26);
            this.btnVider.TabIndex = 19;
            this.btnVider.Tag = "";
            this.btnVider.Text = "&Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSupprimer.Location = new System.Drawing.Point(276, 313);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(97, 29);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Tag = "";
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Location = new System.Drawing.Point(276, 260);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(97, 29);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjouter.Location = new System.Drawing.Point(276, 198);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(97, 29);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvDepartement);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtNomDepartement);
            this.Controls.Add(this.lblNomDepartement);
            this.Name = "frmDepartement";
            this.Text = "Departement";
            this.Load += new System.EventHandler(this.frmDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomDepartement;
        private System.Windows.Forms.Label lblNomDepartement;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.DataGridView dgvDepartement;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
    }
}
namespace AppSenAgriculture.Views.Parametre
{
    partial class frmRegion
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
            this.txtNomRegion = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomRegion
            // 
            this.txtNomRegion.Location = new System.Drawing.Point(31, 49);
            this.txtNomRegion.Name = "txtNomRegion";
            this.txtNomRegion.Size = new System.Drawing.Size(236, 20);
            this.txtNomRegion.TabIndex = 1;
            this.txtNomRegion.TextChanged += new System.EventHandler(this.txtNomRegion_TextChanged);
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(28, 25);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(66, 13);
            this.lblQuantite.TabIndex = 6;
            this.lblQuantite.Text = "Nom Région";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(271, 286);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(97, 29);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Tag = "";
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(271, 233);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(97, 29);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(271, 171);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(97, 29);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(271, 335);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(97, 26);
            this.btnVider.TabIndex = 5;
            this.btnVider.Tag = "";
            this.btnVider.Text = "&Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(406, 49);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.Size = new System.Drawing.Size(438, 364);
            this.dgvRegion.TabIndex = 14;
            this.dgvRegion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegion_CellContentClick);
            // 
            // frmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 441);
            this.ControlBox = false;
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNomRegion);
            this.Controls.Add(this.lblQuantite);
            this.Name = "frmRegion";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.frmRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomRegion;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.DataGridView dgvRegion;
    }
}
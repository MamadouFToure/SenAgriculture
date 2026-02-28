namespace AppSenAgriculture
{
    partial class frmConnexion
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
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.Identifiant = new System.Windows.Forms.Label();
            this.MotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(97, 83);
            this.txtIdentifiant.Multiline = true;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(526, 42);
            this.txtIdentifiant.TabIndex = 1;
            this.txtIdentifiant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(93, 46);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(80, 20);
            this.Identifiant.TabIndex = 0;
            this.Identifiant.Text = "Identifiant";
            // 
            // MotDePasse
            // 
            this.MotDePasse.AutoSize = true;
            this.MotDePasse.Location = new System.Drawing.Point(93, 166);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(105, 20);
            this.MotDePasse.TabIndex = 2;
            this.MotDePasse.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(97, 203);
            this.txtMotDePasse.Multiline = true;
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(526, 42);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Location = new System.Drawing.Point(457, 302);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(166, 51);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "&Se Connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(97, 302);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(166, 51);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "frmConnexion";
            this.Text = "Sen Agriculture :: Connexion";
            this.Load += new System.EventHandler(this.frmConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Label MotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Button btnQuitter;
    }
}
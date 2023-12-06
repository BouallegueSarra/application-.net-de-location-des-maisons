namespace locationMaison
{
    partial class page_connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adresseEmail = new System.Windows.Forms.TextBox();
            this.motpasse = new System.Windows.Forms.TextBox();
            this.btn_inscire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse email";
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_connexion.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_connexion.Location = new System.Drawing.Point(459, 358);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(135, 53);
            this.btn_connexion.TabIndex = 1;
            this.btn_connexion.Text = "Se connecter";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adresseEmail
            // 
            this.adresseEmail.Location = new System.Drawing.Point(296, 183);
            this.adresseEmail.Multiline = true;
            this.adresseEmail.Name = "adresseEmail";
            this.adresseEmail.Size = new System.Drawing.Size(319, 34);
            this.adresseEmail.TabIndex = 4;
            // 
            // motpasse
            // 
            this.motpasse.Location = new System.Drawing.Point(296, 271);
            this.motpasse.Multiline = true;
            this.motpasse.Name = "motpasse";
            this.motpasse.PasswordChar = '*';
            this.motpasse.Size = new System.Drawing.Size(319, 35);
            this.motpasse.TabIndex = 5;
            // 
            // btn_inscire
            // 
            this.btn_inscire.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inscire.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscire.Location = new System.Drawing.Point(617, 358);
            this.btn_inscire.Name = "btn_inscire";
            this.btn_inscire.Size = new System.Drawing.Size(159, 53);
            this.btn_inscire.TabIndex = 6;
            this.btn_inscire.Text = "Créer un compte";
            this.btn_inscire.UseVisualStyleBackColor = false;
            this.btn_inscire.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connexion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // page_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(907, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_inscire);
            this.Controls.Add(this.motpasse);
            this.Controls.Add(this.adresseEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label1);
            this.Name = "page_connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.page_connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresseEmail;
        private System.Windows.Forms.TextBox motpasse;
        private System.Windows.Forms.Button btn_inscire;
        private System.Windows.Forms.Label label2;
    }
}


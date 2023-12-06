namespace locationMaison
{
    partial class inscription
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
            this.nom_c = new System.Windows.Forms.Label();
            this.prenom_c = new System.Windows.Forms.Label();
            this.tel_c = new System.Windows.Forms.Label();
            this.email_c = new System.Windows.Forms.Label();
            this.password_c = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btn_ajoutC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom_c
            // 
            this.nom_c.AutoSize = true;
            this.nom_c.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_c.Location = new System.Drawing.Point(308, 127);
            this.nom_c.Name = "nom_c";
            this.nom_c.Size = new System.Drawing.Size(42, 19);
            this.nom_c.TabIndex = 0;
            this.nom_c.Text = "Nom";
            // 
            // prenom_c
            // 
            this.prenom_c.AutoSize = true;
            this.prenom_c.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_c.Location = new System.Drawing.Point(284, 180);
            this.prenom_c.Name = "prenom_c";
            this.prenom_c.Size = new System.Drawing.Size(66, 19);
            this.prenom_c.TabIndex = 1;
            this.prenom_c.Text = "Prénom";
            // 
            // tel_c
            // 
            this.tel_c.AutoSize = true;
            this.tel_c.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_c.Location = new System.Drawing.Point(187, 239);
            this.tel_c.Name = "tel_c";
            this.tel_c.Size = new System.Drawing.Size(164, 19);
            this.tel_c.TabIndex = 2;
            this.tel_c.Text = "Numéro de téléphone";
            // 
            // email_c
            // 
            this.email_c.AutoSize = true;
            this.email_c.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_c.Location = new System.Drawing.Point(238, 292);
            this.email_c.Name = "email_c";
            this.email_c.Size = new System.Drawing.Size(112, 19);
            this.email_c.TabIndex = 3;
            this.email_c.Text = "Adresse email";
            // 
            // password_c
            // 
            this.password_c.AutoSize = true;
            this.password_c.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_c.Location = new System.Drawing.Point(245, 351);
            this.password_c.Name = "password_c";
            this.password_c.Size = new System.Drawing.Size(106, 19);
            this.password_c.TabIndex = 4;
            this.password_c.Text = "Mot de passe";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(392, 127);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(254, 33);
            this.nom.TabIndex = 5;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(392, 179);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(254, 34);
            this.prenom.TabIndex = 6;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(392, 229);
            this.telephone.Multiline = true;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(254, 39);
            this.telephone.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(392, 286);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(254, 35);
            this.email.TabIndex = 8;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(392, 343);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(254, 37);
            this.password.TabIndex = 9;
            
            // 
            // btn_ajoutC
            // 
            this.btn_ajoutC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ajoutC.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutC.Location = new System.Drawing.Point(563, 419);
            this.btn_ajoutC.Name = "btn_ajoutC";
            this.btn_ajoutC.Size = new System.Drawing.Size(131, 43);
            this.btn_ajoutC.TabIndex = 10;
            this.btn_ajoutC.Text = "S\'inscire";
            this.btn_ajoutC.UseVisualStyleBackColor = false;
            this.btn_ajoutC.Click += new System.EventHandler(this.btn_ajoutC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inscription";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(907, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ajoutC);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.password_c);
            this.Controls.Add(this.email_c);
            this.Controls.Add(this.tel_c);
            this.Controls.Add(this.prenom_c);
            this.Controls.Add(this.nom_c);
            this.Name = "inscription";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom_c;
        private System.Windows.Forms.Label prenom_c;
        private System.Windows.Forms.Label tel_c;
        private System.Windows.Forms.Label email_c;
        private System.Windows.Forms.Label password_c;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btn_ajoutC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
namespace locationMaison
{
    partial class Profil
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
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.prenom_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.telf_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.Vider = new System.Windows.Forms.Button();
            this.liste_contact = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.monProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesAnnoncesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste_contact)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(150, 103);
            this.nom_txt.Multiline = true;
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(157, 32);
            this.nom_txt.TabIndex = 0;
            // 
            // prenom_txt
            // 
            this.prenom_txt.Location = new System.Drawing.Point(561, 108);
            this.prenom_txt.Multiline = true;
            this.prenom_txt.Name = "prenom_txt";
            this.prenom_txt.Size = new System.Drawing.Size(146, 32);
            this.prenom_txt.TabIndex = 1;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(151, 166);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(157, 34);
            this.email_txt.TabIndex = 2;
            // 
            // telf_txt
            // 
            this.telf_txt.Location = new System.Drawing.Point(562, 165);
            this.telf_txt.Multiline = true;
            this.telf_txt.Name = "telf_txt";
            this.telf_txt.Size = new System.Drawing.Size(146, 33);
            this.telf_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(149, 226);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(157, 32);
            this.password_txt.TabIndex = 4;
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modifier.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(476, 226);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(109, 37);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Vider
            // 
            this.Vider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vider.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vider.Location = new System.Drawing.Point(611, 226);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(97, 37);
            this.Vider.TabIndex = 7;
            this.Vider.Text = "Vider";
            this.Vider.UseVisualStyleBackColor = false;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // liste_contact
            // 
            this.liste_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_contact.Location = new System.Drawing.Point(34, 338);
            this.liste_contact.Name = "liste_contact";
            this.liste_contact.RowHeadersWidth = 51;
            this.liste_contact.RowTemplate.Height = 24;
            this.liste_contact.Size = new System.Drawing.Size(839, 161);
            this.liste_contact.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mon profil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Numéro de téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mot de passe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monProfilToolStripMenuItem,
            this.listeDesAnnoncesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // monProfilToolStripMenuItem
            // 
            this.monProfilToolStripMenuItem.Name = "monProfilToolStripMenuItem";
            this.monProfilToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.monProfilToolStripMenuItem.Text = "Mon profil";
            this.monProfilToolStripMenuItem.Click += new System.EventHandler(this.monProfilToolStripMenuItem_Click);
            // 
            // listeDesAnnoncesToolStripMenuItem
            // 
            this.listeDesAnnoncesToolStripMenuItem.Name = "listeDesAnnoncesToolStripMenuItem";
            this.listeDesAnnoncesToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.listeDesAnnoncesToolStripMenuItem.Text = "Liste des annonces";
            this.listeDesAnnoncesToolStripMenuItem.Click += new System.EventHandler(this.listeDesAnnoncesToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Liste des contacts";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(822, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(935, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liste_contact);
            this.Controls.Add(this.Vider);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.telf_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.prenom_txt);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste_contact)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox nom_txt;
        public System.Windows.Forms.TextBox prenom_txt;
        public System.Windows.Forms.TextBox email_txt;
        public System.Windows.Forms.TextBox telf_txt;
        public System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Vider;
        private System.Windows.Forms.DataGridView liste_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem monProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesAnnoncesToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}
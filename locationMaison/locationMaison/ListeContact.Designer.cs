namespace locationMaison
{
    partial class ListeContact
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
            this.liste_contact = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.endroit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesAnnoncesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.liste_contact)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liste_contact
            // 
            this.liste_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_contact.Location = new System.Drawing.Point(51, 113);
            this.liste_contact.Name = "liste_contact";
            this.liste_contact.RowHeadersWidth = 51;
            this.liste_contact.RowTemplate.Height = 24;
            this.liste_contact.Size = new System.Drawing.Size(611, 162);
            this.liste_contact.TabIndex = 1;
            this.liste_contact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste_contact_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titre de l\'annonce :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endroit :";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(264, 339);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(0, 16);
            this.titre.TabIndex = 4;
            // 
            // endroit
            // 
            this.endroit.AutoSize = true;
            this.endroit.Location = new System.Drawing.Point(177, 377);
            this.endroit.Name = "endroit";
            this.endroit.Size = new System.Drawing.Size(0, 16);
            this.endroit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id de l\'annonce :";
            // 
            // idA
            // 
            this.idA.AutoSize = true;
            this.idA.Location = new System.Drawing.Point(243, 300);
            this.idA.Name = "idA";
            this.idA.Size = new System.Drawing.Size(0, 16);
            this.idA.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistiqueToolStripMenuItem,
            this.gestionDesAnnoncesToolStripMenuItem,
            this.listeDesContactsToolStripMenuItem,
            this.listeDesClientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            this.statistiqueToolStripMenuItem.Click += new System.EventHandler(this.statistiqueToolStripMenuItem_Click);
            // 
            // gestionDesAnnoncesToolStripMenuItem
            // 
            this.gestionDesAnnoncesToolStripMenuItem.Name = "gestionDesAnnoncesToolStripMenuItem";
            this.gestionDesAnnoncesToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.gestionDesAnnoncesToolStripMenuItem.Text = "Gestion des annonces";
            this.gestionDesAnnoncesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesAnnoncesToolStripMenuItem_Click);
            // 
            // listeDesContactsToolStripMenuItem
            // 
            this.listeDesContactsToolStripMenuItem.Name = "listeDesContactsToolStripMenuItem";
            this.listeDesContactsToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.listeDesContactsToolStripMenuItem.Text = "Liste des contacts";
            this.listeDesContactsToolStripMenuItem.Click += new System.EventHandler(this.listeDesContactsToolStripMenuItem_Click);
            // 
            // listeDesClientToolStripMenuItem
            // 
            this.listeDesClientToolStripMenuItem.Name = "listeDesClientToolStripMenuItem";
            this.listeDesClientToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.listeDesClientToolStripMenuItem.Text = "Liste des clients";
            this.listeDesClientToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(598, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 51;
            this.button2.Text = "Déconnexion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(245, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 33);
            this.label10.TabIndex = 52;
            this.label10.Text = "Liste des contacts";
            // 
            // ListeContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endroit);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liste_contact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListeContact";
            this.Text = "ListeContact";
            this.Load += new System.EventHandler(this.ListeContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste_contact)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView liste_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label endroit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesAnnoncesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}
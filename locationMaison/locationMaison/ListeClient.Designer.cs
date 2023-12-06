namespace locationMaison
{
    partial class ListeClient
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
            this.listclient = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesAnnoncesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listclient)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listclient
            // 
            this.listclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listclient.Location = new System.Drawing.Point(77, 155);
            this.listclient.Name = "listclient";
            this.listclient.RowHeadersWidth = 51;
            this.listclient.RowTemplate.Height = 24;
            this.listclient.Size = new System.Drawing.Size(644, 218);
            this.listclient.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistiqueToolStripMenuItem,
            this.gestionDesAnnoncesToolStripMenuItem,
            this.listeDesContactsToolStripMenuItem,
            this.listeDesClientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
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
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            this.listeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientsToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(687, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 50;
            this.button2.Text = "Déconnexion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 33);
            this.label10.TabIndex = 51;
            this.label10.Text = "Liste des clients";
            // 
            // ListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listclient);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListeClient";
            this.Text = "ListeClient";
            this.Load += new System.EventHandler(this.ListeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listclient)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listclient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesAnnoncesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}
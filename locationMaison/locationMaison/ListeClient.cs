using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace locationMaison
{
    public partial class ListeClient : Form
    {
        MySqlConnection connexion;
        public ListeClient()
        {
            InitializeComponent();
        }

        private void ListeClient_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location;convert zero datetime=True");
            try
            {
                this.connexion.Open();
               // MessageBox.Show("connexion avec succée");
                list_client_Click();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur de connexion");
            }
        }
        private void list_client_Click()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * from client", this.connexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            listclient.DataSource = dt;
            dr.Close();

        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistique stat = new Statistique();
            stat.Show();
            this.Hide();
        }

        private void gestionDesAnnoncesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionAnnonce annonce = new GestionAnnonce();
            annonce.Show();
            this.Hide();
        }

        private void listeDesContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeContact lc = new ListeContact();
            lc.Show();
            this.Hide();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClient cl = new ListeClient();
            cl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page_connexion desc = new page_connexion();
            desc.Show();
            this.connexion.Close();
            this.Hide();
        }
    }
}

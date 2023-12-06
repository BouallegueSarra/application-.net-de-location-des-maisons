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
    public partial class ListeContact : Form
    {
        MySqlConnection connexion;

        public ListeContact()
        {
            InitializeComponent();
        }

        private void ListeContact_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location;convert zero datetime=True");
            try
            {
                this.connexion.Open();
            //    MessageBox.Show("connexion avec succée");
                Afficher();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur de connexion");
            }
        }
        private void Afficher()
        {
            try
            {
                string sql = "SELECT * FROM  contact";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, this.connexion);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable table = dataset.Tables[0];
                liste_contact.DataSource = table;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void liste_contact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idA.Text = liste_contact.CurrentRow.Cells[5].Value.ToString();
            MySqlCommand verif = new MySqlCommand("select * from annonce where idA ='" + idA.Text + "'", connexion);
            verif.ExecuteNonQuery();
            MySqlDataReader reader = verif.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                reader.Read();
                string id = reader.GetString("idA");
                string tit = reader.GetString("titre");
                string emp = reader.GetString("emplacement");
                titre.Text = tit;
                endroit.Text = emp;
               
            }

            reader.Close();
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

        private void listeDesClientToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

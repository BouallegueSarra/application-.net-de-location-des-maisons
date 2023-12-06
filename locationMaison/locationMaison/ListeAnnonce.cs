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
    public partial class ListeAnnonce : Form
    {
        MySqlConnection connexion;
        public ListeAnnonce()
        {
            InitializeComponent();
        }

        private void ListeAnnonce_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location;convert zero datetime=True");
            try
            {
                this.connexion.Open();
               // MessageBox.Show("connexion avec succée");
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
                string sql = "SELECT * FROM  annonce";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, this.connexion);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable table = dataset.Tables[0];
                liste_annonce.DataSource = table;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand verif = new MySqlCommand("select * from annonce where idA ='" + txt_id.Text + "'", connexion);
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
                String id = reader.GetString("idA");

                Contact cont = new Contact();
                cont.id.Text = id;
                cont.Show();
                this.Hide();
            }
            
            reader.Close();

        }

        public void liste_annonce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = liste_annonce.CurrentRow.Cells[0].Value.ToString();
            txt_titre.Text = liste_annonce.CurrentRow.Cells[1].Value.ToString();
            txt_emp.Text = liste_annonce.CurrentRow.Cells[2].Value.ToString();
            txt_cat.Text = liste_annonce.CurrentRow.Cells[3].Value.ToString();
            txt_prix.Text = liste_annonce.CurrentRow.Cells[4].Value.ToString();
            txt_nb.Text = liste_annonce.CurrentRow.Cells[5].Value.ToString();
            txt_espace.Text = liste_annonce.CurrentRow.Cells[6].Value.ToString();
            txt_etat.Text = liste_annonce.CurrentRow.Cells[7].Value.ToString();
            txt_date.Text = liste_annonce.CurrentRow.Cells[8].Value.ToString();
            txt_disc.Text = liste_annonce.CurrentRow.Cells[9].Value.ToString();
            


        }

        private void monProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand verif = new MySqlCommand("select * from client where IdC='" + label11.Text + "'", connexion);
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
                String nom = reader.GetString("nom");
                String prenom = reader.GetString("prenom");
                String email = reader.GetString("email");
                String telephone = reader.GetString("tel");
                String password = reader.GetString("password");

                Profil profil = new Profil();
                profil.nom_txt.Text = nom;
                profil.prenom_txt.Text = prenom;
                profil.email_txt.Text = email;
                profil.telf_txt.Text = telephone;

                profil.Show();
                this.Hide();



            }
        }

        private void listeDesAnnoncesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAnnonce annonce = new ListeAnnonce();
            annonce.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page_connexion desc = new page_connexion();
            desc.Show();
            this.connexion.Close();
            this.Hide();
        }

        private void txt_espace_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

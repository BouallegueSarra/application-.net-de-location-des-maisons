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
    public partial class Statistique : Form
    {
        MySqlConnection conx;

        public Statistique()
        {
            InitializeComponent();
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

        private void Statistique_Load(object sender, EventArgs e)
        {

            this.conx = new MySqlConnection("server=localhost;user=root;database=location");
            try
            {
                this.conx.Open();
                //MessageBox.Show("connexion avec succée");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connexion");
            }



            // ********** Nombre des client ****************
            MySqlCommand nbClient = new MySqlCommand("select count(*) from client ", this.conx);
            nbClient.ExecuteNonQuery();

            MySqlDataReader reader = nbClient.ExecuteReader();

            reader.Read();
            String nb = reader.GetString("count(*)");
            client.Text = client.Text + " = " + nb;

            reader.Close();



            // ********** Nombre des contact ****************
            MySqlCommand nbContact = new MySqlCommand("select count(*) from contact ", this.conx);
            nbClient.ExecuteNonQuery();

            MySqlDataReader reader2 = nbContact.ExecuteReader();

            reader2.Read();
            String nb2 = reader2.GetString("count(*)");
            Contact.Text = Contact.Text + " = " + nb2;
            reader2.Close();


            // ********** Nombre des annonces ****************
            MySqlCommand nbAnnonce = new MySqlCommand("select count(*) from annonce ", this.conx);
            nbClient.ExecuteNonQuery();

            MySqlDataReader reader3 = nbAnnonce.ExecuteReader();

            reader3.Read();
            String nb3 = reader3.GetString("count(*)");
            annonce.Text = annonce.Text + " = " + nb3;
            reader3.Close();


            // ********** Nombre des maison loué  ****************
            MySqlCommand nbMaisonLoue = new MySqlCommand("select count(*) from annonce where etat='Louée'", this.conx);
            nbMaisonLoue.ExecuteNonQuery();

            MySqlDataReader reader4 = nbMaisonLoue.ExecuteReader();

            reader4.Read();
            String nb4 = reader4.GetString("count(*)");
            loué.Text = loué.Text + " = " + nb4;
            reader4.Close();



            // ********** Nombre des maison non loué  ****************
            MySqlCommand nbMaisonNonLoue = new MySqlCommand("select count(*) from annonce where etat='Non louée'", this.conx);
            nbMaisonNonLoue.ExecuteNonQuery();

            MySqlDataReader reader5 = nbMaisonNonLoue.ExecuteReader();

            reader5.Read();
            String nb5 = reader5.GetString("count(*)");
            NonLoué.Text = NonLoué.Text + " = " + nb5;
            reader5.Close();




        }



        private void button2_Click(object sender, EventArgs e)
        {
            page_connexion desc = new page_connexion();
            desc.Show();
            this.conx.Close();
            this.Hide();
        }

     


        private void statistiqueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Statistique stat = new Statistique();
            stat.Show();
            this.Hide();
        }

        private void listeDesClientsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListeClient lc = new ListeClient();
            lc.Show();
            this.Hide();
        }

        private void gestionDesAnnoncesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestionAnnonce annonce = new GestionAnnonce();
            annonce.Show();
            this.Hide();
        }

        private void gestionDesContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeContact contact = new ListeContact();
            contact.Show();
            this.Hide();
        }


    }
    
}

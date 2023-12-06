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
using System.Text.RegularExpressions;

namespace locationMaison
{
    public partial class Profil : Form
    {
        MySqlConnection connexion;
        double id;
        public Profil()
        {
            InitializeComponent();
        }


        private void Profil_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location");
            try
            {
                this.connexion.Open();
          //      MessageBox.Show("connexion avec succée");
                list_contact_Click();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur de connexion");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "" || prenom_txt.Text == "" || email_txt.Text == "" || password_txt.Text == "" || telf_txt.Text == "")
            {

                MessageBox.Show("Champ vide !!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if
                    (telf_txt.Text.Length < 8)
            {
                MessageBox.Show("numéro de telephone invalid", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Regex.IsMatch(telf_txt.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Veuillez saisir seulement des numéros", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Regex.IsMatch(email_txt.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                MessageBox.Show("Adresse email invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                recupereId();
                MySqlCommand update = new MySqlCommand("update client set nom='" + nom_txt.Text + "',prenom='" + prenom_txt.Text + "',email='" + email_txt.Text + "',password= MD5('" + password_txt.Text + "'), tel='" + telf_txt.Text + "' where idC = '" + id +"'", this.connexion);
               // MessageBox.Show("mmm  " + update);

                if (update.ExecuteNonQuery() != 0)
                {

                    MessageBox.Show("Client a été modifié avec succée", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Profil profil = new Profil();
                    

                    profil.nom_txt.Text = nom_txt.Text;
                    profil.prenom_txt.Text = prenom_txt.Text;
                    profil.email_txt.Text = email_txt.Text;
                    profil.telf_txt.Text = telf_txt.Text;
                    
                    profil.Show();
                    this.Hide();


                }
            }

        }

       
        private void Vider_Click(object sender, EventArgs e)
        {

            nom_txt.Text = "";
            prenom_txt.Text = "";
            email_txt.Text = "";
            telf_txt.Text = "";
            password_txt.Text = "";

        }
        private void recupereId()
        {
            MySqlCommand verif2 = new MySqlCommand("select * from client where email='" + email_txt.Text + "'", this.connexion);
            verif2.ExecuteNonQuery();
            MySqlDataReader reader = verif2.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            //MessageBox.Show("count " + count);
            if (count == 1)
            {
                reader.Read();
                this.id = reader.GetDouble("idC");
                //   MessageBox.Show("Id de client est " + id);

            }
            reader.Close();
        }
        private void list_contact_Click()
        {
            recupereId();
            MySqlCommand cmd = new MySqlCommand("SELECT * from contact where emailC ='" + email_txt.Text + "'", this.connexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            liste_contact.DataSource = dt;
            dr.Close();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
         page_connexion desc= new page_connexion(); 
                desc.Show();
               this.connexion.Close();
               this.Hide();
        }

        private void listeDesAnnoncesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MySqlCommand verif2 = new MySqlCommand("select * from client where email='" + email_txt.Text + "'", this.connexion);
            verif2.ExecuteNonQuery();
            MySqlDataReader reader = verif2.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
           
            if (count == 1)
            {
                id = reader.GetDouble("idC");
                ListeAnnonce annonce = new ListeAnnonce();
                
                annonce.label11.Text = this.id.ToString();
                annonce.Show();
                this.Hide();
                reader.Read();
               
                //   MessageBox.Show("Id de client est " + id);

            }
            reader.Close();


           
        }

        private void monProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }
    }
}

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
    public partial class GestionAnnonce : Form
    {
        MySqlConnection connexion;
        public GestionAnnonce()
        {
            InitializeComponent();
        }

        private void Annonce_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location;convert zero datetime=True");
            try
            {
                this.connexion.Open();
                // MessageBox.Show("connexion avec succès");
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur de connexion");
            }

        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Afficher();
        }

        private void btn_ajoutA_Click(object sender, EventArgs e)
        {
            Boolean error = false;
           
            if (titre.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le titre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                titre.Focus();
            }
            else if (emp.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir l'emplacement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emp.Focus();
            }
            else if (nbChambre.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le nombre de chambre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nbChambre.Focus();
            }
            else if (prix.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le prix", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prix.Focus();
            }
            else if (espace.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir l'espace", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                espace.Focus();
            }


            else if (!(Regex.IsMatch(nbChambre.Text, @"^[0-9]+$")))
            {
                error = true;
                MessageBox.Show("Nombre de chambre doit contenir seulement des chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nbChambre.Focus();
            }

            else if (!(Regex.IsMatch(prix.Text, @"^[0-9]+$")))
            {
                error = true;
                MessageBox.Show("Le prix doit contenir seulement des chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prix.Focus();
            }
            else if (!(Regex.IsMatch(espace.Text, @"^[0-9]+$")))
            {
                error = true;
                MessageBox.Show("L'espace doit contenir seulement des chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                espace.Focus();
            }






            if (!error)
            {
                string sql = "INSERT INTO annonce(titre,emplacement, catégorie, prix, nbchambre, espace, etat,date, description)" + "VALUES('"+titre.Text.Trim()+ "', '" + emp.Text.Trim() + "', '" + catégorie.Text.Trim() + "', '" + prix.Text.Trim() + "', '" + nbChambre.Text.Trim() + "', '" + espace.Text.Trim() + "', '" + etat.Text.Trim() + "', '" + date.Text + "', '" +   desc.Text.Trim() + "')";
                MySqlCommand command = new MySqlCommand(sql, this.connexion);
                try { 
                    int x = command.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Insertion avec succès", "Bravo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vider();
                        Afficher();
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'insertion");
                    }
                } catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
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
        private void Vider()
        {
            id.Text = "";
            titre.Text = "";
            emp.Text = "";
            catégorie.SelectedIndex = -1;
            prix.Text = "";
            nbChambre.Text = "";
            espace.Text = "";
            etat.SelectedIndex = -1;
            desc.Text = "";
        }

        private void liste_annonce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = liste_annonce.CurrentRow.Cells[0].Value.ToString();
            titre.Text = liste_annonce.CurrentRow.Cells[1].Value.ToString();
            emp.Text = liste_annonce.CurrentRow.Cells[2].Value.ToString();
            catégorie.Text = liste_annonce.CurrentRow.Cells[3].Value.ToString();
            prix.Text = liste_annonce.CurrentRow.Cells[4].Value.ToString();
            nbChambre.Text = liste_annonce.CurrentRow.Cells[5].Value.ToString();
            espace.Text = liste_annonce.CurrentRow.Cells[6].Value.ToString();
            etat.Text = liste_annonce.CurrentRow.Cells[7].Value.ToString();
            date.Text = liste_annonce.CurrentRow.Cells[8].Value.ToString();
            desc.Text = liste_annonce.CurrentRow.Cells[9].Value.ToString();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(id.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez sélectionner une annonce !");
                return;
            }
            if (MessageBox.Show("Voulez vous vraiment supprimer cette annonce!", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM annonce WHERE idA = " + id.Text.Trim();
                MySqlCommand commande = new MySqlCommand(sql, this.connexion);
                try
                {
                    int x = commande.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Suppression avec succès", "Bravo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vider();
                        Afficher();
                    }
                    else
                    {
                        MessageBox.Show("Erreur de suppression");
                    }
                }
                catch (MySqlException ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void brn_modifierA_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            if (id.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez sélectionner une annonce !");
                return;
            }

            

            if (titre.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le titre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                titre.Focus();
            }
            else if (emp.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir l'emplacement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emp.Focus();
            }
            else if (nbChambre.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le nombre de chambre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nbChambre.Focus();
            }
            else if (prix.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le prix", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prix.Focus();
            }
            else if (espace.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir l'espace", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                espace.Focus();
            }
            else if (!(Regex.IsMatch(nbChambre.Text, @"^[0-9]+$")))
            {
                error = true;
                MessageBox.Show("Nombre de chambre doit contenir seulement des chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nbChambre.Focus();
            }

            else if (!(Regex.IsMatch(prix.Text, @"^[0-9]+$")))
            {
                error = true;
                MessageBox.Show("Le prix doit contenir seulement des chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prix.Focus();
            }
            else if (!(Regex.IsMatch(espace.Text, @"^[0-9]+$")))
            {
                error = true;
                MessageBox.Show("L'espace doit contenir seulement des chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                espace.Focus();
            }
            else
            {

                string sql = "UPDATE annonce SET titre= '" + titre.Text.Trim() + "', emplacement = '" + emp.Text.Trim() + "', catégorie='" + catégorie.SelectedItem.ToString() + "', prix='" + prix.Text.Trim() + "', nbchambre='" + nbChambre.Text.Trim() + "', espace='" + espace.Text.Trim() + "', etat='" + etat.SelectedItem.ToString() + "',date='" + date.Text.Trim() + "',description='" + desc.Text.Trim() + "' WHERE idA= " + id.Text.Trim();
                MySqlCommand commande = new MySqlCommand(sql, this.connexion);
                try
                {
                    int x = commande.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Modification avec succès", "Bravo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vider();
                        Afficher();
                    }
                    else
                    {
                        MessageBox.Show("Erreur de modification");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void emp_TextChanged(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionAnnonce annonce = new GestionAnnonce();
            annonce.Show();
            this.Hide();
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClient lc = new ListeClient();
            lc.Show();
            this.Hide();
        }

        private void gestionDesContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeContact contact = new ListeContact();
            contact.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page_connexion desc = new page_connexion();
            desc.Show();
            this.connexion.Close();
            this.Hide();
        }

        private void gestionDesAnnoncesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistique stat = new Statistique();
            stat.Show();
            this.Hide();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            id.Text = "";
            titre.Text = "";
            emp.Text = "";
            catégorie.Text = "";
            prix.Text = "";
            nbChambre.Text = "";
            espace.Text = "";
            etat.SelectedIndex = -1;
            desc.Text = "";
        }
    }
}

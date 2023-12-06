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
    public partial class Contact : Form
    {
        MySqlConnection connexion;
        public Contact()
        {
            InitializeComponent();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {

            Boolean error = false;

            if (txt_nom.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le titre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nom.Focus();
            }else if (txt_email.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir l'email", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }
            else if (txt_tel.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le numéro de téléphone", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tel.Focus();
            }
            else if
                    (txt_tel.Text.Length < 8)
            {
                MessageBox.Show("numéro de telephone invalid", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Regex.IsMatch(txt_tel.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Veuillez saisir seulement des numéros", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (txt_msg.Text.Trim() == "")
            {
                error = true;
                MessageBox.Show("veuillez saisir le message", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_msg.Focus();
            }
            else if (!error)
            {
                string sql = "INSERT INTO contact(nomC,emailC, telC, message, idA)" + "VALUES('" + txt_nom.Text.Trim() + "', '" + txt_email.Text.Trim() + "', '" + txt_tel.Text.Trim() + "', '" + txt_msg.Text.Trim() + "', '" + id.Text.Trim() + "')";
                MySqlCommand command = new MySqlCommand(sql, this.connexion);
                try
                {
                    int x = command.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Le contact a été envoyée avec succée", "Bravo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListeAnnonce lA = new ListeAnnonce();
                        lA.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erreur d'insertion");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Contact_Load(object sender, EventArgs e)
        {

            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location;convert zero datetime=True");
            try
            {
                this.connexion.Open();
               // MessageBox.Show("connexion avec succée");
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur de connexion");
            }
        }

        private void monProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void listeDesAnnoncesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAnnonce annonce = new ListeAnnonce();
            annonce.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

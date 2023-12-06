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
    
    public partial class page_connexion : Form
    {
        MySqlConnection connexion;
        public page_connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ********* Recuperation de email et password Admin **********
            MySqlCommand conxAdmin = new MySqlCommand("select * from admin ", this.connexion);
            conxAdmin.ExecuteNonQuery();

            MySqlDataReader readerA = conxAdmin.ExecuteReader();

            readerA.Read();
            String emailAdmin = readerA.GetString("emailA");
            String passwordAdmin = readerA.GetString("passwordA");

            readerA.Close();
            try
            {
                // ********* Test des champs **********
                if (adresseEmail.Text == "" )
                {
                    MessageBox.Show("Saisir l'adresse email ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (motpasse.Text == "")
                {
                    MessageBox.Show("Saisir le mot de passe ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!(Regex.IsMatch(adresseEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
                {
                    MessageBox.Show("Adresse email invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // ********* Test de connexion de ladmin **********
                else if (adresseEmail.Text == emailAdmin && motpasse.Text == passwordAdmin)
                {
                    Statistique stat = new Statistique();
                    stat.Show();
                    this.Hide();

                }
                // ********* Test de connexion de client **********
                else
                {
                    MySqlCommand verif = new MySqlCommand("select * from client where email='" + adresseEmail.Text + "'and password= MD5('" + motpasse.Text + "') ", connexion);
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
                    else
                    {
                        MessageBox.Show("Verifier vos informations");
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            readerA.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inscription ins = new inscription();
            ins.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ListeContact lc = new ListeContact();
            lc.Show();
            this.Hide();
        }

        private void page_connexion_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location;convert zero datetime=True");
            try
            {
                this.connexion.Open();
                //MessageBox.Show("connexion avec succée");

            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur de connexion");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

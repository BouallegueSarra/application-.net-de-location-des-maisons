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
    public partial class inscription : Form
    {
        MySqlConnection connexion;
        public inscription()
        {
            InitializeComponent();
        }

        private void inscription_Load(object sender, EventArgs e)
        {
            this.connexion = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=location");
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

        private void btn_ajoutC_Click(object sender, EventArgs e)
        {
            try
            {
                if (nom.Text == "" || prenom.Text == "" || email.Text == "" || password.Text == "" || telephone.Text == "")
                {
                    MessageBox.Show("Champ vide ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if
                    (telephone.Text.Length < 8)
                {
                    MessageBox.Show("numéro de telephone invalid", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(Regex.IsMatch(telephone.Text, @"^[0-9]+$")))
                {
                    MessageBox.Show("Veuillez saisir seulement des numéros", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(Regex.IsMatch(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
                {
                    MessageBox.Show("Adresse email invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ajoutClient = "INSERT INTO client (nom,prenom,tel,email,password) VALUES ('" + nom.Text + "','" + prenom.Text + "','" + telephone.Text + "','" + email.Text + "', MD5('" + password.Text + "'))";
                    MySqlCommand commande = new MySqlCommand(ajoutClient, connexion);
                    if (commande.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("Votre inscription a effectué avec succès ", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Profil profil = new Profil();
                        profil.nom_txt.Text = nom.Text;
                        profil.prenom_txt.Text = prenom.Text;
                        profil.email_txt.Text = email.Text;
                        profil.telf_txt.Text = telephone.Text;
                 
                        profil.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Probléme d'inscription", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK);
                connexion.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           page_connexion conx = new page_connexion();   
           conx.Show();
           this.Close();
        }

     
    }
}

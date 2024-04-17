using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionPersonnel.bddmanager;
using MySql.Data.MySqlClient;
using GestionPersonnel.Dal;
using GestionPersonnel.model;

namespace GestionPersonnel.Vue
{
    public partial class se_connecter : Form
    {
        //propriétés
        private BddManager bddmanager;
        private liste_personnel liste_Personnel;
        public string motdepasseEntre;

        /// <summary>
        /// initialisation de se connecter
        /// </summary>
        public se_connecter(BddManager bddmanager)
        {
            InitializeComponent();
            this.bddmanager = bddmanager;
            liste_Personnel = new liste_personnel(bddmanager);
        }

        private void InitConnection()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// bouton SeConnecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //le mot de passe entré est mémorisé dans la propriété motdepasseEntre
            motdepasseEntre = txt_motdepasse.Text;

            //si la fonction AccessLogin retourne vrai, l'utilisateur entre dans l'interface
            if (AccessLogin(txt_login.Text, motdepasseEntre) == true)
            {
                liste_Personnel.Show();
                this.Hide();
            }

            //sinon le message d'erreur s'affiche et l'accès lui est refusé
            else if (AccessLogin(txt_login.Text, motdepasseEntre) == false)
            {
                lbl_info.Text = "Mauvais login";
                lbl_info.Visible = true;
                txt_motdepasse.Clear();
                txt_login.Clear();
                motdepasseEntre = "";
                txt_login.Focus();
            }   
        }

        /// <summary>
        /// fonction qui vérifie le motdepasse et le login
        /// </summary>
        /// <param name="loginDonne"></param>
        /// <param name="motdepasseDonne"></param>
        /// <returns></returns>
        public bool AccessLogin(string loginDonne, string motdepasseDonne)
        { 
            //création de la requête Sql
            string stringQuery = "SELECT * FROM responsable WHERE login = @nom AND pwd = SHA2(@pwd, 256)";

            //création des propriétés
            Dictionary<string, object> LesDonnees = new Dictionary<string, object>
            {
                {"@nom", loginDonne },
                {"@pwd", motdepasseDonne}
            };

            try
            {
                //envoie de la requête qui est récupérée dans une liste
                List<Object[]> records = bddmanager.ReqSelect(stringQuery, LesDonnees);

                // Si count est supérieur à zéro, cela signifie qu'un utilisateur avec le login et le mot de passe donnés a été trouvé
                if (records.Count > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //si l'utilisateur n'entre pas dans le if, la fonction retourne false
            return false;
        }

        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void se_connecter_Load(object sender, EventArgs e)
        {;               
            lbl_info.Visible = false;
           
        }

        /// <summary>
        /// action sur la saisie du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_motdepasse_TextChanged(object sender, EventArgs e)
        {
            //remplace le texte brut par des étoiles
            if (txt_motdepasse.PasswordChar == '\0')
            {
                txt_motdepasse.PasswordChar = '*';
            }
        }
    }
}

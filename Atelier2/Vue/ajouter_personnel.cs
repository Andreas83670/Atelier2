using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnel.bddmanager;
using GestionPersonnel.model;

namespace GestionPersonnel
{
    public partial class ajouter_personnel : Form
    {
        //propriétés
        private readonly BddManager bddmanager;
        private liste_personnel FrmListePersonnel;
        /// <summary>
        /// iniatialisation de ajouter personnel
        /// </summary>
        public ajouter_personnel(BddManager bddManager, liste_personnel liste_Personnel)
        {
            InitializeComponent();
            this.bddmanager = bddManager;
            this.FrmListePersonnel = liste_Personnel;
        }

        private void grp_seConnecter_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// bouton valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_valider_Click(object sender, EventArgs e)
        {
            //le contenu rempli par l'utilisateur est stocké dans de nouvelles propriétés
            string nom = txt_nom.Text;
            string prenom = txt_prenom.Text;
            string tel = txt_tel.Text;
            string mail = txt_mail.Text;

            //l'index du combobox correspond à l'idservice
            int idservice = cb_service.SelectedIndex+1;

            //lancement de la méthode AjouterPersonnel avec les différentes propriétés
            AjouterPersonnel(nom, prenom, tel, mail, idservice);

            //mise à jour du DataGridView
            FrmListePersonnel.MajDataGrid();

            //fermeture de la fenêtre
            this.Hide();
        }

        /// <summary>
        /// méthode qui ajoute du personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idservice)
        {
            //création de la requête Sql
            string stringQuery = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES ( @nom , @prenom , @tel , @mail , @idservice )";

            //création des différentes propriétés
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@nom", nom);
            parameters.Add("@prenom", prenom);
            parameters.Add("@tel", tel);
            parameters.Add("@mail", mail);
            parameters.Add("@idservice", idservice);

            //envoie de la requête
            bddmanager.ReqUpdate(stringQuery, parameters);
      }
        /// <summary>
        /// bouton qui annule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //fermeture de la fenêtre
            this.Hide();
        }

        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouter_personnel_Load(object sender, EventArgs e)
        {
            //remplissage du combobox
            if (cb_service.Items.Count == 0)
            {
                cb_service.Items.Add("Administratif");
                cb_service.Items.Add("Médiation Culturelle");
                cb_service.Items.Add("Prêt");
            }
            

        }
    }
}

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
using MySql.Data.MySqlClient;

namespace GestionPersonnel.Vue
{
    /// <summary>
    /// classe du bouton ajouter
    /// </summary>
    public partial class ajouter_absence : Form
    {
        //propriétés
        private readonly BddManager bddmanager;
        private absences FrmAbsences;
        private Absences uneAbsence;
        
        /// <summary>
        /// initialisation de ajouter_absence
        /// </summary>
        public ajouter_absence(absences absences, BddManager bddmanager)
        {
            InitializeComponent();
            FrmAbsences = absences;
            this.bddmanager = bddmanager;
        }
        /// <summary>
        /// actions sur bouton Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_valider_Click(object sender, EventArgs e)
        {          
            //créer une liste de type Personnel
            List<Personnel> lesPersonnes = new List<Personnel>();

            //le contenu de GetPersonnel est renvoyé dans la liste
            lesPersonnes = GetPersonnel();
 
            //nouvelles propriétés
            int id;
            int idmotif = 0;
            int idabsence = 0;

            //vérifie si la liste est remplie
            if (lesPersonnes != null)
            {
                //cherche propriétés de type Personnel dans la liste
                foreach (Personnel laPersonne in lesPersonnes)
                {
                    //vérifie si le contenu du texte est le même que dans la classe Personnel en concaténant le nom et le prénom
                    if (cb_nomcomplet.Text == string.Concat(laPersonne.nom, " ", laPersonne.prenom))
                    {
                        //le contenu de GetId devient id
                        id = GetId(laPersonne.prenom, laPersonne.nom);

                        //les éléments remplis par l'utilisateur sont mémorisés
                        DateTime datedebut = date_debut.Value;
                        DateTime datefin = date_fin.Value;
                        idmotif = Convert.ToInt32(cb_motif.SelectedIndex) + 1;
                        string idAbsence = idabsence.ToString();

                        //ajout de l'absence en appelant la méthode AjouterAbsence
                        AjouterAbsence(id, datedebut, datefin, idmotif);

                        //mise à jour du DataGridView
                        FrmAbsences.MaJDataGrid();
                    }
                    else
                    {
                        lbl_infos.Text = "Veuillez saisir tous les champs";
                    }

                }
            }
            else { lbl_infos.Text = "Veuillez saisir tous les champs"; }
                
            this.Hide();           
        }
        /// <summary>
        /// méthode qui permet d'ajouter l'absence dans la Bdd
        /// </summary>
        /// <param name="IdPersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public void AjouterAbsence(int IdPersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            //création de la requête Sql
            string stringQuery = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@IdPersonnel , @datedebut , @datefin, @idmotif)";

            //création des propriétés
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@IdPersonnel", IdPersonnel);
            parameters.Add("@datedebut", datedebut);
            parameters.Add("@datefin", datefin);
            parameters.Add("@idmotif", idmotif);

            //envoie de la requête
            bddmanager.ReqUpdate(stringQuery, parameters);

        }
        /// <summary>
        /// bouton qui ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// méthode qui permet de remplir une liste de type Personnel
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetPersonnel()
        {
            //création de la requête Sql
            string stringQuery = "SELECT idpersonnel, prenom, nom, tel, mail, idservice FROM personnel";

            //envoie de la requête et récupération du contenu dans une nouvelle liste nommé résultats
            List<Object[]> resultats = bddmanager.ReqSelect(stringQuery);

            //déclaration d'une nouvelle liste
            List<Personnel> laPersonne = new List<Personnel>();

            foreach (Object[] element in resultats)
            {
                // Convertir les attributs de la ligne en types appropriés
                int idpersonnel = Convert.ToInt32(element[0]);
                string prenom = (string)element[1];
                string nom = (string)element[2];
                string tel = (string)element[3];
                string mail = (string)element[4];
                int idservice = Convert.ToInt32(element[5]);

                // Créer un nouvel objet Personnel et l'ajouter à la liste
                Personnel personnel = new Personnel(idpersonnel, nom, prenom, tel, mail, idservice);
                laPersonne.Add(personnel);
            }

            return laPersonne;
        }

        /// <summary>
        /// méthode pour obtenir l'id d'un personnel
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int GetId(string prenom, string nom)
        {
            //création de la requête Sql
            string stringQuery = "SELECT idpersonnel FROM personnel WHERE nom = @nom AND prenom = @prenom";

            //création des propriétés
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@nom", nom);
            parameters.Add("@prenom", prenom);

            //envoie de la requête récupéré dans une nouvelle liste
            List<object[]> resultats = bddmanager.ReqSelect(stringQuery, parameters);
           
            if (resultats.Count > 0)
            {
                //il y a un résultat donc l'id est mémorisé
                int Id = Convert.ToInt32(resultats[0][0]);
                return Id;
            }
            else
            {
                //la liste ne retourne aucun résultat 
                return -1; 
            }
        }
        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouter_absence_Load(object sender, EventArgs e)
        {
            //remplissage du combobox
            if (cb_motif.Items.Count == 0)
            {
                cb_motif.Items.Add("Vacances");
                cb_motif.Items.Add("Maladie");
                cb_motif.Items.Add("Motif familial");
                cb_motif.Items.Add("Congé parental");
            }           

            //nouvelle liste de type Personnel
            List<Personnel> lesPersonnes = new List<Personnel>();

            //le contenu de GetPersonnel est envoyé dans la liste
            lesPersonnes = GetPersonnel();

            //recherche du résultat de la liste
            if (cb_nomcomplet.Items.Count == 0)
            {
                foreach (Personnel resultat in lesPersonnes)
                {
                    //ajout des noms complets dans le combobox
                    cb_nomcomplet.Items.Add(string.Concat(resultat.nom, " ", resultat.prenom));
                }
            }
        }
    }

}

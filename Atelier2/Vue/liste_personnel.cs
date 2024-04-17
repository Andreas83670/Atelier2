using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnel.Vue;
using GestionPersonnel.bddmanager;
using MySql.Data.MySqlClient;
using GestionPersonnel.model;

namespace GestionPersonnel
{
    public partial class liste_personnel : Form
    {
        //propriétés
        private supprimer_personnel Form3;
        private absences FrmAbsences;
        private readonly BddManager bddmanager;
        private ajouter_personnel ajouter_personnel;
        private modifier_personnel FrmModifierPersonnel;


        /// <summary>
        /// iniatialisation de liste personnel
        /// </summary>
        public liste_personnel(BddManager bddmanager)
        {
            InitializeComponent();
            this.bddmanager = bddmanager;
            FrmAbsences = new absences(bddmanager);
            ajouter_personnel = new ajouter_personnel(bddmanager, this);
            Form3 = new supprimer_personnel(bddmanager, this);
            FrmModifierPersonnel = new modifier_personnel(bddmanager, this);
        } 

        private void grp_seConnecter_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_personnel.Rows)
            {
                row.Selected = true;
            }
        }

        /// <summary>
        /// méthode GetPersonnel qui renvoie une liste de type Personnel
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetPersonnel()
        {
            //création de la requête Sql
            string stringQuery = "SELECT idpersonnel, prenom, nom, tel, mail, idservice FROM personnel";

            //envoie de la requête qui est récupérée dans une liste
            List<Object[]> resultats = bddmanager.ReqSelect(stringQuery);

            //déclaration d'une nouvelle liste
            List<Personnel> laPersonne = new List<Personnel>();

            foreach (Object[] element in resultats)
            {
                // conversion des attributs de la ligne en types appropriés
                int idpersonnel = Convert.ToInt32(element[0]);
                string prenom = (string)element[1];
                string nom = (string)element[2];
                string tel = (string)element[3];
                string mail = (string)element[4];
                int idservice = Convert.ToInt32(element[5]);

                // création d'un nouvel objet Personnel et ajout à la liste
                Personnel personnel = new Personnel(idpersonnel, nom, prenom, tel, mail, idservice);
                laPersonne.Add(personnel);
            }

            return laPersonne;
        }

        /// <summary>
        /// méthode qui permet de retourne le nom du service selon son id
        /// </summary>
        /// <param name="idservice"></param>
        /// <returns></returns>
        public string GetService(int idservice)
        {
            //dictionnaire qui explique à quoi correspond l'id
            Dictionary<int, string> service = new Dictionary<int, string>
            {
                {1, "Administratif" },
                {2, "Médiation culturelle" },
                {3, "Prêt" }
            };

            //si l'id qui est envoyé à la méthode correspond au dictionnaire alors cela renvoie son service de type string
            if (service.ContainsKey(idservice))
            {
                return service[idservice];

            //sinon renvoie service inconnu
            }else
            {
                return "Service inconnu";
            }
        }

        /// <summary>
        /// méthode qui met à jour le DataGridView
        /// </summary>
        public void MajDataGrid()
        {
            //appel de la méthode GetPersonnel pour remplir une liste de type Personnel
            List<Personnel> people = GetPersonnel();

            //création du tableau
            DataTable dt = new DataTable();

            //création des différentes colonnes
            dt.Columns.Add("Prénom", typeof(string));
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Téléphone", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Service", typeof(string));
            dt.Columns.Add("Id Personnel", typeof(int));

            //recherche puis ajoute à chaque colonne, les différents contenus correspondants
            foreach (Personnel personne in people)
            {
                dt.Rows.Add(personne.prenom, personne.nom, personne.tel, personne.mail, GetService(personne.idservice), personne.idpersonnel);
            }

            //envoie le tableau au DataGridView
            dgv_personnel.DataSource = dt;

            //rend invisible la colonne IdPersonnel
            dgv_personnel.Columns["Id Personnel"].Visible = false;
            
            //vérifie si le DataGridView dispose d'au moins une ligne sinon il désactive les boutons : modifier, supprimer et tout sélectionner
            if (dgv_personnel.SelectedRows.Count > 0)
            {
                btn_modifier.Enabled = true;
                btn_supprimer.Enabled = true;
                btn_toutSélectionner.Enabled = true;
            }
            else
            {
                btn_modifier.Enabled = false;
                btn_supprimer.Enabled = false;
                btn_toutSélectionner.Enabled = false;
            }
        }

        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void liste_personnel_Load(object sender, EventArgs e)
        {     
            //permet de sélectionner la ligne entière
            dgv_personnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //appel des méthodes
            GetPersonnel();       
            MajDataGrid();                
        }

        /// <summary>
        /// permet de récupérer le contenu de la colonne IdPersonnel pour le concataner si il y en plusieurs
        /// </summary>
        /// <returns></returns>
        public string GetIdsPersonnel()
        {
            // chaîne pour concaténer les Id Personnel
            string concat = "";

            //recherche dans les lignes sélectionnées du DataGridView
            foreach (DataGridViewRow row in dgv_personnel.SelectedRows)
            {
                //si la ligne sélectionnée contient une valeur
                if (row.Cells["Id Personnel"].Value != null)
                {
                    //la valeur de la case dans la colonne Id Personnel est envoyé en type idPersonnel
                    int idPersonnel = Convert.ToInt32(row.Cells["Id Personnel"].Value);

                    // concatène l'ID d'absence avec une virgule avec l'id précédent
                    concat = string.Concat(concat, idPersonnel, ","); 
                }
            }
            //suppression de la virgule finale si nécessaire (si il y a eu plusieurs id)
            if (!string.IsNullOrEmpty(concat))
            {
                concat = concat.Remove(concat.Length - 1);
            }
            return concat;
        }

        /// <summary>
        /// bouton nouveau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            //lance la fenêtre ajouter_personnel
            ajouter_personnel.ShowDialog();  
        }

        /// <summary>
        /// bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            //lance la fenêtre qui supprime un personnel
            Form3.ShowDialog();
        }

        /// <summary>
        /// bouton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            //lance la fenêtre pour modifier le personnel
            FrmModifierPersonnel.ShowDialog();
        }

        /// <summary>
        /// bouton gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gestionDesAbsences_Click(object sender, EventArgs e)
        {
            //lance la fen$etre de gestion des absences
            FrmAbsences.ShowDialog();
        }

        private void lst_personnel_prenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

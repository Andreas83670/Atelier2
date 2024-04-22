using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnel.model;
using MySql.Data.MySqlClient;
using GestionPersonnel.Vue;
using GestionPersonnel.bddmanager;

namespace GestionPersonnel.Vue
{
    /// <summary>
    /// classe de la forme Absences
    /// </summary>
    public partial class absences : Form
    {
        //propriétés
        private modifier_absence modifAbsence;
        private supprimer_absence suprAbsence;
        private readonly BddManager bddmanager;
        private ajouter_absence FormAjouterAbsence;
        private confirmation_modifier_absence FormConfirmAbsence;
        private Absences uneabsence;
        private supprimer_absence SuprAbsence;

        /// <summary>
        /// initialisation d'absences
        /// </summary>
        public absences(BddManager bddmanager)
        {
            InitializeComponent();
            this.bddmanager = bddmanager;
            modifAbsence = new modifier_absence(this, bddmanager);
            FormAjouterAbsence = new ajouter_absence(this, bddmanager);
            dgv_absences.SelectionChanged += dgv_absences_SelectionChanged;
            SuprAbsence = new supprimer_absence(bddmanager, this);
        }

        /// <summary>
        /// action sur le bouton modifer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_absences.SelectedRows.Count > 0)
                {
                    int rowIndex = dgv_absences.SelectedRows[0].Index;

                    string IdAbsence = dgv_absences.SelectedRows[rowIndex].Cells["Id absence"].Value.ToString();
                    DateTime datedebut = Convert.ToDateTime(dgv_absences.SelectedRows[rowIndex].Cells["Date de début"].Value.ToString());
                    DateTime datefin = Convert.ToDateTime(dgv_absences.SelectedRows[rowIndex].Cells["Date de fin"].Value.ToString());

                    //recherche de l'idservice

                    string stringQuery = "SELECT idmotif FROM absence WHERE idabsence = @idAbsence";

                    // Crée un dictionnaire pour stocker les paramètres de la requête
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@idAbsence", IdAbsence);


                    // Exécutez la requête SQL pour obtenir l'ID du service
                    List<object[]> resultats = bddmanager.ReqSelect(stringQuery, parameters);

                    // Vérifiez si des résultats ont été retournés
                    if (resultats.Count > 0)
                    {
                        // Récupérez l'ID du service à partir du premier résultat
                        int idMotif = Convert.ToInt32(resultats[0][0]);

                        modifAbsence.RemplirLesChamps(datedebut, datefin, idMotif);
                    }

                }
                else
                {
                    // Gérer le cas où aucune ligne n'est sélectionnée
                    MessageBox.Show("Aucune ligne sélectionnée.");
                }
            }catch (Exception error)
            {
                
            }

            modifAbsence.ShowDialog();        
        }

        /// <summary>
        /// action sur le bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            //ouvre la fenêtre de suppression d'une ou des absences
            suprAbsence = new supprimer_absence(bddmanager, this);
            suprAbsence.ShowDialog(); 
        }

        /// <summary>
        /// bouton ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //ouvre la fenêtre d'ajout d'une absence
            FormAjouterAbsence.ShowDialog();
        }

        /// <summary>
        /// méthode qui permet d'obtenir le motif d'une absence en texte grâce à son id
        /// </summary>
        /// <param name="idmotif"></param>
        /// <returns></returns>
        public string GetMotif(int idmotif)
        {
            //création d'un dictionnaire des motifs
            Dictionary<int, string> motif = new Dictionary<int, string>
            {
                {1, "Vacances" },
                {2, "Maladie" },
                {3, "Motif familiale" },
                {4, "Congé parental" },
            };

            //si le dictionnaire contient l'idmotif en question, le motif est retourné
            if (motif.ContainsKey(idmotif))
            {
                return motif[idmotif];

            }else
            {
                return "Motif inconnu";
            }
        }

        /// <summary>
        /// méthode qui permet d'obtenir le nom complet : prenom + nom
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <returns></returns>
        public string GetNomComplet (int idpersonnel)
        {
            //création de la requête Sql
            string stringQuery = "SELECT prenom, nom FROM personnel WHERE idpersonnel = @idpersonnel";

            //création des propriétés
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);

            //récupération du résultat de la requête dans une liste
            List<Object[]> resultats = bddmanager.ReqSelect(stringQuery, parameters);

            //si la liste contient un élément, le prénom et le nom est mémorisé
            if (resultats.Count > 0)
            {
                string prenom = Convert.ToString(resultats[0][0]);
                string nom = Convert.ToString(resultats[0][1]);

                //concaténation du prénom et du nom pour obtenir le nom complet
                string nomComplet = prenom + " " + nom;

                //retourne le nom complet
                return nomComplet;
            }
            else
            {
                //retourne nom inconnu
                return "Nom inconnu";
            }

        }

        /// <summary>
        /// méthode qui permet obtenir les absences
        /// </summary>
        /// <returns></returns>
        public List<Absences> GetAbsence()
        {
            //création de la requête Sql
            string stringQuery = "SELECT * FROM absence";

            //récupération du résultat de la requête dans une liste
            List<Object[]> resultats = bddmanager.ReqSelect(stringQuery);

            //déclaration d'une nouvelle liste
            List<Absences> lesAbsences = new List<Absences>();

            foreach (Object[] element in resultats)
            {
                int idpersonnel = Convert.ToInt32(element[0]);
                DateTime datedebut = (DateTime)element[1];
                DateTime datefin = (DateTime)element[2];
                int idmotif = Convert.ToInt32(element[3]);
                string idabsence = (element[4]).ToString();

                //création d'une nouvelle absence de type Absences
                Absences uneAbsence = new Absences(datedebut, datefin, idmotif, idpersonnel, idabsence);

                //ajout dans Absences
                lesAbsences.Add(uneAbsence);
            }

            return lesAbsences;
        }

        /// <summary>
        /// méthode qui permet d'obtenir toutes les idabsences
        /// </summary>
        /// <returns></returns>
        public string GetIdsAbsences()
        {
            string concat = ""; //chaîne pour concaténer les IDs d'absence

            foreach (DataGridViewRow row in dgv_absences.SelectedRows)
            {
                if (row.Cells["Id absence"].Value != null)
                {
                    int idAbsence = Convert.ToInt32(row.Cells["Id absence"].Value);
                    concat = string.Concat(concat, idAbsence, ","); // Concatène l'ID d'absence avec une virgule
                }
            }

            //supprimer la virgule finale si nécessaire
            if (!string.IsNullOrEmpty(concat))
            {
                concat = concat.Remove(concat.Length - 1);
            }

            return concat;
        }

        /// <summary>
        /// méthode pour mettre à jour le DataGridView
        /// </summary>
        public void MaJDataGrid()
        {
            //affichage dans le DataGridReview
            List<Absences> absenteisme = GetAbsence();

            //création d'un tableau
            DataTable dt = new DataTable();

            //création des colonnes
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Personnel", typeof(string));
            dt.Columns.Add("Date de début", typeof(string));
            dt.Columns.Add("Date de fin", typeof(string));
            dt.Columns.Add("Motif de l'absence", typeof(string));
            dt.Columns.Add("Id absence", typeof(string));

            //recherche un objet de type Absences dans la liste
            foreach (Absences absence in absenteisme)
            {
                //récupération de GetMotif dans motif
                string motif = GetMotif(absence.idmotif);

                //récupération des noms complets
                string nomcomplet = GetNomComplet(absence.idpersonnel);

                //ajout des différents contenus ligne par ligne
                dt.Rows.Add(absence.idpersonnel, nomcomplet, absence.datedebut, absence.datefin, motif, absence.idabsence);

            }

            //remplissage du DataGridView
            dgv_absences.DataSource = dt;

            //la première colonne Id est invisible ainsi que id absence
            dgv_absences.Columns[0].Visible = false;
            dgv_absences.Columns["Id absence"].Visible = false;

            //si une ligne est sélectionnée les boutons sont activés
            if (dgv_absences.SelectedRows.Count > 0)
            {
                btn_modifier.Enabled = true;
                btn_supprimer.Enabled = true;
                btn_toutSélectionner.Enabled = true;
            }

            //si rien n'est sélectionné, les boutons sont désactivés
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
        private void absences_Load(object sender, EventArgs e)
        {
            //permet de sélectionner une ligne entière
            dgv_absences.SelectionMode = DataGridViewSelectionMode.FullRowSelect;           
         
            //mise à jour du DataGridView
            MaJDataGrid();
           
        }

        private void lst_absences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_absences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgv_absences_SelectionChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// bouton qui permet de Tout Sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_toutSélectionner_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_absences.Rows)
            {
                row.Selected = true;
            }
        }

        
    }
}

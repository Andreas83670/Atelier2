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
using GestionPersonnel.Vue;
using System.Text.RegularExpressions;

namespace GestionPersonnel.Vue
{   

    public partial class modifier_absence : Form
    {
        //propriétés
        private readonly BddManager bddmanager;
        private absences FrmAbsences;
        private confirmation_modifier_absence confirmAbsence;
        private Absences uneAbsence;

        /// <summary>
        /// initialisation de modifier_absence
        /// </summary>
        /// <param name="frmAbsences"></param>
        /// <param name="bddManager"></param>
        public modifier_absence(absences frmAbsences, BddManager bddManager)
        {
            InitializeComponent();
            FrmAbsences = frmAbsences;
            this.bddmanager = bddManager;
            confirmAbsence = new confirmation_modifier_absence(bddManager, this, uneAbsence);
        }

        /// <summary>
        /// méthode pour remplir les champs
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public void RemplirLesChamps(DateTime datedebut, DateTime datefin, int idmotif)
        {
            if (cb_motif.Items.Count == 0)
            {
                //rempli les combobox
                cb_motif.Items.Add("Vacances");
                cb_motif.Items.Add("Maladie");
                cb_motif.Items.Add("Motif familial");
                cb_motif.Items.Add("Congé parental");
            }

            dateTimePicker1.Value = datedebut;
            dateTimePicker2.Value = datefin;
            cb_motif.SelectedIndex = idmotif - 1;
        }

        /// <summary>
        /// load de la fenêtre modifier_absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifier_absence_Load(object sender, EventArgs e)
        {
            if (cb_motif.Items.Count == 0)
            {
                //rempli les combobox
                cb_motif.Items.Add("Vacances");
                cb_motif.Items.Add("Maladie");
                cb_motif.Items.Add("Motif familial");
                cb_motif.Items.Add("Congé parental");
            }
        }      
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// méthode qui modifie les absences
        /// </summary>
        /// <param name="absences"></param>
        public void ModifAbsences(Absences absences)
        {
            try
            {
                //méthode pour remplacer les chiffres uniquement dans un chaine de type string en int
                string idabsence = absences.idabsence;
                string pattern = @"\d+";
                string result = Regex.Replace(idabsence, pattern, match => Convert.ToInt32(match.Value).ToString());

                //envoie de la requête Sql
                string stringQuery = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idabsence IN (" + result + ")";

                //ajout des paramètres à la requête
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absences.datedebut); // Nouvelle date de début
                parameters.Add("@datefin", absences.datefin); // Ancienne date de début
                parameters.Add("@idmotif", absences.idmotif); // ID du motif

                //exécute la requête
                bddmanager.ReqUpdate(stringQuery, parameters);

            }
            catch (Exception e)
            {
                MessageBox.Show("La  requête (modifier Absence) a échoué " + e.Message);
            }

        }
        /// <summary>
        /// valide les changements renseigné dans les différents libellés
        /// </summary>
        public void Confirmation()
        {
            try
            {
                //propriétés
                int idpersonnel = 1;
                DateTime datedebut = dateTimePicker1.Value;
                DateTime datefin = dateTimePicker2.Value;          
                int idmotif = cb_motif.SelectedIndex;
                string idabsence = FrmAbsences.GetIdsAbsences();
            
                //création propriété de type Absence
                Absences absence = new Absences(datedebut, datefin, idmotif + 1, idpersonnel, idabsence);

                //envoie à la méthode ModifAbsence
                ModifAbsences(absence);         

                //met à jour le DataGridView
                FrmAbsences.MaJDataGrid();
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite");
            }

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try 
            {
                //boucle tant que l'utilisateur n'a pas confirmé ou annuler via la fenêtre de confirmation
                while (true)
                {
                    //ouverture de la fenêtre de confirmation
                    confirmAbsence.ShowDialog();

                    if (confirmAbsence.Confirmed == true)
                    {
                        //lance la méthode Confirmation et sort de la boucle
                        Confirmation();
                        break;
                    }
                    else if (confirmAbsence.Annuler == true)
                    {      
                        //ne lance rien et sort de la boucle
                        break;
                    }
                }                
            }
            catch
            {
                MessageBox.Show("confirmAbsence est null");
            }
        }

        private void cb_motif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// bouton qui ferme la demande de modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

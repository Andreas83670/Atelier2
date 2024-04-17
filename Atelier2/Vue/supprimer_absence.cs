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
using System.Text.RegularExpressions;

namespace GestionPersonnel.Vue
{
    /// <summary>
    /// classe supprimer absence
    /// </summary>
    public partial class supprimer_absence : Form
    {
        //propriétés
        private absences FrmAbsences;
        private BddManager bddmanager;

        /// <summary>
        /// initialisation de supprimer absence
        /// </summary>
        public supprimer_absence(BddManager bddmanager, absences FrmAbsence)
        {
            InitializeComponent();
            this.FrmAbsences = FrmAbsence;
            this.bddmanager = bddmanager;
        }

        /// <summary>
        /// méthode qui supprime une ou des absences
        /// </summary>
        /// <param name="idabsence"></param>
        public void SupprimerAbsence (string idabsence)
        {
            try
            {
                //méthode pour remplacer les chiffres uniquement dans une chaine de type string en int
                string pattern = @"\d+";
                string result = Regex.Replace(idabsence, pattern, match => Convert.ToInt32(match.Value).ToString());

                //création de la requête Sql
                string stringQuery = "DELETE FROM absence WHERE idabsence IN ( " + result + " )";

                //exécution de la requête
                bddmanager.ReqUpdate(stringQuery);

            }
            catch (Exception e)
            {
                MessageBox.Show("La requête (Supprimer absence) a échoué " + e.Message);
            }
        }

        /// <summary>
        /// bouton valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_valider_Click(object sender, EventArgs e)
        {
            //récupère les ids des absences
            string idabsence = FrmAbsences.GetIdsAbsences();

            //appel de la méthode SupprimerAbsence avec idabsence en paramètre
            SupprimerAbsence(idabsence);

            //mise à jour du DataGridView
            FrmAbsences.MaJDataGrid();

            //fermeture de la fenêtre
            this.Close();
        }

        /// <summary>
        /// bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //fermeture de la fenêtre
            this.Close();
        }

        private void supprimer_absence_Load(object sender, EventArgs e)
        {

        }
    }
}

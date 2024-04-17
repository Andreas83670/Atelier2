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
using System.Text.RegularExpressions;
using GestionPersonnel.Vue;
using GestionPersonnel.model;

namespace GestionPersonnel.Vue
{
    public partial class supprimer_personnel : Form
    {
        //propriétés
        liste_personnel FrmPersonnel;
        BddManager bddmanager;
        
        /// <summary>
        /// iniatialisation de supprimer personnel
        /// </summary>
        public supprimer_personnel(BddManager bddmanager, liste_personnel FrmPersonnel)
        {
            InitializeComponent();
            this.bddmanager = bddmanager;
            this.FrmPersonnel = FrmPersonnel;           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_personnel_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// bouton valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_valider_Click(object sender, EventArgs e)
        {
            //appel de la méthode SUpprimerPersonne avec en paramètre la méthode GetIdsPersonnel
            SupprimerPersonnel(FrmPersonnel.GetIdsPersonnel());

            //mise à jour du DataGridView
            FrmPersonnel.MajDataGrid();

            //fermeture de la fenêtre
            this.Close();
        }

        /// <summary>
        /// méthode qui supprime du personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void SupprimerPersonnel(string idpersonnel)
        {
            try
            {
                //méthode pour remplacer les chiffres uniquement dans une chaine de type string en int
                string pattern = @"\d+";
                string result = Regex.Replace(idpersonnel, pattern, match => Convert.ToInt32(match.Value).ToString());

                // envoie de la requête Sql
                string stringQuery = "DELETE FROM personnel WHERE idpersonnel IN ( " + result + " )";

                //exécution de la requête
                bddmanager.ReqUpdate(stringQuery);

            }
            catch (Exception e)
            {
                MessageBox.Show("La requête (Supprimer personnel) a échoué " + e.Message);
            }

        }

        /// <summary>
        /// bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //ferme la fenêtre
            this.Hide();
        }
    }
}

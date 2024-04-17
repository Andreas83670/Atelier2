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
using GestionPersonnel.bddmanager;
using GestionPersonnel.model;

namespace GestionPersonnel.Vue
{
    /// <summary>
    /// classe de confirmation modifier absence
    /// </summary>
    public partial class confirmation_modifier_absence : Form
    {
        //propriétés
        private readonly BddManager bddmanager;
        private readonly modifier_absence ModifAbsence;
        private readonly absences absence;
        private Absences uneAbsence;

        /// <summary>
        /// Fonction Confirmed
        /// </summary>
        public bool Confirmed { get; private set; }

        /// <summary>
        /// Fonction Annuler
        /// </summary>
        public bool Annuler { get; private set; }

        /// <summary>
        /// initialisation de modifier absence
        /// </summary>
        public confirmation_modifier_absence(BddManager bddmanager, modifier_absence FrmAbsence, Absences uneAbsence)
        {
            InitializeComponent();
            this.bddmanager = bddmanager;
            ModifAbsence = FrmAbsence;
            this.uneAbsence = uneAbsence;
            
        }

        /// <summary>
        /// bouton Confirmer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            //active la fonction Confirmed et ferme la fenêtre
            Confirmed = true;           
            this.Hide();

        }

        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmation_modifier_absence_Load(object sender, EventArgs e)
        {
            //désactive de base les fonctions
            Confirmed = false;
            Annuler = false;
        }

        /// <summary>
        /// bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //active la fonction Annuler et ferme la fenêtre
            Annuler = true;
            this.Hide();
        }

        /// <summary>
        /// fermeture de la fenêtre en cliquant sur la croix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmation_modifier_absence_FormClosed(object sender, FormClosedEventArgs e)
        {
            //la fonction Annuler est activée
            Annuler = true;
        }
    }
}

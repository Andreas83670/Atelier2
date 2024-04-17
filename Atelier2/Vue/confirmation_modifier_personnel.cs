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
using GestionPersonnel.model;

namespace GestionPersonnel.Vue
{
    public partial class confirmation_modifier_personnel : Form
    {
        //propriétés
        private BddManager bddManager;
        private modifier_personnel FrmModifierPersonnel;

        /// <summary>
        /// fonction Confirmed
        /// </summary>
        public bool Confirmed2 { get; set; }

        /// <summary>
        /// fonction Annuler
        /// </summary>
        public bool Annuler2 { get; set; }

        /// <summary>
        /// iniatialisation de confirmation modifier personnel
        /// </summary>
        public confirmation_modifier_personnel(BddManager bddmanager, modifier_personnel FrmModifier)
        {
            InitializeComponent();
            this.bddManager = bddmanager;
            FrmModifierPersonnel = FrmModifier;

        }
        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmation_modifier_personnel_Load(object sender, EventArgs e)
        {
            //désactive les fonctions
            Confirmed2 = false;
            Annuler2 = false;
        }

        /// <summary>
        /// bouton qui valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click_1(object sender, EventArgs e)
        {
            //active la fonction Confirmed et ferme la fenêtre
            Confirmed2 = true;
            this.Close();
        }

        /// <summary>
        /// bouton qui annule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click_1(object sender, EventArgs e)
        {
            //active la fonction Annuler et ferme la fenêtre
            Annuler2 = true;
            this.Close();
        }

        /// <summary>
        /// action sur la fermeture de la fenêtre en appuyant sur la croix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmation_modifier_personnel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //la fonction annuler s'active
            Annuler2 = true;
        }
    }
}

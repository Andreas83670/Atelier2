using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2.Vue
{
    /// <summary>
    /// classe de la forme Absences
    /// </summary>
    public partial class absences : Form
    {
        /// <summary>
        /// propriété des formes
        /// </summary>
        private modifier_absence modifAbsence = new modifier_absence();
        private supprimer_absence suprAbsence = new supprimer_absence();
        /// <summary>
        /// initialisation d'absences
        /// </summary>
        public absences()
        {
            InitializeComponent();
        }
        /// <summary>
        /// action sur le bouton modifer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            modifAbsence.Show();
        }
        /// <summary>
        /// action sur le bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            suprAbsence.Show();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

        }

        private void absences_Load(object sender, EventArgs e)
        {

        }
    }
}

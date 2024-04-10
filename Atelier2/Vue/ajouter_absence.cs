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
    /// classe du bouton ajouter
    /// </summary>
    public partial class ajouter_absence : Form
    {
        /// <summary>
        /// initialisation de ajouter absence
        /// </summary>
        public ajouter_absence()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ajouter_absence_Load(object sender, EventArgs e)
        {

        }
    }
}

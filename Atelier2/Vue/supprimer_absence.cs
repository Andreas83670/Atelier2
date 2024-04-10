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
    /// classe supprimer absence
    /// </summary>
    public partial class supprimer_absence : Form
    {
        /// <summary>
        /// initialisation de supprimer absence
        /// </summary>
        public supprimer_absence()
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

        private void supprimer_absence_Load(object sender, EventArgs e)
        {

        }
    }
}

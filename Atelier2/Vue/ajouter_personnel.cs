using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2
{
    public partial class ajouter_personnel : Form
    {
        /// <summary>
        /// iniatialisation de ajouter personnel
        /// </summary>
        public ajouter_personnel()
        {
            InitializeComponent();
        }

        private void grp_seConnecter_Enter(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ajouter_personnel_Load(object sender, EventArgs e)
        {

        }
    }
}

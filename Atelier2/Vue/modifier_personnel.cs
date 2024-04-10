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
    public partial class modifier_personnel : Form
    {
        /// <summary>
        /// initialisation de modifier personnel
        /// </summary>
        public modifier_personnel()
        {
            InitializeComponent();
        }

        private void grp_seConnecter_Enter(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

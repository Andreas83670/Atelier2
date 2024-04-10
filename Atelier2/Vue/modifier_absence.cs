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
    /// classe de modifer absence
    /// </summary>
    public partial class modifier_absence : Form
    {
        /// <summary>
        /// initialisation de modifier absence
        /// </summary>
        public modifier_absence()
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
    }
}

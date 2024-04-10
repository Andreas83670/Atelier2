using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atelier2.Vue;
using Atelier2.bddmanager;

namespace Atelier2
{
    public partial class liste_personnel : Form
    {
        private ajouter_personnel ajouter_personnel = new ajouter_personnel();
        private supprimer_personnel Form3 = new supprimer_personnel();
        private modifier_absence Form4 = new modifier_absence();
        private absences lesAbsences = new absences();

        /// <summary>
        /// iniatialisation de liste personnel
        /// </summary>
        public liste_personnel()
        {
            InitializeComponent();
        }

        private void grp_seConnecter_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void liste_personnel_Load(object sender, EventArgs e)
        {
            
    }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            ajouter_personnel.Show();
            
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Form3.Show();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Form4.Show();
        }

        private void btn_gestionDesAbsences_Click(object sender, EventArgs e)
        {
            lesAbsences.Show();
        }
    }
}

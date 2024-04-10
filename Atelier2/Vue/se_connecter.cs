using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Atelier2.bddmanager;
using MySql.Data.MySqlClient;
using Atelier2.Dal;


namespace Atelier2.Vue
{
    public partial class se_connecter : Form

    {
        private liste_personnel liste_Personnel = new liste_personnel();
        /// <summary>
        /// initialisation de se connecter
        /// </summary>
        public se_connecter()
        {
            InitializeComponent();

        }

        private void InitConnection()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

                



            liste_Personnel.Show();
            this.Hide();
            
            
        }
    }
}

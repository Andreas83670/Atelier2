using GestionPersonnel.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnel.bddmanager;
using MySql.Data.MySqlClient;

namespace GestionPersonnel
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chaîne de connexion à la base de données
            string connectionString = "server=localhost;user id=root;database=personnel;allowuservariables=True";

            // Créer une instance de BddManager avec la chaîne de connexion
            BddManager bddmanager = BddManager.GetInstance(connectionString);

            // Passer l'instance de BddManager à la fenêtre de connexion (se_connecter)
            Application.Run(new se_connecter(bddmanager));
        }
    }
}

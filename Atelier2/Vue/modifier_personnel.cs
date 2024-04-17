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
using System.Text.RegularExpressions;

namespace GestionPersonnel.Vue
{
    public partial class modifier_personnel : Form
    {
        private confirmation_modifier_personnel FrmConfirmer;
        private BddManager bddManager;
        private liste_personnel FrmListePersonnel;
        /// <summary>
        /// initialisation de modifier personnel
        /// </summary>
        public modifier_personnel(BddManager bddmanager, liste_personnel FrmListe)
        {
            InitializeComponent();
            this.bddManager = bddmanager;
            this.FrmListePersonnel = FrmListe;
            FrmConfirmer = new confirmation_modifier_personnel(bddManager, this);
        }

        private void grp_seConnecter_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// méthode qui permet de lancer la modification du personnel
        /// </summary>
        public void Confirmation()
        {
            //propriétés
            int idpersonnel = 1;
            string nom = txt_nom.Text;
            string prenom = txt_prenom.Text;
            string tel = txt_tel.Text;
            string mail = txt_mail.Text;
            int idservice = cb_service.SelectedIndex + 1;

            //création d'une classe de type Personnel
            Personnel lesPersonnels = new Personnel(idpersonnel, nom, prenom, tel, mail, idservice);

            //appel de la méthode ModifPersonnel avec le contenu de lesPersonnels
            ModifPersonnel(lesPersonnels);

            //mise à jour du DataGridView
            FrmListePersonnel.MajDataGrid();
        }
        /// <summary>
        /// bouton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click(object sender, EventArgs e)
        {          
            try
            {
                while (true)
                {
                    //ouvre la fenêtre de confirmation
                    FrmConfirmer.ShowDialog();

                    //si la fonction Confirmed2 est confirmée, lancement de la méthode Confirmation
                    if (FrmConfirmer.Confirmed2 == true)
                    {
                        Confirmation();    
                        //sort de la boucle
                        break;
                    }

                    //sinon, rien ne se passe
                    else if (FrmConfirmer.Annuler2 == true)
                    {
                        //sort de la boucle
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("confirmPersonnel est null");
            }
            
        }

        /// <summary>
        /// bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //ferme la fenêtre
            this.Hide();
        }

        /// <summary>
        /// méthode qui permet de modifier le personnel sélectionné
        /// </summary>
        /// <param name="lesPersonnes"></param>
        public void ModifPersonnel(Personnel lesPersonnes)
        {
            try
            {//méthode pour remplacer les chiffres uniquement dans un chaine de type string en int
                string idpersonnel = FrmListePersonnel.GetIdsPersonnel();
                string pattern = @"\d+";
                string result = Regex.Replace(idpersonnel, pattern, match => Convert.ToInt32(match.Value).ToString());

                //création de la requête Sql
                string stringQuery = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel IN (" + result + ")";

                //création des propriétés
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@nom", lesPersonnes.nom },
                    {"prenom", lesPersonnes.prenom },
                    {"tel", lesPersonnes.tel },
                    {"@mail", lesPersonnes.mail },
                    {"idservice", lesPersonnes.idservice },
                };

                //envoie de la requête Sql
                bddManager.ReqUpdate(stringQuery, parameters);

            } catch (Exception e)
            {
                MessageBox.Show("Erreur");
            }
        }

        /// <summary>
        /// load de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifier_personnel_Load(object sender, EventArgs e)
        {
            //rempli le combobox
            cb_service.Items.Add("Administratif");
            cb_service.Items.Add("Médiation culturelle");
            cb_service.Items.Add("Prêt");
        }
        private void modifier_personnel_FormClose(object sender, EventArgs e)
        {
            

        }
    }
}

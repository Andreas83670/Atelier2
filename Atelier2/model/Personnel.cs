using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnel.model
{
    /// <summary>
    /// classe Personnel
    /// </summary>
    public class Personnel
    {

        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
        }

        public int idpersonnel { get; }
        public string nom { get ; }
        public string prenom { get; }
        public string tel { get ; }
        public string mail { get; }
        public int idservice { get; }
    }
}

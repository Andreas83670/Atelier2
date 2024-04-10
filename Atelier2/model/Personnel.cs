using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2.model
{
    /// <summary>
    /// classe Personnel
    /// </summary>
    class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private int tel;
        private string mail;
        private int idservice;

        public Personnel(int idpersonnel, string nom, string prenom, int tel, string mail, int idservice)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
        }

        public int Idpersonnel { get; }
        public string Nom { get ; }
        public string Prenom { get; }
        public int Tel { get ; }
        public string Mail { get; }
        public int Idservice { get; }
    }
}

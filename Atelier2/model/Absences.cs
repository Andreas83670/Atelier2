using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnel.model
{
    public class Absences
    {
        public Absences(DateTime datedebut, DateTime datefin, int idmotif, int idpersonnel, string idabsence)
        { 
        
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
            this.idabsence = idabsence;
        }

        public int idpersonnel { get; set; }
        public DateTime datedebut { get; set; }
        public DateTime datefin { get; set; }
        public int idmotif { get; set; }      
        public string idabsence { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnel.model
{
    public class Responsable
    {
        private string login;
        private string pwd;

        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public string Login { get; }
        public string Pwd { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventarioSP.Pojos
{
    class clsUsuario
    {
        private string pid;
        private string pnombre;
        private string ppassword;

        public string nombre
        {
            get { return pnombre; }
            set { pnombre = value; }

        }

        public string id
        {
            get { return pid; }
            set { pid = value; }
        }

        public string password
        {
            get { return ppassword; }
            set { ppassword = value; }
        }
    }
}

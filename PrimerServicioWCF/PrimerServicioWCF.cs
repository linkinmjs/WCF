using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerServicioWCF
{
    public class PrimerServicioWCF : IPrimerServicioWCF
    {
        public string ObtenerMensaje(string name) 
        {
            return "Hola desde DotNetUy " + name + "!";
        }
    }
}

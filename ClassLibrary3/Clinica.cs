using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Clinica
    {
        public int nro_clinica { get; set; }
        public string direccion { get; set; }
        public Ciudad ciudad { get; set; }
        public string telefono { get; set; }

        public string ObtenerClinica()
        {
            return String.Format("Clinica: {0}, Dirección:  {1}, Ciudad:  {2}, Telefono: {3} ", this.nro_clinica, this.direccion, this.ciudad.nro_ciudad, this.telefono);
        }

    }
}

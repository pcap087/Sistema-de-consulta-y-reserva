using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ciudad
    {
        public int nro_ciudad { get; set; }
        public string descripcion { get; set; }

        public string ObtenerCiudad()
        {

            return String.Format("El numero de ciudad {0}, corresponde a: {1 }", this.nro_ciudad, this.descripcion);
        }
    }

}

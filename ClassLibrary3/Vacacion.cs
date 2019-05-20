using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vacacion
    {
        public int nro_vacacion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public Medico medico { get; set; }

       
    }
}

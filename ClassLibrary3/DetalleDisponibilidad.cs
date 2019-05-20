using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DetalleDisponibilidad
    {
        public Medico medico { get; set; }
        public Turno turno { get; set; }
        public string fecha { get; set; }
        public int cantidad_max_paciente { get; set; }

       
    }

    
}

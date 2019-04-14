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

        public string ObtenerDisponibilidad()
        {
            return String.Format("El medico {0}, está disponible en el turno: {1}, y la fecha:  {2} , y puede atender hasta {3} pacientes ", this.medico.ObtenerPresentacionPersonal(), this.turno, this.fecha, this.cantidad_max_paciente);
        }
    }

    
}

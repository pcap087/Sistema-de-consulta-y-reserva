using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cita
    {
        public int nro_cita { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public Turno turno { get; set; }
        public string fecha { get; set; }
        public Consultorio consultorio { get; set; }
        public Reserva reserva { get; set; }
        public Funcionario funcionario { get; set; }

        public string ObtenerDetalleTurno()
        {
            return this.nro_cita  + " " + this.paciente + " " + this.medico +" "+ this.fecha;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Turno
    {
        public int nro_turno { get; set; }
        public string descripcion { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fin { get; set; }


        public  string ObtenerHorarioMedico()
        {
            return String.Format("El turno {0}, tiene hora de inicio {1}, y hora fin; {2} ", this.descripcion, this.hora_inicio, this.hora_fin);
        }

    }

}

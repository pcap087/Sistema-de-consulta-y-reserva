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

        public string ObtenerVacaciones()
        {
            return String.Format("El medico {0}, saldra de vacaciones el: {1}, y volverá el: {2}", this.medico.ObtenerPresentacionPersonal(), this.fecha_inicio, this.fecha_fin);

        }
    }
}

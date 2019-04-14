using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Consultorio
    {
        public Clinica clinica { get; set; }
        public int nro_consultorio { get; set; }
        public string descripcion { get; set; }

        public string ObtenerConsultorio()
        {
            return String.Format("En la Clinica: {0}, Numero de consultorio {1}, Descripción Consultorio: {2}  ", this.clinica.nro_clinica,this.nro_consultorio, this.descripcion);
        }
    }
}

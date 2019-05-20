using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        public string nro_documento { get; set; }
        public string nombre { get; set; } //propiedad implementada automáticamente
        public string apellido { get; set; }
        public string edad { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }

        public string ObtenerNombreCompleto()
        {
            return this.nombre + " " + this.apellido;
        }

        /*public override string ToString()
        {
            return String.Format("Nombre: {0} Apellido: {1} Nro Doc: {2}", this.nombre, this.apellido, this.nro_documento);
        }*/

        //public abstract string ObtenerPresentacionPersonal();


        
    }
}

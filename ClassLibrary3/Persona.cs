using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Persona
    {
        public string nro_documento { get; set; }
        public string nombre { get; set; } //propiedad implementada automáticamente
        public string apellido { get; set; }
        public string email { get; set; }

        public string ObtenerNombreCompleto()
        {
            return this.nombre + " " + this.apellido;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0} Apellido: {1} Nro Doc: {2}", this.nombre, this.apellido, this.nro_documento);
        }

        public abstract string ObtenerPresentacionPersonal();
    }
}

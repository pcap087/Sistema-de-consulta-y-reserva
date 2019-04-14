using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{ 
    public enum cargo { Atención, Enfermero, Director, Encargado}
    public class Funcionario:Persona
    {
        public cargo cargo { get; set; }

        public override string ObtenerPresentacionPersonal()
        {
            return String.Format("Hola mi nombre es {0}, y mi cargo es {1}", this.ObtenerNombreCompleto(), this.cargo);
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum EstadoCivil { Soltero, Casado, Divorciado, Viudo }
    public enum Sexo { Masculino, Femenino }
    public class Paciente:Persona
    {

        public Sexo sexo { get; set; }
        public EstadoCivil estadoc { get; set; }

        public override string ObtenerPresentacionPersonal()
        {
            return String.Format("Hola mi nombre es {0}, mi sexo es {1} y mi estado civil es {2}", this.ObtenerNombreCompleto(), this.sexo, this.estadoc);
        }
    }
}

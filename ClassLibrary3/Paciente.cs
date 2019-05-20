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

       
    }
}

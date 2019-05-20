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

        
    }
    
}

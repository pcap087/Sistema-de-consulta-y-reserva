﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Especialidades { Endocrinologia, Cardiologia, Traumatologia, Clinico, Pediatria, Psiquiatria, Gastroenterologia}
    public  class Medico : Persona 
    {
        public Especialidades Especialidades { get; set; }

        public override string ObtenerPresentacionPersonal()
        {
            return String.Format("Hola mi nombre es {0}, y mi especialidad es {1}", this.ObtenerNombreCompleto(), this.Especialidades);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Especialidades { Endocrinologia, Cardiologia, Traumatologia, Clinico, Pediatria, Psiquiatria, Gastroenterologia}
    public class Medico : Persona 
    {
        public Especialidades Especialidades { get; set; }

        public static List<Medico> listaMedicos = new List<Medico>();

        //metodo agregar
        public static void AgregarMedico(Medico m)
        {
            listaMedicos.Add(m);
        }

        //metodo eliminar
        public static void EliminarMedico(Medico m)
        {
            listaMedicos.Remove(m);
        }

        public static List<Medico> ObtenerMedico()
        {
            return listaMedicos;
        }

        public override string ToString()
        {
            return nombre;
        }

    }
}


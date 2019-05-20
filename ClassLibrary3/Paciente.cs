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

        public static List<Paciente> listaPacientes = new List<Paciente>();

        //metodo agregar
        public static void AgregarPaciente(Paciente p)
        {
            listaPacientes.Add(p);
        }

        //metodo eliminar
        public static void EliminarPaciente(Paciente p)
        {
            listaPacientes.Remove(p);
        }

        public static List<Paciente> ObtenerPaciente()
        {
            return listaPacientes;
        }

        public override string ToString()
        {
            return nombre;
        }


    }
}

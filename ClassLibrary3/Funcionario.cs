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

        public static List<Funcionario> listaFuncionarios = new List<Funcionario>();

        //metodo agregar
        public static void AgregarFuncionario(Funcionario m)
        {
            listaFuncionarios.Add(m);
        }

        //metodo eliminar
        public static void EliminarFuncionario(Funcionario m)
        {
            listaFuncionarios.Remove(m);
        }

        public static List<Funcionario> ObtenerFuncionario()
        {
            return listaFuncionarios;
        }

        public override string ToString()
        {
            return nombre;
        }


    }
    
}

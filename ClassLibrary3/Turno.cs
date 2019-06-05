using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Turno
    {
        
        public string descripcion { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_fin { get; set; }

        public static List<Turno> listaTurnos = new List<Turno>();

        public static void AgregarTurno(Turno t)
        {
            listaTurnos.Add(t);
        }
        //hola
        public static void EliminarTurno(Turno t)
        {
            listaTurnos.Remove(t);
        }
        public static List<Turno> ObtenerTurnos()
        {
            return listaTurnos;
        }
        public override string ToString()
        {
            return this.descripcion;
        }



    }

}

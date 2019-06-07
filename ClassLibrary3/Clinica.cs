using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Clinica
    {
        public string nro_clinica { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public Ciudad ciudad { get; set; }
        public string telefono { get; set; }

        //public string ObtenerClinica()
        //{
        //    return String.Format("Clinica: {0}, Dirección:  {1}, Ciudad:  {2}, Telefono: {3} ", this.nro_clinica, this.direccion, this.ciudad.nro_ciudad, this.telefono);
        //}

        public static List<Clinica> listaClinica = new List<Clinica>();

        public static void AgregarClinica(Clinica c)
        {
            listaClinica.Add(c);
        }
        public static void EliminarClinica(Clinica c)
        {
            listaClinica.Remove(c);
        }
        public static List<Clinica> ObtenerClinica()
        {
            return listaClinica;
        }
        public override string ToString()
        {
            return this.descripcion;
        }
    }
}

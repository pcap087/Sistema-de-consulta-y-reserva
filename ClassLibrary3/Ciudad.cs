using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ciudad
    {
        public string nro_ciudad { get; set; }
        public string descripcion { get; set; }

        //public string ObtenerCiudad()
        //{

        //    return String.Format("El numero de ciudad {0}, corresponde a: {1 }", this.nro_ciudad, this.descripcion);
        //}

        public static List<Ciudad> listaCiudades = new List<Ciudad>();

        public static void AgregarCiudad(Ciudad c)
        {
            listaCiudades.Add(c);
        }
        public static void EliminarCiudad(Ciudad c)
        {
            listaCiudades.Remove(c);
        }
        public static List<Ciudad> ObtenerCiudades()
        {
            return listaCiudades;
        }
        public override string ToString()
        {
            return this.descripcion;
        }
    }

}

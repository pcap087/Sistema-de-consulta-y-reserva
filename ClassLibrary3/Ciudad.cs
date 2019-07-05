using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ciudad
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public static List<Ciudad> listaCiudades = new List<Ciudad>();



        public static void AgregarCiudad(Ciudad c)
        {
            //listaProveedores.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Ciudad (descripcion) VALUES (@descripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();
            }
        }

        public static Ciudad ObtenerCiudad(int id)
        {
            Ciudad ciudad= null;

            if (listaCiudades.Count == 0) Ciudad.ObtenerCiudades();

            foreach (Ciudad c in listaCiudades)
            {
                if (c.id== id)
                {
                    ciudad= c;
                    break;
                }

            }
            return ciudad;
            
        }

        public static List<Ciudad> ObtenerCiudades()
        {

            Ciudad ciudad;
            listaCiudades.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Ciudad";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    
                    ciudad = new Ciudad();
                    ciudad.id = elLectorDeDatos.GetInt32(0);
                    ciudad.descripcion= elLectorDeDatos.GetString(1);
                  
                    listaCiudades.Add(ciudad);
                }
            }
            return listaCiudades;
        }
        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@descripcion", this.descripcion);
            
            p1.SqlDbType = SqlDbType.VarChar;
            
            cmd.Parameters.Add(p1);
            

            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }

            return cmd;
        }
        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p9 = new SqlParameter("@id", this.id);
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p9);
            return cmd;
        }
        public override string ToString()
        {
            return this.descripcion;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Consultorio
    {

        public int id { get; set; }
        public string descripcion { get; set; }

        public static List<Consultorio> listaConsultorios= new List<Consultorio>();
        public static Consultorio ObtenerConsultorio(int id)
        {
            Consultorio consultorio= null;

            if (listaConsultorios.Count == 0) Consultorio.ObtenerConsultorios();

            foreach (Consultorio c in listaConsultorios)
            {
                if (c.id == id)
                {
                    consultorio= c;
                    break;
                }

            }
            return consultorio;

        }

        public static void AgregarConsultorio(Consultorio c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Consultorio (descripcion) VALUES (@descripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }




        public static List<Consultorio> ObtenerConsultorios()
        {

            Consultorio consultorio;
            listaConsultorios.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Consultorio";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    consultorio= new Consultorio();
                    consultorio.id= elLectorDeDatos.GetInt32(0);
                    consultorio.descripcion= elLectorDeDatos.GetString(1);
                    listaConsultorios.Add(consultorio);
                }
            }
            return listaConsultorios;
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
            SqlParameter p5 = new SqlParameter("@id", this.id);
            p5.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p5);

            return cmd;
        }



        public override string ToString()
        {
            return this.descripcion;
        }
    }
}

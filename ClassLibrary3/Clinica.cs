using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Clinica
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public Ciudad ciudad { get; set; }
        public string telefono { get; set; }

        public static List<Clinica> listaClinicas= new List<Clinica>();


        public static void AgregarClinica(Clinica c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Clinica (descripcion, direccion, ciudad, telefono) VALUES (@descripcion, @direccion, @ciudad, @telefono)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }
        

        

        public static List<Clinica> ObtenerClinicas()
        {

            Clinica clinica;
            listaClinicas.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Clinica";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    
                    clinica = new Clinica();
                    clinica.id= elLectorDeDatos.GetInt32(0);
                    clinica.descripcion = elLectorDeDatos.GetString(1);
                    clinica.direccion = elLectorDeDatos.GetString(2);
                    clinica.ciudad= Ciudad.ObtenerCiudad(elLectorDeDatos.GetInt32(3));
                    clinica.telefono = elLectorDeDatos.GetString(4);
                    listaClinicas.Add(clinica);
                }
            }
            return listaClinicas;
        }


        
        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@descripcion", this.descripcion);
            SqlParameter p2 = new SqlParameter("@direccion", this.direccion);
            SqlParameter p3 = new SqlParameter("@ciudad", this.ciudad.id);
            SqlParameter p4 = new SqlParameter("@telefono", this.telefono);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
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
        public static Clinica ObtenerClinica(int id)
        {
            Clinica clinica= null;

            if (listaClinicas.Count == 0) Clinica.ObtenerClinicas();

            foreach (Clinica c in listaClinicas)
            {
                if (c.id == id)
                {
                    clinica = c;
                    break;
                }

            }
            return clinica;

        }
    }
}

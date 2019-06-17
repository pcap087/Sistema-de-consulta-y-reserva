using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Disponibilidad
    {
        public int id { get; set; }
        public Medico medico { get; set; }
        public Turno turno { get; set; }
        public List<string> dias_atencion { get; set; }

        public static List<Disponibilidad> listaDisponibilidades = new List<Disponibilidad>();

        public static void AgregarDisponibilidad(Disponibilidad dis)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Disponibilidad (medico,turno,dias_atencion) VALUES (@medico,@turno,@dias_atencion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = dis.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarDisponibilidad(Disponibilidad dis)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Disponibilidad where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = dis.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarDisponibilidad(int index, Disponibilidad dis)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Disponibilidad SET medico = @medico, turno= @turno,dias_entrega = @dias_entrega where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = dis.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Disponibilidad> ObtenerDisponibildades()
        {

            Disponibilidad dis;
            listaDisponibilidades.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Disponibilidad";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    
                    dis = new Disponibilidad();
                    dis.id = elLectorDeDatos.GetInt32(0);
                    dis.medico = Medico.ObtenerMed(elLectorDeDatos.GetInt32(1));
                    dis.turno = Turno.ObtenerTurno(elLectorDeDatos.GetInt32(2));
                    dis.dias_atencion=ObtenerListaDiasAtencion(elLectorDeDatos.GetString(3));


                    listaDisponibilidades.Add(dis);
                }
            }
            return listaDisponibilidades;
        }


        private string ObtenerStringDiasAtencion()
        {
            return string.Join(",", this.dias_atencion);

        }

        private static List<string> ObtenerListaDiasAtencion(string dias)
        {
            return dias.Split(',').ToList();
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@medico", this.medico.id);
            SqlParameter p2 = new SqlParameter("@turno", this.turno.id);
            SqlParameter p3 = new SqlParameter("@dias_atencion", this.ObtenerStringDiasAtencion());
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.Float;
            p3.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

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
            return Convert.ToString(this.id);
        }
    }

    
}
  
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vacacion
    {
        public int id { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public Medico medico { get; set; }

        public static List<Vacacion> listaVacaciones = new List<Vacacion>();

        public static void AgregarVacacion(Vacacion v)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Vacacion (fecha_inicio,fecha_fin,medico) VALUES (@fecha_inicio, @fecha_fin, @medico)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = v.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarReserva(int index, Vacacion v)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Vacacion SET fecha_inicio= @fecha_inicio, fecha_fin=@fecha_fin, medico= @medico where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = v.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@fecha_inicio", this.fecha_inicio);
            SqlParameter p2 = new SqlParameter("@fecha_fin", this.fecha_fin);
            SqlParameter p3 = new SqlParameter("@medico", this.medico.id);
            p1.SqlDbType = SqlDbType.DateTime;
            p2.SqlDbType = SqlDbType.DateTime;
            p3.SqlDbType = SqlDbType.Int;
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
            SqlParameter p4 = new SqlParameter("@id", this.id);
            p4.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p4);

            return cmd;
        }

        public static List<Vacacion> ObtenerVacaciones()
        {

            Vacacion vacacion;
            listaVacaciones.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Vacacion";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {

                    vacacion= new Vacacion();
                    vacacion.id = elLectorDeDatos.GetInt32(0);
                    vacacion.fecha_inicio = elLectorDeDatos.GetDateTime(1);
                    vacacion.fecha_fin = elLectorDeDatos.GetDateTime(2);
                    vacacion.medico = Medico.ObtenerMed(elLectorDeDatos.GetInt32(3));
                    listaVacaciones.Add(vacacion);
                }
            }
            return listaVacaciones;
        }

        public static void EliminarVacacion(Vacacion vacacion)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Vacacion where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = vacacion.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public override string ToString()
        {
            return medico.nombre + " " + fecha_inicio.ToShortDateString() + " " +fecha_fin.ToShortDateString();
        }
    }

    
}

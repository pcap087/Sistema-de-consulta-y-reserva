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

        public static List<Disponibilidad> listaDisponibilidad = new List<Disponibilidad>();

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

        public static List<Disponibilidad> ObtenerDisponibildad()
        {

            Disponibilidad dis;
            listaDisponibilidad.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Disponibilidad";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    //nombre, peso, fecha_vencimiento, precio,categoria,proveedor,tipo_carne,dias_entrega
                    dis = new Disponibilidad();
                    dis.id = elLectorDeDatos.GetInt32(0);
                    dis.medico = Medico.ObtenerMedico(elLectorDeDatos.GetInt32(1));
                    dis.turno = Turno.ObtenerTurno(elLectorDeDatos.GetInt32(2));
                    dis.dias_atencion=ObtenerListaDiasAtencion(elLectorDeDatos.GetString(8));


                    listaDisponibilidad.Add(dis);
                }
            }
            return listaDisponibilidad;
        }


        private string ObtenerStringDiasEntrega()
        {
            return string.Join(",", this.dias_atencion);

        }

        private static List<string> ObtenerListaDiasAtencion(string dias)
        {
            return dias.Split(',').ToList();
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p2 = new SqlParameter("@peso", this.peso);
            SqlParameter p3 = new SqlParameter("@fecha_vencimiento", this.fecha_vencimiento);
            SqlParameter p4 = new SqlParameter("@precio", this.precio);
            SqlParameter p5 = new SqlParameter("@categoria", this.categoria);
            SqlParameter p6 = new SqlParameter("@proveedor", this.proveedor.Id);
            SqlParameter p7 = new SqlParameter("@tipo_carne", this.tipo_carne);
            SqlParameter p8 = new SqlParameter("@dias_entrega", this.ObtenerStringDiasEntrega());
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.Float;
            p3.SqlDbType = SqlDbType.DateTime;
            p4.SqlDbType = SqlDbType.Float;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.Int;
            p7.SqlDbType = SqlDbType.Int;
            p8.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);

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
            return this.nombre;
        }
    }

    
}
  
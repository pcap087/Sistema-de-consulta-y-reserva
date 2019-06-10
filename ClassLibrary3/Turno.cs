using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Turno
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_fin { get; set; }

        public static List<Turno> listaTurnos= new List<Turno>();

        public static void AgregarTurno(Turno t)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Turno (descripcion,hora_inicio,hora_fin) VALUES (@descripcion, @hora_inicio, @hora_fin)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@descripcion", t.descripcion);
                SqlParameter p2 = new SqlParameter("@hora_inicio", t.hora_inicio);
                SqlParameter p3 = new SqlParameter("@hora_fin", t.hora_fin);
                
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.DateTime;
                p3.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                

                cmd.ExecuteNonQuery();



            }
        }
        public static void EliminarTurno(Turno turno)
        {
            //listaProveedores.Remove(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Turno where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p4 = new SqlParameter("@Id", turno.id);
                p4.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p4);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarTurno(int index, Turno t)
        {
            //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Turno SET descripcion= @descripcion, hora_inicio= @hora_inicio, hora_fin= @hora_fin where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@descripcion", t.descripcion);
                SqlParameter p2 = new SqlParameter("@hora_inicio", t.hora_inicio);
                SqlParameter p3 = new SqlParameter("@hora_fin", t.hora_fin);
                
                SqlParameter p4 = new SqlParameter("@Id", t.id);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.DateTime;
                p3.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Turno> ObtenerTurnos()
        {
            //return listaProveedores;
            Turno turno;
            listaTurnos.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Turno";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    turno = new Turno();
                    turno.id= elLectorDeDatos.GetInt32(0);
                    turno.descripcion = elLectorDeDatos.GetString(1);
                    turno.hora_inicio= elLectorDeDatos.GetDateTime(2);
                    turno.hora_fin= elLectorDeDatos.GetDateTime(3);

                    listaTurnos.Add(turno);
                }
            }
            return listaTurnos;
        }
        
        public static Turno ObtenerTurno(int id)
        {
            Turno turno = null;

            if (listaTurnos.Count == 0) Turno.ObtenerTurnos();

            foreach (Turno p in listaTurnos)
            {
                if (p.id == id)
                {
                    turno= p;
                    break;
                }

            }
            return turno;
        }



        public override string ToString()
        {
            return descripcion;
        }
    }
}

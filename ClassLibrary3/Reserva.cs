using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Estados { Pendiente, Anulado, Cancelado }
    public class Reserva
    {
        public int id { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime fecha_registro { get; set; }
        public DateTime fecha_reservada { get; set; }
        public Estados estados { get; set; }
        public Double monto { get; set; }

        public static List<Reserva> listaReservas = new List<Reserva>();

        public static void AgregarReserva(Reserva r)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Reserva (paciente,medico,funcionario,fecha_registro,fecha_reservada,estados,monto) VALUES (@paciente, @medico, @funcionario, @fecha_registro, @fecha_reservada,@estados,@monto)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = r.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }

        public static void EditarReserva(int index, Reserva r)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Reserva SET paciente= @paciente, medico= @medico, funcionario= @funcionario, fecha_registro= @fecha_registro,fecha_reservada= @fecha_reservada,estados= @estados,monto= @monto where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = r.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarReserva(Reserva reserva)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Reserva where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = reserva.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static Reserva ObtenerReservaParametro(int id)
        {
            Reserva reserva= null;

            if (listaReservas.Count == 0)Reserva.ObtenerReservas();

            foreach (Reserva r in listaReservas)
            {
                if (r.id == id)
                {
                    reserva= r;
                    break;
                }

            }
            return reserva;
        }

        public static List<Reserva> ObtenerReservas()
        {

            Reserva reserva;
            listaReservas.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Reserva";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    
                    reserva = new Reserva();
                    reserva.id = elLectorDeDatos.GetInt32(0);
                    reserva.paciente=Paciente.ObtenerPacienteParametro(elLectorDeDatos.GetInt32(1));
                    reserva.medico=Medico.ObtenerMed(elLectorDeDatos.GetInt32(2));
                    reserva.funcionario= Funcionario.ObtenerFuncionarioParametro(elLectorDeDatos.GetInt32(3));
                    reserva.fecha_registro= elLectorDeDatos.GetDateTime(4);
                    reserva.fecha_reservada= elLectorDeDatos.GetDateTime(5);
                    reserva.estados= (Estados)elLectorDeDatos.GetInt32(6);
                    reserva.monto = elLectorDeDatos.GetDouble(7);
                    listaReservas.Add(reserva);
                }
            }
            return listaReservas;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@paciente", this.paciente.id);
            SqlParameter p2 = new SqlParameter("@medico", this.medico.id);
            SqlParameter p3 = new SqlParameter("@funcionario", this.funcionario.id);
            SqlParameter p4 = new SqlParameter("@fecha_registro", this.fecha_registro);
            SqlParameter p5 = new SqlParameter("@fecha_reservada", this.fecha_reservada);
            SqlParameter p6 = new SqlParameter("@estados", this.estados);
            SqlParameter p7 = new SqlParameter("@monto", this.monto);
            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.DateTime;
            p5.SqlDbType = SqlDbType.DateTime;
            p6.SqlDbType = SqlDbType.Int;
            p7.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            

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
            return paciente.nombre+" "+fecha_reservada.ToShortDateString();
        }
    }
}

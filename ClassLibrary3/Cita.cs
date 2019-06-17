using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cita
    {
        public int id { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public Funcionario funcionario { get; set; }
        public Turno turno { get; set; }
        public DateTime fecha { get; set; }
        public Consultorio consultorio { get; set; }
        public Reserva reserva { get; set; }
        

        public static List<Cita> listaCitas= new List<Cita>();

        public static void AgregarCita(Cita c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Cita (paciente,medico,funcionario,turno,fecha,consultorio,reserva) VALUES (@paciente, @medico, @funcionario,@turno,@fecha,@consultorio,@reserva)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();
            }
        }
        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@paciente", this.paciente.id);
            SqlParameter p2 = new SqlParameter("@medico", this.medico.id);
            SqlParameter p3 = new SqlParameter("@funcionario", this.funcionario.id);
            SqlParameter p4 = new SqlParameter("@turno", this.turno.id);
            SqlParameter p5 = new SqlParameter("@fecha", this.fecha);
            SqlParameter p6 = new SqlParameter("@consultorio", this.consultorio.id);
            SqlParameter p7 = new SqlParameter("@reserva", this.reserva.id);
            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.DateTime;
            p6.SqlDbType = SqlDbType.Int;
            p7.SqlDbType = SqlDbType.Int;
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

        public static void EditarCita(int index, Cita c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Cita SET paciente= @paciente, medico= @medico, funcionario= @funcionario,turno=@turno, fecha= @fecha,consultorio= @consultorio,reserva= @reserva where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarCita(Cita cita)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Cita where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = cita.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Cita> ObtenerCitas()
        {

            Cita cita;
            listaCitas.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Cita";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {

                    cita= new Cita();
                    cita.id = elLectorDeDatos.GetInt32(0);
                    cita.paciente = Paciente.ObtenerPacienteParametro(elLectorDeDatos.GetInt32(1));
                    cita.medico = Medico.ObtenerMed(elLectorDeDatos.GetInt32(2));
                    cita.funcionario = Funcionario.ObtenerFuncionarioParametro(elLectorDeDatos.GetInt32(3));
                    cita.turno= Turno.ObtenerTurno(elLectorDeDatos.GetInt32(4));
                    cita.fecha= elLectorDeDatos.GetDateTime(5);
                    cita.consultorio= Consultorio.ObtenerConsultorio(elLectorDeDatos.GetInt32(6));
                    cita.reserva= Reserva.ObtenerReservaParametro(elLectorDeDatos.GetInt32(7));
                    listaCitas.Add(cita);
                }
            }
            return listaCitas;
        }

        public override string ToString()
        {
            return paciente.nombre;
        }
    }
}

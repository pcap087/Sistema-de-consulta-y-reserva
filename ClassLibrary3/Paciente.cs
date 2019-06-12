using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum EstadoCivil { Soltero, Casado, Divorciado, Viudo }
    public enum Sexo { Masculino, Femenino }
    public class Paciente:Persona
    {

        public Sexo tipo_sexo { get; set; }
        public EstadoCivil tipo_estado { get; set; }

        public static List<Paciente> listaPacientes = new List<Paciente>();

        //metodo agregar
        public static void AgregarPaciente(Paciente p)
        {
            //listaPacientes.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Paciente (nro_doc, nombre, apellido, edad, direccion, telefono, ruc, tipo_sexo, tipo_estado, email)
                    VALUES (@nro_doc, @nombre, @apellido, @edad, @direccion, @telefono, @ruc, @tipo_sexo, @tipo_estado, @email)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd, false);
                cmd.ExecuteNonQuery();

            }
        }

        //metodo eliminar
        public static void EliminarPaciente(Paciente p)
        {
            //listaFuncionarios.Remove(m);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Paciente where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }


        //metodo editar
        public static void EditarPaciente(int index, Paciente p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Paciente SET nro_doc = @nro_doc, nombre = @nombre, apellido = @apellido, edad = @edad, direccion = @direccion, 
                    telefono = @telefono, ruc = @ruc, tipo_sexo = @tipo_sexo, tipo_estado = @tipo_estado, email = @email  where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Paciente> ObtenerPaciente()
        {
            Paciente paciente;
            listaPacientes.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Paciente";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    paciente = new Paciente();
                    paciente.id = elLectorDeDatos.GetInt32(0);
                    paciente.nro_documento = elLectorDeDatos.GetInt32(1);
                    paciente.nombre = elLectorDeDatos.GetString(2);
                    paciente.apellido = elLectorDeDatos.GetString(3);
                    paciente.edad = elLectorDeDatos.GetInt32(4);
                    paciente.direccion = elLectorDeDatos.GetString(5);
                    paciente.telefono = elLectorDeDatos.GetString(6);
                    paciente.ruc = elLectorDeDatos.GetString(7);
                    paciente.tipo_sexo = (Sexo)elLectorDeDatos.GetInt32(8);
                    paciente.tipo_estado = (EstadoCivil)elLectorDeDatos.GetInt32(9);
                    paciente.email = elLectorDeDatos.GetString(10);


                    listaPacientes.Add(paciente);
                }
            }
            return listaPacientes;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {

            SqlParameter p1 = new SqlParameter("@nro_doc", this.nro_documento);
            SqlParameter p2 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p3 = new SqlParameter("@apellido", this.apellido);
            SqlParameter p4 = new SqlParameter("@edad", this.edad);
            SqlParameter p5 = new SqlParameter("@direccion", this.direccion);
            SqlParameter p6 = new SqlParameter("@telefono", this.telefono);
            SqlParameter p7 = new SqlParameter("@ruc", this.ruc);
            SqlParameter p8 = new SqlParameter("@tipo_sexo", this.tipo_estado);
            SqlParameter p9 = new SqlParameter("@tipo_estado", this.tipo_estado);
            SqlParameter p10 = new SqlParameter("@email", this.email);


            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.VarChar;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.Int;
            p9.SqlDbType = SqlDbType.Int;
            p10.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);

            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p11 = new SqlParameter("@id", this.id);
            p11.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p11);

            return cmd;
        }

        public override string ToString()
        {
            return nombre;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Especialidades { Endocrinologia, Cardiologia, Traumatologia, Clinico, Pediatria, Psiquiatria, Gastroenterologia}
    public class Medico : Persona 
    {
        public Especialidades especialidad { get; set; }

        public static List<Medico> listaMedicos = new List<Medico>();

        //metodo agregar
        public static void AgregarMedico(Medico m)
        {
            //listaMedico.Add(m);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Medico (nro_doc, nombre, apellido, edad, direccion, telefono, ruc, tipo_especialidad, email) VALUES (@nro_doc, @nombre, @apellido, @edad, @direccion, @telefono, @ruc, @tipo_especialidad, @email)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = m.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();

            }
        }

        //metodo eliminar
        public static void EliminarMedico(Medico m)
        {
            //listaMedico.Remove(m);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Medico where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = m.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        //metodo editar
        public static void EditarMedico(int index, Medico f)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Medico SET nro_doc = @nro_doc, nombre = @nombre, apellido = @apellido, edad = @edad, direccion = @direccion, telefono = @telefono, ruc = @ruc, tipo_especialidad = @tipo_especialidad, email = @email  where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = f.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Medico> ObtenerMedico()
        {
            Medico medico;
            listaMedicos.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Medico";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    //nombre, peso, fecha_vencimiento, precio,categoria,proveedor,tipo_carne,dias_entrega
                    medico = new Medico();
                    medico.id = elLectorDeDatos.GetInt32(0);
                    medico.nro_documento = elLectorDeDatos.GetInt32(1);
                    medico.nombre = elLectorDeDatos.GetString(2);
                    medico.apellido = elLectorDeDatos.GetString(3);
                    medico.edad = elLectorDeDatos.GetInt32(4);
                    medico.direccion = elLectorDeDatos.GetString(5);
                    medico.telefono = elLectorDeDatos.GetString(6);
                    medico.ruc = elLectorDeDatos.GetString(7);
                    medico.especialidad = (Especialidades)elLectorDeDatos.GetInt32(8);
                    medico.email = elLectorDeDatos.GetString(9);


                    listaMedicos.Add(medico);
                }
            }
            return listaMedicos;
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
            SqlParameter p8 = new SqlParameter("@tipo_especialidad", this.especialidad);
            SqlParameter p9 = new SqlParameter("@email", this.email);


            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.VarChar;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.Int;
            p9.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);

            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }

            return cmd;
        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p10 = new SqlParameter("@id", this.id);
            p10.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p10);

            return cmd;
        }

        public override string ToString()
        {
            return nombre;
        }

    }
}


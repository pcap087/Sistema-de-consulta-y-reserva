using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class Usuario
    {
        public static void CrearUsuario(string usuario, string password)
        {
            string password_protegido = EncodePassword(password);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION)) //Crear un objeto SqlConnection
            {
                //Abrir la conexión
                con.Open();

                //Query que se ejecutara en el servidor de base de datos...
                string textoCmd = "INSERT INTO USUARIO (usuario, password) values(@Usuario, @password)";

                //Creamos un objeto comando que es el que 'ejecutara' el comando sql, utilizando la conexion creada..
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //Agregamos el parametro de usuario
                SqlParameter p1 = new SqlParameter("@Usuario", usuario.Trim());
                p1.SqlDbType = SqlDbType.VarChar; //indicamos el tipo de dato del parametro

                //Agregamos el parametro password
                SqlParameter p2 = new SqlParameter("@Password", password_protegido);
                p2.SqlDbType = SqlDbType.VarChar; //indicamos el tipo de dato del parametro

                //asignamos los parametros al objeto comando
                cmd.Parameters.Add(p1); //parametro usuario
                cmd.Parameters.Add(p2); //parametro password

                //Ejecutar el comando

                cmd.ExecuteNonQuery(); //Ejecutamos



            }
        }

        public static bool Autenticar(string usuario, string password)
        {
            string password_protegido = EncodePassword(password);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION)) //Crear un objeto SqlConnection
            {
                //Abrir la conexión
                con.Open();

                //Query que se ejecutara en el servidor de base de datos...
                string textoCmd = "SELECT Usuario, password from Usuario where Usuario = @Usuario and password = @password";

                //Creamos un objeto comando que es el que 'ejecutara' el comando sql, utilizando la conexion creada..
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //Agregamos el parametro de usuario
                SqlParameter p1 = new SqlParameter("@Usuario", usuario.Trim());
                p1.SqlDbType = SqlDbType.VarChar; //indicamos el tipo de dato del parametro

                //Agregamos el parametro password
                SqlParameter p2 = new SqlParameter("@Password", password_protegido);
                p2.SqlDbType = SqlDbType.VarChar; //indicamos el tipo de dato del parametro

                //asignamos los parametros al objeto comando
                cmd.Parameters.Add(p1); //parametro usuario
                cmd.Parameters.Add(p2); //parametro password

                //Ejecutar el comando
               
                SqlDataReader reader = cmd.ExecuteReader(); //Ejecutamos y guardamos el resultado en el reader

                if (reader.HasRows) //Preguntamos si hay filas de retorno (si hay resultset)
                {
                    reader.Close(); //Cerramos la conexion                                                                                    
                    return true; //Retornamos true, porque encontro un usuario y contrasenha que coincide en la base de datos..
                }
                else
                {
                    reader.Close(); //Cerramos la conexion                                                     
                    return false; //retornamos falsse, porque no habia ninguna combinacion de usuario y password en la base de datos..
                }
            }
        }


        public static string EncodePassword(string originalPassword)
        {

            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string salt = "0d71ee4472658cd5874c5578410a9d8611fc9aef";
            string passwordSalt = salt + originalPassword;
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(passwordSalt);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }
    }
}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoReservasConsultas
{
     class Program
    {
        static void Main(string[] args)
        {

            Paciente p1 = new Paciente { nro_documento = "1", nombre = "Roque", apellido = "Santacruz", email = "correo1", sexo = Sexo.Masculino, estadoc = EstadoCivil.Casado };

            Medico m1 = new Medico { nro_documento = "1", nombre = "Mario", apellido = "Gonzalez", email = "correo2", Especialidades = Especialidades.Cardiologia };

            Funcionario f1 = new Funcionario { nro_documento = "1", nombre = "Silvia", apellido = "Perez", email = "correo3", cargo = cargo.Atención };

            Ciudad c1 = new Ciudad { nro_ciudad = 1, descripcion = "Asunción" };

            Clinica cl1 = new Clinica { nro_clinica = 1, ciudad = c1, direccion = "Pachecho", telefono = "1234" };

            Consultorio cns1 = new Consultorio {clinica = cl1, nro_consultorio= 1, descripcion="Consultorio 1"};

            Turno tr1 = new Turno { nro_turno = 1, descripcion = "Primer Turno", hora_inicio = "13:30", hora_fin =" 11:00 " };

            Vacacion vac = new Vacacion { nro_vacacion = 1, fecha_inicio = "01/01/2019", fecha_fin="05/01/2019", medico=m1 };

            Reserva res = new Reserva { nro_reserva = 1, estados = Estados.Pendiente, medico = m1, fecha_registro = "05/05/2019", fecha_reservada = "06/05/2019", fecha_vencimiento = "08/05/2019", funcionario = f1, monto = 140000, paciente = p1 };

            Cita ci = new Cita {nro_cita=1, paciente=p1, funcionario=f1, consultorio=cns1, fecha=res.fecha_reservada, medico=m1, reserva= res, turno=tr1  };

            DetalleDisponibilidad dd = new DetalleDisponibilidad {medico=m1, cantidad_max_paciente=10, turno= tr1, fecha= "06/05/2019"};


            Console.Write("Sistema de consultas y reservas de citas médicas para empresa ficticia.");
            Console.Write(System.Environment.NewLine);
            Console.WriteLine(p1.ObtenerPresentacionPersonal());
            Console.WriteLine(f1.ObtenerPresentacionPersonal());
            Console.WriteLine(m1.ObtenerPresentacionPersonal());
            Console.WriteLine(ci.ObtenerDetalleTurno());
            Console.WriteLine(cl1.ObtenerClinica());
            Console.WriteLine(c1.ObtenerCiudad());
            Console.WriteLine(res.ObtenerReserva());
            Console.WriteLine(tr1.ObtenerHorarioMedico());
            Console.WriteLine(vac.ObtenerVacaciones());
            Console.WriteLine(cns1.ObtenerConsultorio());
            



            Console.Write("Fin del programa");
            Console.ReadKey();
        }
    }
}

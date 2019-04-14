using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Estados { Pendiente, Anulado, Cancelado}
    public class Reserva
    {
        public int nro_reserva { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public Funcionario funcionario { get; set; }
        public string fecha_registro { get; set; }
        public string fecha_reservada { get; set; }
        public string fecha_vencimiento { get; set; }
        public Estados estados { get; set; }
        public decimal monto { get; set; }
        
        public string ObtenerReserva()
        {
            return String.Format("El numero de reserva {0}, corresponde al paciente {1}, con el medico {2}, para la fecha: {3}", this.nro_reserva, this.paciente.ObtenerNombreCompleto(), this.medico.nombre, this.fecha_reservada);
        }
    
    }
}

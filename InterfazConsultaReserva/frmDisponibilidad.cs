using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace InterfazConsultaReserva
{
    public partial class frmDisponibilidad : Form
    {
        public frmDisponibilidad()
        {
            InitializeComponent();
        }

        private void Disponibilidad_Load(object sender, EventArgs e)
        {
            frmDisponibilidad dd = new frmDisponibilidad();


            ActualizarListaDisponibilidad();
            cmbMedico.DataSource = Medico.ObtenerMedico();
            cmbTurno.DataSource = Turno.ObtenerTurnos();
            //BloquearFormulario();
        }

        private void ActualizarListaDisponibilidad()
        {
            lstDisponibilidad.DataSource = null;
            lstDisponibilidad.DataSource = Disponibilidad.ObtenerDisponibildad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

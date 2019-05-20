using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfazConsultaReserva
{
    public partial class frmTurno : Form
    {
        public frmTurno()
        {
            InitializeComponent();
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            Turno turno = ObtenerTurnoFormulario();
            Turno.AgregarTurno(turno);
            ActualizarListaTurnos();
            LimpiarFormularioTurno();
        }
        private Turno ObtenerTurnoFormulario()
        {
            Turno turno= new Turno();
            turno.descripcion = txtDescripcion.Text;
            turno.hora_inicio = dtpHoraInicio.Value.Date;
            turno.hora_fin = dtpHoraFin.Value.Date;
            
            return turno;
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            ActualizarListaTurnos();
            
        }
        private void ActualizarListaTurnos()
        {
            lstTurnos.DataSource = null;
            lstTurnos.DataSource = Turno.ObtenerTurnos();
        }

        private void LimpiarFormularioTurno()
        {
            txtDescripcion.Text = "";
            dtpHoraInicio.Value = System.DateTime.Now;
            dtpHoraFin.Value = System.DateTime.Now;
        }

        private void btnEditarTurno_Click(object sender, EventArgs e)
        {
            int index = lstTurnos.SelectedIndex;
            Turno.listaTurnos[index] =ObtenerTurnoFormulario();

            ActualizarListaTurnos();
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            Turno turno= (Turno)lstTurnos.SelectedItem;
            Turno.EliminarTurno(turno);
            ActualizarListaTurnos();
            LimpiarFormularioTurno();
        }

        private void btnLimpiarTurno_Click(object sender, EventArgs e)
        {
            LimpiarFormularioTurno();
        }
    }
}

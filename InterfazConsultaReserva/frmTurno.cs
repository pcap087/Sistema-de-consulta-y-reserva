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
        string modo;
        public frmTurno()
        {
            InitializeComponent();
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            /*DesbloquearFormularioTurno();
            Turno turno = ObtenerTurnoFormulario();
            Turno.AgregarTurno(turno);
            ActualizarListaTurnos();
            LimpiarFormularioTurno();*/

            modo = "I";
            LimpiarFormularioTurno();
            DesbloquearFormularioTurno();
        }
        private Turno ObtenerTurnoFormulario()
        {
            Turno turno= new Turno();
            turno.descripcion = txtDescripcion.Text;
            turno.hora_inicio = dtpHoraInicio.Value;
            turno.hora_fin = dtpHoraFin.Value;
            
            return turno;
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            ActualizarListaTurnos();
            BloquearFormularioTurno();
        }
        private void ActualizarListaTurnos()
        {
            lstTurnos.DataSource = null;
            lstTurnos.DataSource = Turno.ObtenerTurnos();
        }
        private void DesbloquearFormularioTurno()
        {
            txtDescripcion.Enabled = true;
            dtpHoraInicio.Enabled = true;
            dtpHoraFin.Enabled = true;
            
        }
        private void BloquearFormularioTurno()
        {
            txtDescripcion.Enabled = false;
            dtpHoraInicio.Enabled = false;
            dtpHoraFin.Enabled = false;
        }

        private void LimpiarFormularioTurno()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            dtpHoraInicio.Value = System.DateTime.Now;
            dtpHoraFin.Value = System.DateTime.Now;
        }

        

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            Turno turno= (Turno)lstTurnos.SelectedItem;
            if (turno!= null)
            {
                Turno.EliminarTurno(turno);
                ActualizarListaTurnos();
                LimpiarFormularioTurno();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
        }

        private void btnLimpiarTurno_Click(object sender, EventArgs e)
        {
            LimpiarFormularioTurno();
        }

        private void lstTurnos_Click(object sender, EventArgs e)
        {
            Turno turno= (Turno)lstTurnos.SelectedItem;

            if (turno != null)
            {
                txtId.Text = Convert.ToString(turno.id);
                txtDescripcion.Text = turno.descripcion;
                dtpHoraInicio.Value = turno.hora_inicio;
                dtpHoraFin.Value = turno.hora_fin;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Turno turno= ObtenerTurnoFormulario();

                Turno.AgregarTurno(turno);


            }
            else if (modo == "E")
            {
                int index = lstTurnos.SelectedIndex;

                Turno turno  = ObtenerTurnoFormulario();
                Turno.EditarTurno(index, turno);

            }

            ActualizarListaTurnos();
            LimpiarFormularioTurno();
            BloquearFormularioTurno();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Turno turno= (Turno)lstTurnos.SelectedItem;

            if (turno!= null)
            {
                modo = "E";
                DesbloquearFormularioTurno();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioTurno();
            BloquearFormularioTurno();
        }
    }
}

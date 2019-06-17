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
    public partial class frmReserva : Form
    {
        string modo;
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            Reserva r= new Reserva();


            ActualizarListaReservas();
            cmbEstado.DataSource = Enum.GetValues(typeof(Estados));
            cmbPaciente.DataSource = Paciente.ObtenerPaciente();
            cmbMedico.DataSource = Medico.ObtenerMedico();
            cmbFuncionario.DataSource = Funcionario.ObtenerFuncionario();
            cmbEstado.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            cmbMedico.SelectedItem = null;
            cmbFuncionario.SelectedItem = null;
            BloquearFormulario();

        }

        private void BloquearFormulario()
        {
            txtId.Enabled = false;
            cmbPaciente.Enabled = false;
            cmbMedico.Enabled = false;
            cmbFuncionario.Enabled = false;
            dtpFechaRegistro.Enabled = false;
            dtpFechaReserva.Enabled = false;
            cmbEstado.Enabled = false;
            txtMonto.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void DesbloquearFormulario()
        {
            
            cmbPaciente.Enabled = true;
            cmbMedico.Enabled = true;
            cmbFuncionario.Enabled = true;
            dtpFechaRegistro.Enabled = true;
            dtpFechaReserva.Enabled = true;
            cmbEstado.Enabled = true;
            txtMonto.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void LimpiarFormulario()
        {

            cmbPaciente.SelectedItem= null;
            cmbMedico.SelectedItem = null;
            cmbFuncionario.SelectedItem = null;
            dtpFechaRegistro.Value = System.DateTime.Now;
            dtpFechaReserva.Value= System.DateTime.Now;
            cmbEstado.SelectedItem = null;
            txtMonto.Text= "";
            
        }

        private void ActualizarListaReservas()
        {
            lstReservas.DataSource = null;
            lstReservas.DataSource = Reserva.ObtenerReservas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Reserva reserva= (Reserva)lstReservas.SelectedItem;

            if (reserva!= null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Reserva reserva= (Reserva)lstReservas.SelectedItem;
            if (reserva != null)
            {
                Reserva.EliminarReserva(reserva);
                ActualizarListaReservas();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
        }

        private Reserva ObtenerReservaFormulario()
        {
            Reserva reserva= new Reserva();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                reserva.id = Convert.ToInt32(txtId.Text);
            }

            reserva.paciente= (Paciente)cmbPaciente.SelectedItem;
            reserva.medico= (Medico)cmbMedico.SelectedItem;
            reserva.funcionario= (Funcionario)cmbFuncionario.SelectedItem;
            reserva.fecha_registro= dtpFechaRegistro.Value.Date;
            reserva.fecha_reservada= dtpFechaReserva.Value.Date;
            reserva.estados= (Estados)cmbEstado.SelectedItem;
            reserva.monto= Convert.ToDouble(txtMonto.Text);
            return reserva;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Reserva reserva= ObtenerReservaFormulario();

                Reserva.AgregarReserva(reserva);


            }
            else if (modo == "E")
            {
                int index = lstReservas.SelectedIndex;

                Reserva reserva= ObtenerReservaFormulario();
                Reserva.EditarReserva(index, reserva);

            }

            ActualizarListaReservas();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstReservas_Click(object sender, EventArgs e)
        {
            Reserva reserva= (Reserva)lstReservas.SelectedItem;

            if (reserva != null)
            {
                txtId.Text = Convert.ToString(reserva.id);
                cmbPaciente.SelectedItem = (Paciente)Paciente.ObtenerPacienteParametro(reserva.paciente.id);
                cmbMedico.SelectedItem = (Medico)Medico.ObtenerMed(reserva.medico.id);
                cmbFuncionario.SelectedItem = (Funcionario)Funcionario.ObtenerFuncionarioParametro(reserva.funcionario.id);
                dtpFechaRegistro.Value = reserva.fecha_registro;
                dtpFechaReserva.Value = reserva.fecha_reservada;
                cmbEstado.SelectedItem = (Estados)reserva.estados;
                txtMonto.Text = Convert.ToString(reserva.monto);
                
            }

        }
    }
}

using ClassLibrary1;
using System;
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
    public partial class frmCita : Form
    {
        string modo;
        public frmCita()
        {
            InitializeComponent();
        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            Cita c = new Cita();


            ActualizarListaCitas();
            cmbPaciente.DataSource = Paciente.ObtenerPaciente();
            cmbMedico.DataSource = Medico.ObtenerMedico();
            cmbFuncionario.DataSource = Funcionario.ObtenerFuncionario();
            cmbTurno.DataSource= Turno.ObtenerTurnos();
            cmbConsultorio.DataSource = Consultorio.ObtenerConsultorios();
            cmbReserva.DataSource= Reserva.ObtenerReservas();
            cmbPaciente.SelectedItem = 0;
            cmbMedico.SelectedItem = 0;
            cmbFuncionario.SelectedItem = 0;
            cmbTurno.SelectedItem = 0;
            cmbConsultorio.SelectedItem = 0;
            cmbReserva.SelectedItem = 0;
            BloquearFormulario();

        }

        private void BloquearFormulario()
        {
            txtId.Enabled = false;
            cmbPaciente.Enabled = false;
            cmbMedico.Enabled = false;
            cmbFuncionario.Enabled = false;
            cmbTurno.Enabled = false;
            dtpFecha.Enabled = false;
            cmbConsultorio.Enabled = false;
            cmbReserva.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void DesbloquearFormulario()
        {
            cmbPaciente.Enabled = true;
            cmbMedico.Enabled = true;
            cmbFuncionario.Enabled = true;
            cmbTurno.Enabled = true;
            dtpFecha.Enabled = true;
            cmbConsultorio.Enabled = true;
            cmbReserva.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void ActualizarListaCitas()
        {
            lstCitas.DataSource = null;
            lstCitas.DataSource = Cita.ObtenerCitas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void LimpiarFormulario()
        {

            cmbPaciente.SelectedItem = null;
            cmbMedico.SelectedItem = null;
            cmbFuncionario.SelectedItem = null;
            cmbConsultorio.SelectedItem = null;
            cmbTurno.SelectedItem = null;
            dtpFecha.Value = System.DateTime.Now;
            cmbReserva.SelectedItem = null;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cita cita= (Cita)lstCitas.SelectedItem;

            if (cita != null)
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
            Cita cita= (Cita)lstCitas.SelectedItem;
            if (cita != null)
            {
                Cita.EliminarCita(cita);
                ActualizarListaCitas();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
        }

        private Cita ObtenerCitaFormulario()
        {
            Cita cita= new Cita();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                cita.id = Convert.ToInt32(txtId.Text);
            }

            cita.paciente = (Paciente)cmbPaciente.SelectedItem;
            cita.medico = (Medico)cmbMedico.SelectedItem;
            cita.funcionario = (Funcionario)cmbFuncionario.SelectedItem;
            cita.turno= (Turno)cmbTurno.SelectedItem;
            cita.fecha= dtpFecha.Value.Date;
            cita.consultorio= (Consultorio)cmbConsultorio.SelectedItem;
            cita.reserva= (Reserva)cmbReserva.SelectedItem;
            return cita;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string V_VALOR = "";

            if (dtpFecha.Value < System.DateTime.Today)
            {
                MessageBox.Show("La fecha de la cita no puede ser menor a la Fecha actual", "Advertencia");
                dtpFecha.Focus();
                V_VALOR = "-1";
                return;
            }
            if (cmbPaciente.SelectedIndex<0)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Advertencia");
                cmbPaciente.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbMedico.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un médico", "Advertencia");
                cmbMedico.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbFuncionario.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un funcionario", "Advertencia");
                cmbFuncionario.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbTurno.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un turno", "Advertencia");
                cmbTurno.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbConsultorio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un consultorio", "Advertencia");
                cmbConsultorio.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbReserva.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una reserva", "Advertencia");
                cmbReserva.Focus();
                V_VALOR = "-1";
                return;
            }
            if (V_VALOR == "")
            {
                if (modo == "I")
                {
                    Cita cita = ObtenerCitaFormulario();
                    Cita.AgregarCita(cita);

                }
                else if (modo == "E")
                {
                    int index = lstCitas.SelectedIndex;

                    Cita cita = ObtenerCitaFormulario();
                    Cita.EditarCita(index, cita);

                }
            }

            ActualizarListaCitas();
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

        private void lstCitas_Click(object sender, EventArgs e)
        {
            Cita cita= (Cita)lstCitas.SelectedItem;

            if (cita!= null)
            {
                txtId.Text = Convert.ToString(cita.id);
                cmbPaciente.SelectedItem = (Paciente)Paciente.ObtenerPacienteParametro(cita.paciente.id);
                cmbMedico.SelectedItem = (Medico)Medico.ObtenerMed(cita.medico.id);
                cmbFuncionario.SelectedItem = (Funcionario)Funcionario.ObtenerFuncionarioParametro(cita.funcionario.id);
                cmbTurno.SelectedItem = (Turno)Turno.ObtenerTurno(cita.turno.id);
                dtpFecha.Value = cita.fecha;
                cmbConsultorio.SelectedItem = (Consultorio)Consultorio.ObtenerConsultorio(cita.consultorio.id);
                cmbReserva.SelectedItem = (Reserva)Reserva.ObtenerReservaParametro(cita.reserva.id);

            }
        }
    }
    
}

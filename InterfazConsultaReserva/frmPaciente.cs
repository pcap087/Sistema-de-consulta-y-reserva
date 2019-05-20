using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfazConsultaReserva
{
    public partial class frmPaciente : InterfazConsultaReserva.frmPersona
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = ObtenerPacienteFormulario();
            Paciente.AgregarPaciente(paciente);
            ActualizarListaPaciente();
            LimpiarFormulario();
        }

        private void ActualizarListaPaciente()
        {
            lstPaciente.DataSource = null;
            lstPaciente.DataSource = Paciente.ObtenerPaciente();
        }

        private void LimpiarFormulario()
        {
            txtNroDocumento.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtRuc.Text = "";
            txtEdad.Text = "";
            cmbEstado.SelectedItem = null;
            cmbSexo.SelectedItem = null;
        }

        private Paciente ObtenerPacienteFormulario()
        {
            Paciente paciente = new Paciente();

            paciente.nro_documento = txtNroDocumento.Text;
            paciente.apellido = txtApellido.Text;
            paciente.nombre = txtNombre.Text;
            paciente.direccion = txtDireccion.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.email = txtEmail.Text;
            paciente.ruc = txtRuc.Text;
            paciente.edad = txtEdad.Text;
            paciente.estadoc = (EstadoCivil)cmbEstado.SelectedItem;
            paciente.sexo = (Sexo)cmbSexo.SelectedItem;
            return paciente;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstPaciente.SelectedIndex;
            Paciente.listaPacientes[index] = ObtenerPacienteFormulario();
            ActualizarListaPaciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;
            Paciente.EliminarPaciente(paciente);
            ActualizarListaPaciente();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;

            if (paciente != null)
            {
                txtNroDocumento.Text = paciente.nombre;
                txtApellido.Text = paciente.apellido;
                txtNombre.Text = paciente.nombre;
                txtDireccion.Text = paciente.direccion;
                txtTelefono.Text = paciente.telefono;
                txtEmail.Text = paciente.email;
                txtRuc.Text = paciente.ruc;
                txtEdad.Text = paciente.edad;
                cmbEstado.SelectedItem = paciente.estadoc;
                cmbSexo.SelectedItem = paciente.sexo;

            }
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            ActualizarListaPaciente();
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbSexo.SelectedItem = null;
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoCivil));
            cmbEstado.SelectedItem = null;
        }
    }
}

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
        string modo;
        public frmPaciente()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                paciente.id = Convert.ToInt32(txtId.Text);
            }

            paciente.nro_documento = Convert.ToInt32(txtNroDocumento.Text);
            paciente.apellido = txtApellido.Text;
            paciente.nombre = txtNombre.Text;
            paciente.direccion = txtDireccion.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.email = txtEmail.Text;
            paciente.ruc = txtRuc.Text;
            paciente.edad = Convert.ToInt32(txtEdad.Text);
            paciente.tipo_estado = (EstadoCivil)cmbEstado.SelectedItem;
            paciente.tipo_sexo = (Sexo)cmbSexo.SelectedItem;
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

        //DesbloquearFormulario
        private void DesbloquearFormulario()
        {
            txtNroDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEdad.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtRuc.Enabled = true;
            cmbEstado.Enabled = true;
            cmbSexo.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }

        //BloquearFormulario
        private void BloquearFormulario()
        {
            txtNroDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtRuc.Enabled = false;
            cmbEstado.Enabled = false;
            cmbSexo.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

        }

        private void lstPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;

            if (paciente != null)
            {
                txtId.Text = Convert.ToString(paciente.id);
                txtNroDocumento.Text = Convert.ToString(paciente.nro_documento);
                txtApellido.Text = paciente.apellido;
                txtNombre.Text = paciente.nombre;
                txtDireccion.Text = paciente.direccion;
                txtTelefono.Text = paciente.telefono;
                txtEmail.Text = paciente.email;
                txtRuc.Text = paciente.ruc;
                txtEdad.Text = Convert.ToString(paciente.edad);
                cmbEstado.SelectedItem = paciente.tipo_estado;
                cmbSexo.SelectedItem = paciente.tipo_sexo;

            }
        }


        private void frmPaciente_Load(object sender, EventArgs e)
        {
            ActualizarListaPaciente();
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbSexo.SelectedItem = null;
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoCivil));
            cmbEstado.SelectedItem = null;
            BloquearFormulario();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;

            if (paciente != null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)lstPaciente.SelectedItem;
            Paciente.EliminarPaciente(paciente);
            ActualizarListaPaciente();
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Paciente paciente = ObtenerPacienteFormulario();

                Paciente.AgregarPaciente(paciente);


            }
            else if (modo == "E")
            {
                int index = lstPaciente.SelectedIndex;

                Paciente paciente = ObtenerPacienteFormulario();
                Paciente.EditarPaciente(index, paciente);

            }

            ActualizarListaPaciente();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

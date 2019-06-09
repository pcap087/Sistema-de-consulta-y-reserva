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
    public partial class frmMedico : InterfazConsultaReserva.frmPersona
    {
        public frmMedico()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Medico medico = ObtenerMedicoFormulario();
            Medico.AgregarMedico(medico);
            ActualizarListaMedico();
            LimpiarFormulario();

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
            cmbEspecialidad.SelectedItem = null;
        }

        private void ActualizarListaMedico()
        {
            lstMedico.DataSource = null;
            lstMedico.DataSource = Medico.ObtenerMedico();
        }

        private Medico ObtenerMedicoFormulario()
        {
            Medico medico = new Medico();

            medico.nro_documento = Convert.ToInt32(txtNroDocumento.Text);
            medico.apellido = txtApellido.Text;
            medico.nombre = txtNombre.Text;
            medico.direccion = txtDireccion.Text;
            medico.telefono = txtTelefono.Text;
            medico.email = txtEmail.Text;
            medico.ruc = txtRuc.Text;
            medico.edad = Convert.ToInt32(txtEdad.Text);
            medico.Especialidades = (Especialidades)cmbEspecialidad.SelectedItem;
            return medico;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstMedico.SelectedIndex;
            Medico.listaMedicos[index] = ObtenerMedicoFormulario();
            ActualizarListaMedico();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            ActualizarListaMedico();
            cmbEspecialidad.DataSource = Enum.GetValues(typeof(Especialidades));
            cmbEspecialidad.SelectedItem = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medico medico = (Medico)lstMedico.SelectedItem;
            Medico.EliminarMedico(medico);
            ActualizarListaMedico();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstMedico_Click(object sender, EventArgs e)
        {
            Medico medico = (Medico)lstMedico.SelectedItem;

            if (medico != null)
            {
                txtNroDocumento.Text = medico.nombre;
                txtApellido.Text = medico.apellido;
                txtNombre.Text = medico.nombre;
                txtDireccion.Text = medico.direccion;
                txtTelefono.Text = medico.telefono;
                txtEmail.Text = medico.email;
                txtRuc.Text = medico.ruc;
                //txtEdad.Text = medico.edad;
                cmbEspecialidad.SelectedItem = medico.Especialidades;

            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();

        }
    }
}

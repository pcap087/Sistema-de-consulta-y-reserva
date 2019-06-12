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
        string modo;
        public frmMedico()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

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
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                medico.id = Convert.ToInt32(txtId.Text);
            }

            medico.nro_documento = Convert.ToInt32(txtNroDocumento.Text);
            medico.apellido = txtApellido.Text;
            medico.nombre = txtNombre.Text;
            medico.direccion = txtDireccion.Text;
            medico.telefono = txtTelefono.Text;
            medico.email = txtEmail.Text;
            medico.ruc = txtRuc.Text;
            medico.edad = Convert.ToInt32(txtEdad.Text);
            medico.especialidad = (Especialidades)cmbEspecialidad.SelectedItem;
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
            Medico p = new Medico();

            ActualizarListaMedico();
            cmbEspecialidad.DataSource = Enum.GetValues(typeof(Especialidades));
            cmbEspecialidad.SelectedItem = null;
            BloquearFormulario();
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
                txtId.Text = Convert.ToString(medico.id);
                txtNroDocumento.Text = Convert.ToString(medico.nro_documento);
                txtApellido.Text = medico.apellido;
                txtNombre.Text = medico.nombre;
                txtDireccion.Text = medico.direccion;
                txtTelefono.Text = medico.telefono;
                txtEmail.Text = medico.email;
                txtRuc.Text = medico.ruc;
                txtEdad.Text = Convert.ToString(medico.edad);
                cmbEspecialidad.SelectedItem = medico.especialidad;

            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
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
            cmbEspecialidad.Enabled = true;
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
            cmbEspecialidad.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Medico medico = (Medico)lstMedico.SelectedItem;

            if (medico != null)
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
            Medico medico = (Medico)lstMedico.SelectedItem;
            Medico.EliminarMedico(medico);
            ActualizarListaMedico();
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Medico medico = ObtenerMedicoFormulario();

                Medico.AgregarMedico(medico);


            }
            else if (modo == "E")
            {
                int index = lstMedico.SelectedIndex;

                Medico medico = ObtenerMedicoFormulario();
                Medico.EditarMedico(index, medico);

            }

            ActualizarListaMedico();
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}

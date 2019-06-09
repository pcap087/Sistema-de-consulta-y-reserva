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
    public partial class frmFuncionario : InterfazConsultaReserva.frmPersona
    {
        string modo;
        public frmFuncionario()
        {
            InitializeComponent();
        }

        //metodo load
        private void frmFuncionario_Load_1(object sender, EventArgs e)
        {

            Funcionario p = new Funcionario();

            ActualizarListaFuncionario();
            cmbCargo.DataSource = Enum.GetValues(typeof(Cargo));
            cmbCargo.SelectedItem = null;
            BloquearFormulario();
        
        }

        //Actualizar
        private void ActualizarListaFuncionario()
        {
            lstFuncionario.DataSource = null;
            lstFuncionario.DataSource = Funcionario.ObtenerFuncionario();
        }

        //Agregar
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
            cmbCargo.Enabled = true;
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
            cmbCargo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }

        //Editar
        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            Funcionario funcionario = (Funcionario)lstFuncionario.SelectedItem;

            if (funcionario != null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }
        }

        //obtenerFuncionarioFormulario
        private Funcionario ObtenerFuncionarioFormulario()
        {
            Funcionario funcionario = new Funcionario();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                funcionario.id = Convert.ToInt32(txtId.Text);
            }

            funcionario.nro_documento = Convert.ToInt32(txtNroDocumento.Text);
            funcionario.apellido = txtApellido.Text;
            funcionario.nombre = txtNombre.Text;
            funcionario.direccion = txtDireccion.Text;
            funcionario.telefono = txtTelefono.Text;
            funcionario.email = txtEmail.Text;
            funcionario.ruc = txtRuc.Text;
            funcionario.edad = Convert.ToInt32(txtEdad.Text);
            funcionario.cargo = (Cargo)cmbCargo.SelectedItem;
            return funcionario;
           
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Funcionario funcionario = (Funcionario)lstFuncionario.SelectedItem;
            Funcionario.EliminarFuncionario(funcionario);
            ActualizarListaFuncionario();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void lstFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = (Funcionario)lstFuncionario.SelectedItem;

            if (funcionario != null)
            {
                txtId.Text = Convert.ToString(funcionario.id);
                txtNroDocumento.Text = Convert.ToString(funcionario.nro_documento);
                txtApellido.Text = funcionario.apellido;
                txtNombre.Text = funcionario.nombre;
                txtDireccion.Text = funcionario.direccion;
                txtTelefono.Text = funcionario.telefono;
                txtEmail.Text = funcionario.email;
                txtRuc.Text = funcionario.ruc;
                txtEdad.Text = Convert.ToString(funcionario.edad);
                cmbCargo.SelectedItem = funcionario.cargo;

            }
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
            cmbCargo.SelectedItem = null;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Funcionario funcionario = ObtenerFuncionarioFormulario();

                Funcionario.AgregarFuncionario(funcionario);


            }
            else if (modo == "E")
            {
                int index = lstFuncionario.SelectedIndex;

                Funcionario funcionario = ObtenerFuncionarioFormulario();
                Funcionario.EditarFuncionario(index, funcionario);

            }

            ActualizarListaFuncionario();
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}

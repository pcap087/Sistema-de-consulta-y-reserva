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
        public frmFuncionario()
        {
            InitializeComponent();
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

        private void ActualizarListaFuncionario()
        {
            lstFuncionario.DataSource = null;
            lstFuncionario.DataSource = Funcionario.ObtenerFuncionario();
        }

        private Funcionario ObtenerFuncionarioFormulario()
        {
            Funcionario funcionario = new Funcionario();

            funcionario.nro_documento = txtNroDocumento.Text;
            funcionario.apellido = txtApellido.Text;
            funcionario.nombre = txtNombre.Text;
            funcionario.direccion = txtDireccion.Text;
            funcionario.telefono = txtTelefono.Text;
            funcionario.email = txtEmail.Text;
            funcionario.ruc = txtRuc.Text;
            funcionario.edad = txtEdad.Text;
            funcionario.cargo = (cargo)cmbCargo.SelectedItem;
            return funcionario;
        }

        private void frmFuncionario_Load_1(object sender, EventArgs e)
        {
            ActualizarListaFuncionario();
            cmbCargo.DataSource = Enum.GetValues(typeof(cargo));
            cmbCargo.SelectedItem = null;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Funcionario funcionario = ObtenerFuncionarioFormulario();
            Funcionario.AgregarFuncionario(funcionario);
            ActualizarListaFuncionario();
            LimpiarFormulario();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            int index = lstFuncionario.SelectedIndex;
            Funcionario.listaFuncionarios[index] = ObtenerFuncionarioFormulario();
            ActualizarListaFuncionario();
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
                txtNroDocumento.Text = funcionario.nombre;
                txtApellido.Text = funcionario.apellido;
                txtNombre.Text = funcionario.nombre;
                txtDireccion.Text = funcionario.direccion;
                txtTelefono.Text = funcionario.telefono;
                txtEmail.Text = funcionario.email;
                txtRuc.Text = funcionario.ruc;
                txtEdad.Text = funcionario.edad;
                cmbCargo.SelectedItem = funcionario.cargo;

            }
        }
    }
}

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


namespace ProyectoReservasConsultas
{
    public partial class frmClinica : Form
    {
        string modo;
        public frmClinica()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private Clinica ObtenerClinicaFormulario()
        {
            Clinica clinica = new Clinica();

            if (!string.IsNullOrWhiteSpace(txtNroClinica.Text))
            {
                clinica.id = Convert.ToInt32(txtNroClinica.Text);
            }
            
            clinica.descripcion = txtDescripcion.Text;
            clinica.direccion = txtDireccion.Text;
            clinica.ciudad = (Ciudad)cmbCiudad.SelectedItem;
            
            clinica.telefono = (txtTelefono.Text);
            return clinica;
        }

        private void ActualidadListaClinica()
        {
            lstClinica.DataSource = null;
            lstClinica.DataSource = Clinica.ObtenerClinicas();
        }

        private void LimpiarFormulario()
        {
            txtNroClinica.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbCiudad.SelectedItem = null;
            
        }

        private void frmClinica_Load(object sender, EventArgs e)
        {
            Clinica c = new Clinica();
            ActualidadListaClinica();
            cmbCiudad.DataSource = Ciudad.ObtenerCiudades();
            cmbCiudad.SelectedItem = null;
            BloquearFormularioClinica();

        }
        private void BloquearFormularioClinica()
        {
            txtNroClinica.Enabled = false;
            txtDescripcion.Enabled = false;
            txtDireccion.Enabled = false;
            cmbCiudad.Enabled = false;
            
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
        }
        private void DesbloquearFormularioClinica()
        {
            
            txtDescripcion.Enabled = true;
            txtDireccion.Enabled = true;
            cmbCiudad.Enabled = true;
            
            txtTelefono.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
        }


        private void btnAg_Click_1(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormularioClinica();
        }

        

        

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstClinica_Click_1(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)lstClinica.SelectedItem;

            if (clinica != null)
            {
                txtNroClinica.Text = Convert.ToString(clinica.id); ;
                txtDescripcion.Text = clinica.descripcion;
                txtDireccion.Text = clinica.direccion;
                cmbCiudad.SelectedItem = (Ciudad)Ciudad.ObtenerCiudad(clinica.ciudad.id);
            
                txtTelefono.Text = clinica.telefono;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Clinica clinica= ObtenerClinicaFormulario();

                Clinica.AgregarClinica(clinica);
            }
            ActualidadListaClinica();
            LimpiarFormulario();
            BloquearFormularioClinica();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormularioClinica();
        }
    }
}

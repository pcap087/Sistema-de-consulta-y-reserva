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
        public frmClinica()
        {
            InitializeComponent();
        }

        private Clinica ObtenerClinicaFormulario()
        {
            Clinica clinica = new Clinica();

            clinica.nro_clinica = Convert.ToInt16(txtNroClinica.Text);
            clinica.descripcion = txtDescripcion.Text;
            clinica.direccion = txtDireccion.Text;
            clinica.ciudad = (Ciudad)cmbCiudad.SelectedItem;
            clinica.telefono = (txtTelefono.Text);
            return clinica;
        }

        private void ActualidadListaClinica()
        {
            lstClinica.DataSource = null;
            lstClinica.DataSource = Clinica.ObtenerClinica();
        }

        private void LimpiarFormulario()
        {
            txtNroClinica.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbCiudad.SelectedItem = "";
        }


        private void btnAg_Click(object sender, EventArgs e)
        {
            Clinica clinica = ObtenerClinicaFormulario();

            Clinica.listaClinica.Add(clinica);
            ActualidadListaClinica();
            LimpiarFormulario();
        }

        private void frmClinica_Load(object sender, EventArgs e)
        {
            txtNroClinica = null;
            txtDescripcion = null;
            txtDireccion = null;
            txtTelefono = null;
            cmbCiudad.SelectedItem = null;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstClinica.SelectedIndex;
            Clinica.listaClinica[index] = ObtenerClinicaFormulario();

            ActualidadListaClinica();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)lstClinica.SelectedItem;
            Clinica.EliminarClinica(clinica);
            ActualidadListaClinica();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }



        private void lstClinica_Click(object sender, EventArgs e)
        {
            Clinica clinica = (Clinica)lstClinica.SelectedItem;

            if (clinica != null)
            {
                txtNroClinica.Text = Convert.ToString(clinica.nro_clinica);
                txtDescripcion.Text = clinica.descripcion;
                txtDireccion.Text = clinica.direccion;
                txtTelefono.Text = clinica.telefono;
                cmbCiudad.SelectedItem = clinica.ciudad;

            }
        }

  
    }
}

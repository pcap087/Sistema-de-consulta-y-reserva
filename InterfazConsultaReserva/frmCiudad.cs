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
    public partial class frmCiudad : Form
    {
        string modo;
        public frmCiudad()
        {
            
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private Ciudad ObtenerCiudadFormulario()
        {
            Ciudad ciudad = new Ciudad();

            if (!string.IsNullOrWhiteSpace(txtciudad.Text))
            {
                ciudad.id = Convert.ToInt32(txtciudad.Text);
            }
            ciudad.descripcion = txtDescCiudad.Text;

            return ciudad;
        }

        private void ActualidadListaCiudades()
        {
            lstCiudad.DataSource = null;
            lstCiudad.DataSource = Ciudad.ObtenerCiudades();
        }

        private void LimpiarFormulario()
        {
            txtciudad.Text = "";
            txtDescCiudad.Text = "";
        }



        private void frmCiudad_Load(object sender, EventArgs e)
        {
            Ciudad c = new Ciudad();


            ActualidadListaCiudades();
            
            BloquearFormularioCiudad();

        }
        private void DesbloquearFormularioCiudad()
        {
            
            txtDescCiudad.Enabled = true;
            
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        private void BloquearFormularioCiudad()
        {
            txtciudad.Enabled = false;
            txtDescCiudad.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

        }

        

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }



        private void lstCiudad_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = (Ciudad)lstCiudad.SelectedItem;

            if (ciudad != null)
            {
                txtciudad.Text = Convert.ToString(ciudad.id);
                txtDescCiudad.Text = ciudad.descripcion;
               
            }
        }

        private void btnAg_Click_1(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormularioCiudad();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Ciudad ciudad= ObtenerCiudadFormulario();

                Ciudad.AgregarCiudad(ciudad);
            }
            ActualidadListaCiudades();
            LimpiarFormulario();
            BloquearFormularioCiudad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormularioCiudad();
        }
    }
}

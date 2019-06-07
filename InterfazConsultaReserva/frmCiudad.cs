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
        public frmCiudad()
        {
            
            InitializeComponent();
        }


        private Ciudad ObtenerCiudadFormulario()
        {
            Ciudad ciudad = new Ciudad();

            ciudad.nro_ciudad = txtciudad.Text;
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
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstCiudad.SelectedIndex;
            Ciudad.listaCiudades[index] = ObtenerCiudadFormulario();

            ActualidadListaCiudades();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = (Ciudad)lstCiudad.SelectedItem;
            Ciudad.EliminarCiudad(ciudad);
            ActualidadListaCiudades();
            LimpiarFormulario();
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
                txtciudad.Text = Convert.ToString(ciudad.nro_ciudad);
                txtDescCiudad.Text = ciudad.descripcion;
               
            }
        }

        private void btnAg_Click_1(object sender, EventArgs e)
        {
            Ciudad ciudad = ObtenerCiudadFormulario();
            Ciudad.AgregarCiudad(ciudad);
            ActualidadListaCiudades();
            LimpiarFormulario();
        }
    }
}

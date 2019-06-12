using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazConsultaReserva
{
    public partial class frmConsultorio : Form
    {
        string modo;
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void lstConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {
            Consultorio c = new Consultorio();


            ActualizarListaConsultorios();

            BloquearFormulario();

        }
        private void BloquearFormulario()
        {
            txtId.Enabled = false;
            txtDescripcion.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

        }
        private void DesbloquearFormulario()
        {
            txtDescripcion.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        private void ActualizarListaConsultorios()
        {
            lstConsultorio.DataSource = null;
            lstConsultorio.DataSource = Consultorio.ObtenerConsultorios();
        }

        private Consultorio ObtenerConsultorioFormulario()
        {
            Consultorio consultorio = new Consultorio();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                consultorio.id = Convert.ToInt32(txtId.Text);
            }

            consultorio.descripcion = txtDescripcion.Text;
            return consultorio;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Consultorio consultorio = (Consultorio)lstConsultorio.SelectedItem;

            if (consultorio != null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }
        }

        private void lstConsultorio_Click(object sender, EventArgs e)
        {
            Consultorio consultorio = (Consultorio)lstConsultorio.SelectedItem;

            if (consultorio != null)
            {
                txtId.Text = Convert.ToString(consultorio.id);
                txtDescripcion.Text = consultorio.descripcion;

            }
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Consultorio consultorio = ObtenerConsultorioFormulario();

                Consultorio.AgregarConsultorio(consultorio);


            }
            
            ActualizarListaConsultorios();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}

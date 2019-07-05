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

namespace InterfazConsultaReserva
{
    public partial class frmVacacion : Form
    {
        string modo;
        public frmVacacion()
        {
            InitializeComponent();
        }

        private void frmVacacion_Load(object sender, EventArgs e)
        {
            Vacacion v= new Vacacion();


            ActualizarListaVacaciones();
            var medicoId = Medico.ObtenerMedico().ToList();
            cmbMedico.DataSource = medicoId;
            cmbMedico.SelectedItem = null;
            BloquearFormulario();
        }

        private void ActualizarListaVacaciones()
        {
            lstVacaciones.DataSource = null;
            lstVacaciones.DataSource = Vacacion.ObtenerVacaciones();
        }

        private void DesbloquearFormulario()
        {
            cmbMedico.Enabled = true;
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void BloquearFormulario()
        {
            txtId.Enabled = false;
            cmbMedico.Enabled = false;
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void LimpiarFormulario()
        {
            cmbMedico.SelectedItem = null;
            dtpFechaInicio.Value = System.DateTime.Now;
            dtpFechaFin.Value = System.DateTime.Now;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Vacacion vacacion= (Vacacion)lstVacaciones.SelectedItem;

            if (vacacion!= null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vacacion vacacion= (Vacacion)lstVacaciones.SelectedItem;
            if (vacacion!= null)
            {
                Vacacion.EliminarVacacion(vacacion);
                ActualizarListaVacaciones();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
        }

        private Vacacion ObtenerVacacionFormulario()
        {
            Vacacion vacacion= new Vacacion();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                vacacion.id = Convert.ToInt32(txtId.Text);
            }

            
            vacacion.medico = (Medico)cmbMedico.SelectedItem;
            vacacion.fecha_inicio= dtpFechaInicio.Value.Date;
            vacacion.fecha_fin= dtpFechaFin.Value.Date;
            return vacacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Vacacion vacacion = ObtenerVacacionFormulario();

                Vacacion.AgregarVacacion(vacacion);


            }
            else if (modo == "E")
            {
                int index = lstVacaciones.SelectedIndex;

                Vacacion vacacion= ObtenerVacacionFormulario();
                Vacacion.EditarReserva(index,vacacion);

            }

            ActualizarListaVacaciones();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstVacaciones_Click(object sender, EventArgs e)
        {
            Vacacion vacacion= (Vacacion)lstVacaciones.SelectedItem;

            if (vacacion!= null)
            {
                txtId.Text = Convert.ToString(vacacion.id);
                cmbMedico.SelectedItem = (Medico)Medico.ObtenerMed(vacacion.medico.id);
                dtpFechaInicio.Value = vacacion.fecha_inicio;
                dtpFechaFin.Value = vacacion.fecha_fin;
                

            }
        }
    }
}

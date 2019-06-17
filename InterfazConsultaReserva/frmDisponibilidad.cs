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
    public partial class frmDisponibilidad : Form
    {
        string modo;
        public frmDisponibilidad()
        {
            InitializeComponent();
        }


        private void ActualizarListaDisponibilidades()
        {
            lstDisponibilidad.DataSource = null;
            lstDisponibilidad.DataSource = Disponibilidad.ObtenerDisponibildades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();

        }
        private void BloquearFormulario()
        {
            txtId.Enabled = false;
            cmbMedico.Enabled = false;
            cmbTurno.Enabled = false;
            clbDias.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

        }
        private void DesbloquearFormulario()
        {
            
            cmbMedico.Enabled = true;
            cmbTurno.Enabled = true;
            clbDias.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        private void LimpiarFormulario()
        {
            txtId.Text = "";
            cmbMedico.SelectedItem = null;
            cmbTurno.SelectedItem = null;
            ResetearCheckedListBox();

        }
        private void ResetearCheckedListBox()
        {
            clbDias.SetItemChecked(0, false);
            clbDias.SetItemChecked(1, false);
            clbDias.SetItemChecked(2, false);
            clbDias.SetItemChecked(3, false);
            clbDias.SetItemChecked(4, false);
            clbDias.SetItemChecked(5, false);
            clbDias.SetItemChecked(6, false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Disponibilidad disponibilidad= ObtenerDisponibilidadFormulario();

                Disponibilidad.AgregarDisponibilidad(disponibilidad);
            }
            ActualizarListaDisponibilidades();
            LimpiarFormulario();
            BloquearFormulario();
        }
        private Disponibilidad ObtenerDisponibilidadFormulario()
        {
            Disponibilidad disponibilidad= new Disponibilidad();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                disponibilidad.id = Convert.ToInt32(txtId.Text);
            }

            
            
            disponibilidad.medico= (Medico)cmbMedico.SelectedItem;
            disponibilidad.turno = (Turno)cmbTurno.SelectedItem;
            
            disponibilidad.dias_atencion= clbDias.CheckedItems.Cast<String>().ToList();
            return disponibilidad;
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

        private void frmDisponibilidad_Load(object sender, EventArgs e)
        {
            Disponibilidad dd = new Disponibilidad();


            ActualizarListaDisponibilidades();
            cmbMedico.DataSource = Medico.ObtenerMedico();
            cmbTurno.DataSource = Turno.ObtenerTurnos();
            cmbMedico.SelectedItem = null;
            cmbTurno.SelectedItem = null;
            BloquearFormulario();
        }

        private void lstDisponibilidad_Click(object sender, EventArgs e)
        {
            Disponibilidad disponibilidad= (Disponibilidad)lstDisponibilidad.SelectedItem;

            if (disponibilidad!= null)
            {
                txtId.Text = Convert.ToString(disponibilidad.id);
                cmbTurno.SelectedItem = (Turno)Turno.ObtenerTurno(disponibilidad.turno.id);
                cmbMedico.SelectedItem = (Medico)Medico.ObtenerMed(disponibilidad.medico.id);
                
                foreach (string dia in disponibilidad.dias_atencion)
                {
                    if (dia == "L") clbDias.SetItemChecked(0, true);
                    else if (dia == "M") clbDias.SetItemChecked(1, true);
                    else if (dia == "X") clbDias.SetItemChecked(2, true);
                    else if (dia == "J") clbDias.SetItemChecked(3, true);
                    else if (dia == "V") clbDias.SetItemChecked(4, true);
                    else if (dia == "S") clbDias.SetItemChecked(5, true);
                    else if (dia == "D") clbDias.SetItemChecked(6, true);


                }
                if (true)
                {

                }

            }
        }
    }
}

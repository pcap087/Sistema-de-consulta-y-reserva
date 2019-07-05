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
using System.Data.SqlClient;

namespace InterfazConsultaReserva
{
    public partial class frmReserva : Form
    {
        string modo;
        public frmReserva()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            Reserva r = new Reserva();


            ActualizarListaReservas();
            cmbEstado.DataSource = Enum.GetValues(typeof(Estados));
            cmbPaciente.DataSource = Paciente.ObtenerPaciente();
            var medicoId = Medico.ObtenerMedico().ToList();
            cmbMedico.DataSource = medicoId;
            cmbFuncionario.DataSource = Funcionario.ObtenerFuncionario();
            cmbEstado.SelectedItem = 0;
            cmbPaciente.SelectedItem = 0;
            cmbMedico.SelectedItem = 0;
            cmbFuncionario.SelectedItem = 0;
            BloquearFormulario();

        }

        private void BloquearFormulario()
        {
            txtId.Enabled = false;
            cmbPaciente.Enabled = false;
            cmbMedico.Enabled = false;
            cmbFuncionario.Enabled = false;
            dtpFechaRegistro.Enabled = false;
            dtpFechaReserva.Enabled = false;
            cmbEstado.Enabled = false;
            txtMonto.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void DesbloquearFormulario()
        {

            cmbPaciente.Enabled = true;
            cmbMedico.Enabled = true;
            cmbFuncionario.Enabled = true;
            dtpFechaReserva.Enabled = true;
            cmbEstado.Enabled = true;
            txtMonto.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void LimpiarFormulario()
        {

            cmbPaciente.SelectedItem = null;
            cmbMedico.SelectedItem = null;
            cmbFuncionario.SelectedItem = null;
            dtpFechaRegistro.Value = System.DateTime.Now;
            dtpFechaReserva.Value = System.DateTime.Now;
            cmbEstado.SelectedItem = null;
            txtMonto.Text = "";

        }

        private void ActualizarListaReservas()
        {
            lstReservas.DataSource = null;
            lstReservas.DataSource = Reserva.ObtenerReservas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Reserva reserva = (Reserva)lstReservas.SelectedItem;

            if (reserva != null)
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
            Reserva reserva = (Reserva)lstReservas.SelectedItem;
            if (reserva != null)
            {
                Reserva.EliminarReserva(reserva);
                ActualizarListaReservas();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
        }

        private Reserva ObtenerReservaFormulario()
        {
            Reserva reserva = new Reserva();

            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                reserva.id = Convert.ToInt32(txtId.Text);
            }

            reserva.paciente = (Paciente)cmbPaciente.SelectedItem;
            reserva.medico = (Medico)cmbMedico.SelectedItem;
            reserva.funcionario = (Funcionario)cmbFuncionario.SelectedItem;
            reserva.fecha_registro = dtpFechaRegistro.Value.Date;
            reserva.fecha_reservada = dtpFechaReserva.Value.Date;
            reserva.estados = (Estados)cmbEstado.SelectedItem;
            reserva.monto = Convert.ToDouble(txtMonto.Text);
            return reserva;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string V_VALOR = "";

            if (dtpFechaReserva.Value < System.DateTime.Today)
            {
                MessageBox.Show("La fecha de la reserva no puede ser menor a la Fecha actual", "Advertencia");
                dtpFechaReserva.Focus();
                V_VALOR = "-1";
                return;
            }

            

            if (cmbPaciente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Advertencia");
                cmbPaciente.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbMedico.SelectedIndex <0)
            {
                MessageBox.Show("Debe seleccionar un médico", "Advertencia");
                cmbMedico.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un estado", "Advertencia");
                cmbEstado.Focus();
                V_VALOR = "-1";
                return;
            }

            if (cmbFuncionario.SelectedIndex <0)
            {
                MessageBox.Show("Debe seleccionar un funcionario", "Advertencia");
                cmbFuncionario.Focus();
                V_VALOR = "-1";
                return;
            }

            try
            {
                int result = int.Parse(txtMonto.Text);
            }
            catch
            {
                MessageBox.Show("Favor introduzca un valor numerico");
                txtMonto.Text = "";
                txtMonto.SelectAll();
                txtMonto.Focus();
                V_VALOR = "-1";
            }
            if (V_VALOR == "")
            {
                if (modo == "I")
                {
                    Reserva reserva = ObtenerReservaFormulario();

                    Reserva.AgregarReserva(reserva);


                }
                else if (modo == "E")
                {
                    int index = lstReservas.SelectedIndex;

                    Reserva reserva = ObtenerReservaFormulario();
                    Reserva.EditarReserva(index, reserva);

                }
            }

            ActualizarListaReservas();
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

        private void lstReservas_Click(object sender, EventArgs e)
        {
            Reserva reserva = (Reserva)lstReservas.SelectedItem;

            try
            { 

                if (reserva != null)
                {
                    txtId.Text = Convert.ToString(reserva.id);
                    cmbPaciente.SelectedItem = (Paciente)Paciente.ObtenerPacienteParametro(reserva.paciente.id);
                    cmbMedico.SelectedItem = (Medico)Medico.ObtenerMed(reserva.medico.id);
                    cmbFuncionario.SelectedItem = (Funcionario)Funcionario.ObtenerFuncionarioParametro(reserva.funcionario.id);
                    dtpFechaRegistro.Value = reserva.fecha_registro;
                    dtpFechaReserva.Value = reserva.fecha_reservada;
                    cmbEstado.SelectedItem = (Estados)reserva.estados;
                    txtMonto.Text = Convert.ToString(reserva.monto);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var medicoId = (Medico)cmbMedico.SelectedItem;

            try
            {
                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
                {
                    con.Open();

                    string textoCmd = "Select t.descripcion, d.dias_atencion, t.hora_inicio, t.hora_fin " +
                    "from Disponibilidad d join medico m on m.id = d.medico join turno  t on d.turno = t.id " +
                    "where d.medico = " + medicoId.id + " order by t.descripcion";


                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlDataAdapter adap = new SqlDataAdapter(textoCmd, con);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    frmConsulta dd = new frmConsulta(ds);
                    dd.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

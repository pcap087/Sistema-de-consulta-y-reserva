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
    public partial class frmCancelarReserva : Form
    {
        public frmCancelarReserva()
        {
            InitializeComponent();
        }

        private void frmCancelarReserva_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = Reserva.ObtenerReservaPendientes();
            dgvReservas.Columns[1].Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<int> listaIds = new List<int>();
            foreach (DataGridViewRow registro in dgvReservas.Rows)
            {
                if (registro.Cells[0].Value == null) registro.Cells[0].Value = false;
                if ((bool)registro.Cells[0].Value == true)
                {
                    listaIds.Add((int)registro.Cells[1].Value);

                }

            }
            Reserva.CancelarReservas(listaIds);
            ActualizarDataGrid();
        }
    }
}

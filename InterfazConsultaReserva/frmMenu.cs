using ProyectoReservasConsultas;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void tsmMedico_Click(object sender, EventArgs e)
        {
            frmMedico form = new frmMedico();
            form.Show();
        }

        private void tsmFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario form = new frmFuncionario();
            form.Show();
        }

        private void tsmPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente form = new frmPaciente();
            form.Show();

        }

        private void tsmTurno_Click(object sender, EventArgs e)
        {
            frmTurno form = new frmTurno();
            form.Show();
        }

        private void clinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClinica form = new frmClinica();
            form.Show();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudad form = new frmCiudad();
            form.Show();
        }

        private void consultorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultorio form = new frmConsultorio();
            form.Show();
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisponibilidad form = new frmDisponibilidad();
            form.Show();
        }

        private void tsmReserva_Click(object sender, EventArgs e)
        {
            frmReserva form = new frmReserva();
            form.Show();
        }

        private void tsmCita_Click(object sender, EventArgs e)
        {
            frmCita form = new frmCita();
            form.Show();
        }
    }
}

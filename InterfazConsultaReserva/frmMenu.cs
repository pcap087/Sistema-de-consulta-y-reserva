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
    }
}

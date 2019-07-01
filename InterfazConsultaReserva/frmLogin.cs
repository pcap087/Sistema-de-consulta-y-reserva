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
using InterfazConsultaReserva;

namespace InterfazCarniceria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Favor Ingresa el Usuario");
                return;
            }

            if (txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Favor Ingresa la clave");
                return;
            }

            if (Usuario.Autenticar(txtUsuario.Text, txtPassword.Text))
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                frmMenu elmenuPrincipal = new frmMenu();
                elmenuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearUsuario form = new frmCrearUsuario();
            form.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

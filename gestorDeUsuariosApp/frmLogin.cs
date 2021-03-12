using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorDeUsuariosApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            try
            {
                Controlador ctrl = new Controlador();
                string respuesta = ctrl.ctrlLogin(usuario, password);
                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Avizo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmPrincipal frm = new frmPrincipal();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Avizo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

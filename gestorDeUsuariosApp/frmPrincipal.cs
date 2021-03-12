using MySql.Data.MySqlClient;
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
    public partial class frmPrincipal : Form
    {
        int tipoUsuario;
        public frmPrincipal()
        {
            InitializeComponent();

            txtNombre.Text = Session.nombre;

            tipoUsuario = Session.id_tipo;

            if(tipoUsuario == 1)
            {
                this.subMenuRegistrarUsuario.Visible = true;
                
            }
            else
            {
                this.subMenuRegistrarUsuario.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnActualizar.Visible = false;
            }

        }

        private void subMenuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            formRegistro frmRegistro = new formRegistro();
            frmRegistro.Visible = true;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void menuCerrarSession_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();
            frm.Visible = true;

            Session ss = new Session();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreUsuario.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT id, usuario, password, nombre, id_tipo FROM usuarios WHERE nombre LIKE '" + nombre + "' LIMIT 1";
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtNombreUsuario.Text = reader.GetString(3);
                        txtIdTipo.Text = reader.GetString(4);
                        txtTipoUsuario.Text = reader.GetString(1);
                        txtPass.Text = reader.GetString(2);
                        txtConfirPass.Text = reader.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            String nombre = txtNombreUsuario.Text;
            int id_tipo = int.Parse(txtIdTipo.Text);
            String usuario = txtTipoUsuario.Text;
            String password = Controlador.generarSHA1(txtPass.Text);
            String conPassword = Controlador.generarSHA1(txtConfirPass.Text);

            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtIdTipo.Text) || string.IsNullOrEmpty(txtTipoUsuario.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtConfirPass.Text))
            {
                MessageBox.Show("Para actulizar, todos los campos deber ser llenados");
            }
            else
            {
                if (password == conPassword)
                {
                    string sql = "UPDATE usuarios SET usuario='" + usuario + "', password='" + password + "', nombre='" + nombre + "', id_tipo='" + id_tipo + "' WHERE id='" + id + "'";
                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro actualizado");
                        limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al actualizar: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Para actulizar, las contrasenas deben coincidir");
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            string sql = "DELETE FROM usuarios WHERE id='" + id + "'";

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void limpiar()
        {
            txtId.Text = "";
            txtNombreUsuario.Text = "";
            txtIdTipo.Text = "";
            txtTipoUsuario.Text = "";
            txtPass.Text = "";
            txtConfirPass.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

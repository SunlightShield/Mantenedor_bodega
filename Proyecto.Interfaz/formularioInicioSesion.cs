using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocio;

namespace Proyecto.Interfaz
{
    public partial class formularioInicioSesion : Form
    {
        public formularioInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.IniciarSesion(txtCorreo.Text.Trim(), txtClave.Text.Trim());
                if (Tabla.Rows.Count<=0)
                {
                    MessageBox.Show("Correo o contraseña incorrecto", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][4])==false)
                    {
                        MessageBox.Show("El usuario no está activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FormularioPrincipal fPrinc = new FormularioPrincipal();
                        Variables.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);//
                        fPrinc.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        fPrinc.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        fPrinc.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        fPrinc.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        fPrinc.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        fPrinc.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

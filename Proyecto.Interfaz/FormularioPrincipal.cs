using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Interfaz
{
    public partial class FormularioPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            stBarraInferior.Text = "Desarrollado por" + this.Nombre;
            MessageBox.Show("Bienvenido " + this.Nombre, "Sistema de ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (this.Rol.Equals("Administrador"))
            {
                ItemBodega.Enabled = true;
                ItemVentanas.Enabled = true;
                ItemVentas.Enabled = true;
                ItemPermisos.Enabled = true;
                ItemConsultas.Enabled = true;
            }
            else
            {
                if (this.Rol.Equals("Vendedor"))
                {
                    ItemBodega.Enabled = false;
                    ItemVentanas.Enabled = false;
                    ItemVentas.Enabled = true;
                    ItemPermisos.Enabled = false;
                    ItemConsultas.Enabled = true;
                } 
                else
                {
                    if (this.Rol.Equals("Almacenero"))
                    {
                        ItemBodega.Enabled = true;
                        ItemVentanas.Enabled = true;
                        ItemVentas.Enabled = false;
                        ItemPermisos.Enabled = false;
                        ItemConsultas.Enabled = true;
                    }
                    else
                    {
                        ItemBodega.Enabled = false;
                        ItemVentanas.Enabled = false;
                        ItemVentas.Enabled = false;
                        ItemPermisos.Enabled = false;
                        ItemConsultas.Enabled = false;
                    }
                }
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCategoria frm = new FormularioCategoria();
            frm.MdiParent = this; //hacemos que el formulario principal sea el padre de categoria
            frm.Show();

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioArticulo frm = new FormularioArticulo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRol frm = new FormularioRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioUsuario frm = new FormularioUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ItemSalida_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del sistema?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(opcion == DialogResult.OK)
            {
                Application.Exit();
            } 
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioProveedores frm = new formularioProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioClientes frm = new formularioClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioIngresos frm = new formularioIngresos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formularioVentas frm = new formularioVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioConsultaFechaVentas frm = new formularioConsultaFechaVentas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

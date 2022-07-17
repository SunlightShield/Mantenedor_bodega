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
    public partial class formularioVista_ClienteVenta : Form
    {
        public formularioVista_ClienteVenta()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                DataGridListado.DataSource = NPersona.BuscarClientes(txtBuscar.Text);
                this.Formato();
                TotalRegistros.Text = "Total Registros: " + Convert.ToString(DataGridListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//
            }
        }

        private void Formato()
        {
            DataGridListado.Columns[0].Visible = false;
            DataGridListado.Columns[1].Width = 50;
            DataGridListado.Columns[2].Width = 100;
            DataGridListado.Columns[2].HeaderText = "Tipo persona";
            DataGridListado.Columns[3].Width = 170;
            DataGridListado.Columns[4].Width = 100;
            DataGridListado.Columns[4].HeaderText = "Documento";
            DataGridListado.Columns[5].Width = 100;
            DataGridListado.Columns[5].HeaderText = "Número documento";
            DataGridListado.Columns[6].Width = 120;
            DataGridListado.Columns[6].HeaderText = "Dirección";
            DataGridListado.Columns[7].Width = 100;
            DataGridListado.Columns[7].HeaderText = "Teléfono";
            DataGridListado.Columns[8].Width = 120;
        }

        private void formularioVista_ClienteVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DataGridListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdCliente = Convert.ToInt32(DataGridListado.CurrentRow.Cells["ID"].Value);
            Variables.NombreCliente = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
            this.Close();
        }
    }
}

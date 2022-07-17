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
    public partial class FormularioRol : Form
    {
        public FormularioRol()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DataGridListado.DataSource = NRoles.Listar(); //hacemos referencia a clase y metodo, para no crear objetos
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
            DataGridListado.Columns[0].Width = 100;
            DataGridListado.Columns[0].HeaderText = "Id";
            DataGridListado.Columns[1].Width = 200;
            DataGridListado.Columns[1].HeaderText = "Nombre";
        }

        private void FormularioRol_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}

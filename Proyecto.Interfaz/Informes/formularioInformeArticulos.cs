using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Interfaz.Informes
{
    public partial class formularioInformeArticulos : Form
    {
        public formularioInformeArticulos()
        {
            InitializeComponent();
        }

        private void formularioInformeArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosProyecto.articulo_listar' Puede moverla o quitarla según sea necesario.
            this.articulo_listarTableAdapter.Fill(this.DatosProyecto.articulo_listar);

            this.reportViewer1.RefreshReport();
        }
    }
}

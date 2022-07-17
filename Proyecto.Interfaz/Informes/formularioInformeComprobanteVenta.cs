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
    public partial class formularioInformeComprobanteVenta : Form
    {
        public formularioInformeComprobanteVenta()
        {
            InitializeComponent();
        }

        private void formularioInformeComprobanteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosProyecto.venta_comprobante' Puede moverla o quitarla según sea necesario.
            this.venta_comprobanteTableAdapter.Fill(this.DatosProyecto.venta_comprobante, Variables.IdVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}

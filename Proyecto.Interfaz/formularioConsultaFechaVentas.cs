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
    public partial class formularioConsultaFechaVentas : Form
    {
        public formularioConsultaFechaVentas()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                DataGridListado.DataSource = NVentas.ConsultaFechas(Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                this.Formato();
                this.LimpiarIngresos();
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
            DataGridListado.Columns[1].Visible = false;
            DataGridListado.Columns[2].Visible = false;
            DataGridListado.Columns[0].Width = 100;
            DataGridListado.Columns[3].Width = 150;
            DataGridListado.Columns[4].Width = 150;
            DataGridListado.Columns[5].Width = 100;
            DataGridListado.Columns[5].HeaderText = "Documento";
            DataGridListado.Columns[6].Width = 70;
            DataGridListado.Columns[6].HeaderText = "Serie";
            DataGridListado.Columns[7].Width = 70;
            DataGridListado.Columns[7].HeaderText = "Número";
            DataGridListado.Columns[8].Width = 60;
            DataGridListado.Columns[9].Width = 100;
            DataGridListado.Columns[10].Width = 100;
            DataGridListado.Columns[11].Width = 100;
        }
        //metodos de error, lipieza de datos e ingresos correctos
        private void LimpiarIngresos()//limpiar todos los parametros
        {
            DataGridListado.Columns[0].Visible = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeCorrecto(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formularioConsultaFechaVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DataGridListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DgvMostrarDetalles.DataSource = NVentas.ListarDetalle(Convert.ToInt32(DataGridListado.CurrentRow.Cells["ID"].Value));
                decimal total, subTotal;
                decimal Impuesto = Convert.ToDecimal(DataGridListado.CurrentRow.Cells["Impuesto"].Value);
                total = Convert.ToDecimal(DataGridListado.CurrentRow.Cells["Total"].Value);
                subTotal = total / (1 + Impuesto);
                txtSubtotalD.Text = subTotal.ToString("#0.00#");
                txtTotalImpuestoD.Text = (total - subTotal).ToString("#0.00#");
                txtTotalD.Text = total.ToString("#0.00#");
                panelMostrarDetalles.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.IdVenta = Convert.ToInt32(DataGridListado.CurrentRow.Cells["ID"].Value);
                Informes.formularioInformeComprobanteVenta informe = new Informes.formularioInformeComprobanteVenta();
                informe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCerrarDetalles_Click(object sender, EventArgs e)
        {
            panelMostrarDetalles.Visible = false;
        }
    }
}

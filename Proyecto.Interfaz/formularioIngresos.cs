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
    public partial class formularioIngresos : Form
    {

        private DataTable detalles = new DataTable();
        public formularioIngresos()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DataGridListado.DataSource = NIngresos.Listar(); //hacemos referencia a clase y metodo, para no crear objetos
                this.Formato();
                this.LimpiarIngresos();
                TotalRegistros.Text = "Total Registros: " + Convert.ToString(DataGridListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//
            }
        }

        private void Buscar()
        {
            try
            {
                DataGridListado.DataSource = NIngresos.Buscar(txtBuscar.Text);
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
        private void LimpiarIngresos()//limpiar todos los parametros
        {
            textBoxId.Clear();
            txtBuscar.Clear();
            txtCodigo.Clear();
            txtIdProveedor.Clear();
            txtNombreProveedor.Clear();
            txtSerieComprobante.Clear();
            txtNumComprobante.Clear();
            detalles.Clear();
            txtSubtotal.Text = "0.00";
            txtTotalImpuesto.Text = "0.00";
            txtTotal.Text = "0.00";

            DataGridListado.Columns[0].Visible = false;
            BtnAnular.Visible = false;
            checkBoxSeleccionar.Checked = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CrearTabla()
        {
            this.detalles.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.detalles.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.detalles.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.detalles.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.detalles.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.detalles.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            dgvDetalles.DataSource = this.detalles;

            dgvDetalles.Columns[0].Visible = false; //inicialmente coloqué el DataGridListado, pero los cambie por el dgvDetalles todo hacia abajo
            dgvDetalles.Columns[1].HeaderText = "CODIGO";
            dgvDetalles.Columns[1].Width = 100;
            dgvDetalles.Columns[2].HeaderText = "ARTICULO";
            dgvDetalles.Columns[2].Width = 200;
            dgvDetalles.Columns[3].HeaderText = "CANTIDAD";
            dgvDetalles.Columns[3].Width = 70;
            dgvDetalles.Columns[4].HeaderText = "PRECIO";
            dgvDetalles.Columns[4].Width = 70;
            dgvDetalles.Columns[5].HeaderText = "IMPORTE";
            dgvDetalles.Columns[5].Width = 80;

            dgvDetalles.Columns[1].ReadOnly = true;
            dgvDetalles.Columns[2].ReadOnly = true;
            dgvDetalles.Columns[5].ReadOnly = true;
        }

        private void FormatoArticulos()
        {
            DgvArticulos.Columns[1].Visible = false;
            DgvArticulos.Columns[2].Width = 100;
            DgvArticulos.Columns[2].HeaderText = "Categoria";
            DgvArticulos.Columns[3].Width = 100;
            DgvArticulos.Columns[3].HeaderText = "Códigos";
            DgvArticulos.Columns[4].Width = 150;
            DgvArticulos.Columns[5].Width = 100;
            DgvArticulos.Columns[5].HeaderText = "Precio Venta";
            DgvArticulos.Columns[6].Width = 60;
            DgvArticulos.Columns[7].Width = 200;
            DgvArticulos.Columns[7].HeaderText = "Descripción";
            DgvArticulos.Columns[8].Width = 100;
        }
        private void formularioIngresos_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            formularioVista_Proveedor vista = new formularioVista_Proveedor();
            vista.ShowDialog();
            txtIdProveedor.Text = Convert.ToString(Variables.IdProveedor);
            txtNombreProveedor.Text = Variables.NombreProveedor;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable tabla = new DataTable();
                    tabla = Narticulo.BuscarCodigo(txtCodigo.Text.Trim());
                    if (tabla.Rows.Count<=0)
                    {
                        this.MensajeError("No existe ese articulo con ese código de barras");
                    }
                    else
                    {
                        this.AgregarDetalle(Convert.ToInt32(tabla.Rows[0][0]), Convert.ToString(tabla.Rows[0][1]), Convert.ToString(tabla.Rows[0][2]), Convert.ToDecimal(tabla.Rows[0][3]));
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, decimal Precio)
        {
            bool agregar = true;
            foreach (DataRow FilaTemp in detalles.Rows)
            {
                if(Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo)
                {
                    agregar = false;
                    this.MensajeError("El articulo ya existe");
                }
            }

            if (agregar)
            {
                DataRow Fila = detalles.NewRow();
                Fila["idarticulo"] = IdArticulo;
                Fila["codigo"] = Codigo;
                Fila["articulo"] = Nombre;
                Fila["cantidad"] = 1;
                Fila["precio"] = Precio;
                Fila["importe"] = Precio;
                this.detalles.Rows.Add(Fila);
                this.CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            decimal total = 0;
            decimal subTotal = 0;
            if (dgvDetalles.Rows.Count==0)
            {
                total = 0;
            }
            else
            {
                foreach (DataRow FilaTemp in detalles.Rows)
                {
                    total = total + Convert.ToDecimal(FilaTemp["importe"]);
                }
            }
            
            subTotal = total / (1 + Convert.ToDecimal(txtImpuesto.Text));
            txtTotal.Text = total.ToString("#0.00#");
            txtSubtotal.Text = subTotal.ToString("#0.00#");
            txtTotalImpuesto.Text = (total-subTotal).ToString("#0.00#");
        }
        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = true;
        }

        private void btnCerrarArticulo_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
        }

        private void btnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                DgvArticulos.DataSource = Narticulo.BuscarVenta(txtBuscarArticulo.Text.Trim());
                this.FormatoArticulos();
                LblTotalArticulos.Text = "Total artículos: " + Convert.ToString(DgvArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArticulo;
            string Codigo, Nombre;
            decimal Precio;
            idArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            this.AgregarDetalle(idArticulo, Codigo, Nombre, Precio);
        }

        private void dgvDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow fila = (DataRow)detalles.Rows[e.RowIndex];
            decimal precio = Convert.ToDecimal(fila["precio"]);
            int cantidad = Convert.ToInt32(fila["cantidad"]);
            fila["importe"] = precio * cantidad;
            this.CalcularTotales();
        }

        private void dgvDetalles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (txtIdProveedor.Text == string.Empty || txtImpuesto.Text == string.Empty || txtNumComprobante.Text == string.Empty || detalles.Rows.Count==0)
                {
                    this.MensajeError("Campos vacio, por favor rellenelos, ");
                    error.SetError(txtIdProveedor, "seleccione proveedor");
                    error.SetError(txtImpuesto, "ingrese una cifra de impuesto");
                    error.SetError(txtNumComprobante, "ingrese un numero de comprobante");
                    error.SetError(dgvDetalles, "ingrese al menos un detalle");
                }
                else
                {
                    Respuesta = NIngresos.Insertar(Convert.ToInt32(txtIdProveedor.Text.Trim()), Variables.IdUsuario, cbBxComprobante.Text, txtSerieComprobante.Text.Trim(), txtNumComprobante.Text.Trim(), Convert.ToDecimal(txtImpuesto.Text), Convert.ToDecimal(txtTotal.Text), detalles);//enviar a la capa negocio
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeCorrecto("guardado correctamente");
                        this.LimpiarIngresos();
                        this.Listar();
                        tabControl1.SelectedIndex = 1;
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DataGridListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DgvMostrarDetalles.DataSource = NIngresos.ListarDetalle(Convert.ToInt32(DataGridListado.CurrentRow.Cells["ID"].Value));
                decimal total, subTotal;
                decimal Impuesto = Convert.ToDecimal(DataGridListado.CurrentRow.Cells["Impuesto"].Value);
                total = Convert.ToDecimal(DataGridListado.CurrentRow.Cells["Total"].Value);
                subTotal = total / (1 + Impuesto);
                txtSubtotalD.Text = subTotal.ToString("#0.00#");
                txtTotalImpuestoD.Text = (total-subTotal).ToString("#0.00#");
                txtTotalD.Text = total.ToString("#0.00#");
                panelMostrarDetalles.Visible = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarIngresos();
            tabControl1.SelectedIndex = 0; //tabgeneral
        }

        private void DataGridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell CheckBoxEliminar = (DataGridViewCheckBoxCell)DataGridListado.Rows[e.RowIndex].Cells["Seleccionar"];
                CheckBoxEliminar.Value = !Convert.ToBoolean(CheckBoxEliminar.Value);
            }
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeleccionar.Checked)
            {
                DataGridListado.Columns[0].Visible = true;
                BtnAnular.Visible = true;
            }
            else
            {
                DataGridListado.Columns[0].Visible = false;
                BtnAnular.Visible = false;
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("desea anular el resgistro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//el resultado de los botones se guarda en opcion
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in DataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))// si la celda 0 es true
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Respuesta = NIngresos.Anular(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
                            
                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeCorrecto("Se anuló el registro");
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtNumComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}

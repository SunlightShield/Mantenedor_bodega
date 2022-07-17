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
    public partial class formularioProveedores : Form
    {
        private string NombreAnterior;

        public formularioProveedores()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DataGridListado.DataSource = NPersona.ListarProveedores();
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
                DataGridListado.DataSource = NPersona.BuscarProveedores(txtBuscar.Text);
                this.Formato();
                TotalRegistros.Text = "Total Registros: " + Convert.ToString(DataGridListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//
            }
        }
        //Formato del formulario
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
        //metodos de error, lipieza de datos e ingresos correctos
        private void LimpiarIngresos()//limpiar todos los parametros
        {
            txtBuscar.Clear();
            textBoxNombre.Clear();
            textBoxId.Clear();
            TxtBxNumeroDoc.Clear();
            TxtBxDireccion.Clear();
            TxtBxFono.Clear();
            txtBxEmail.Clear();
            btnGuardar.Visible = true;
            BtnActualizar.Visible = false;
            error.Clear();

            DataGridListado.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
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

        private void formularioProveedores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (textBoxNombre.Text == string.Empty)
                {
                    this.MensajeError("Campos vacio, por favor rellenelos, ");
                    error.SetError(textBoxNombre, "ingrese nombre");
                }
                else
                {
                    Respuesta = NPersona.Insertar("Proveedor", textBoxNombre.Text.Trim(), CbBxTipoDoc.Text, TxtBxNumeroDoc.Text.Trim(), TxtBxDireccion.Text.Trim(), TxtBxFono.Text.Trim(), txtBxEmail.Text.Trim());
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeCorrecto("guardado correctamente");
                        this.LimpiarIngresos();
                        this.Listar();
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
                this.LimpiarIngresos();
                BtnActualizar.Visible = true;
                btnGuardar.Visible = true;
                textBoxId.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["ID"].Value);
                this.NombreAnterior = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
                textBoxNombre.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
                CbBxTipoDoc.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtBxNumeroDoc.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Num_Documento"].Value);
                TxtBxDireccion.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Direccion"].Value);
                TxtBxFono.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Telefono"].Value);
                txtBxEmail.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Email"].Value);
                tabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione la celda");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (textBoxId.Text == string.Empty || textBoxNombre.Text == string.Empty)
                {
                    this.MensajeError("Campos vacio, por favor rellenelos, ");
                    error.SetError(textBoxNombre, "ingrese nombre");
                }
                else
                {
                    Respuesta = NPersona.Actualizar(Convert.ToInt32(textBoxId.Text), "Proveedor", this.NombreAnterior, textBoxNombre.Text.Trim(), CbBxTipoDoc.Text, TxtBxNumeroDoc.Text.Trim(), TxtBxDireccion.Text.Trim(), TxtBxFono.Text.Trim(), txtBxEmail.Text.Trim());
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeCorrecto("registro actualizado correctamente");
                        this.LimpiarIngresos();
                        this.Listar();
                        //tabGeneral.SelectedIndex = 1;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarIngresos();
            tabGeneral.SelectedIndex = 0;
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeleccionar.Checked)
            {
                DataGridListado.Columns[0].Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DataGridListado.Columns[0].Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void DataGridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell CheckBoxEliminar = (DataGridViewCheckBoxCell)DataGridListado.Rows[e.RowIndex].Cells["Seleccionar"];
                CheckBoxEliminar.Value = !Convert.ToBoolean(CheckBoxEliminar.Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("desea eliminar el resgistro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//el resultado de los botones se guarda en opcion
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in DataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))// si la celda 0 es true
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Respuesta = NPersona.Eliminar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeCorrecto("Se eliminó el registro");
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

        private void TxtBxFono_KeyPress(object sender, KeyPressEventArgs e)
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

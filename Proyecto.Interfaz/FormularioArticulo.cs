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
using System.Drawing.Imaging;
using System.IO;


namespace Proyecto.Interfaz
{
    public partial class FormularioArticulo : Form
    {
        private string RutaOrigen; //donde esta la imagen
        private string RutaDestino; //Carpeta donde cargar la imagen
        //TODO
        private string Carpeta = "C:\\imagenesProyecto\\"; //crea la carpeta donde se guardaran las imagenes y copia-pega la ruta

        public string nombreOriginal;
        public FormularioArticulo()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DataGridListado.DataSource = Narticulo.Listar(); //hacemos referencia a clase y metodo, para no crear objetos
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
                DataGridListado.DataSource = Narticulo.Buscar(txtBuscar.Text);
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
            DataGridListado.Columns[2].Visible = false;
            DataGridListado.Columns[0].Width = 100;
            DataGridListado.Columns[1].Width = 50;
            DataGridListado.Columns[3].Width = 100;
            DataGridListado.Columns[3].HeaderText = "Categoria";
            DataGridListado.Columns[4].Width = 100;
            DataGridListado.Columns[4].HeaderText = "Codigo";
            DataGridListado.Columns[5].Width = 150;
            DataGridListado.Columns[6].Width = 100;
            DataGridListado.Columns[6].HeaderText = "Precio Venta";
            DataGridListado.Columns[7].Width = 100;
            DataGridListado.Columns[8].Width = 200;
            DataGridListado.Columns[8].HeaderText = "Descripcion"; 
            DataGridListado.Columns[9].Width = 100;
            DataGridListado.Columns[10].Width = 200;
            DataGridListado.Columns[11].HeaderText = "Stock Minimo";
            DataGridListado.Columns[12].Width = 100;
            DataGridListado.Columns[13].Width = 100;
        }
        //metodos de error, lipieza de datos e ingresos correctos
        private void LimpiarIngresos()//limpiar todos los parametros
        {
            textBoxId.Clear();
            textBoxNombre.Clear();
            txtCodigodeBarras.Clear();
            textBoxPrecio.Clear();
            textBoxStock.Clear();
            textBoxDescripcion.Clear();
            panelCodigo.BackgroundImage = null;
            btnGuardarCodigo.Enabled = true;
            txtBuscar.Clear();
            btnGuardar.Visible = true;
            BtnActualizar.Visible = false;
            error.Clear();
            this.RutaDestino = "";
            this.RutaOrigen =  "";

            DataGridListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
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
        //Fin metodos de error, lipieza de datos e ingresos correctos

        private void LlenarCategoria()
        {
            try
            {
                comboboxCategoria.DataSource = Ncategoria.Seleccionar();
                comboboxCategoria.ValueMember = "idcategoria";
                comboboxCategoria.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FormularioArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.LlenarCategoria();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                panelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigodeBarras.Text, Color.Black, Color.White, 400, 100);
                btnGuardarCodigo.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                Image imagenFinal = (Image)panelCodigo.BackgroundImage.Clone();
                SaveFileDialog DialogGuardar = new SaveFileDialog();
                DialogGuardar.AddExtension = true;
                DialogGuardar.Filter = "Image PNG (*.png)|*.png";
                DialogGuardar.ShowDialog();
                if (!string.IsNullOrEmpty(DialogGuardar.FileName))
                {
                    imagenFinal.Save(DialogGuardar.FileName, ImageFormat.Png);
                }
                imagenFinal.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (comboboxCategoria.Text == string.Empty || textBoxNombre.Text == string.Empty || textBoxPrecio.Text == string.Empty || textBoxStock.Text == string.Empty || textBoxStockMinimo.Text == string.Empty)
                {
                    this.MensajeError("Campos vacio, por favor rellenelos, ");
                    error.SetError(comboboxCategoria,"Seleccione una categoria");
                    error.SetError(textBoxNombre, "ingrese el nombre");
                    error.SetError(textBoxStock, "ingrese el stock");
                    error.SetError(textBoxPrecio, "ingrese el precio");
                    error.SetError(textBoxStockMinimo, "ingrese el stock minimo");
                }
                else
                {
                    Respuesta = Narticulo.Insertar(Convert.ToInt32(comboboxCategoria.SelectedValue),txtCodigodeBarras.Text.Trim(), textBoxNombre.Text.Trim(),Convert.ToDecimal(textBoxPrecio.Text),Convert.ToInt32(textBoxStock.Text), textBoxDescripcion.Text.Trim(), textImagen.Text.Trim(), Convert.ToInt32(textBoxStockMinimo.Text));
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeCorrecto("guardado correctamente");
                        if (textImagen.Text !=string.Empty)
                        {
                            this.RutaDestino = this.Carpeta + textImagen.Text;
                            File.Copy(this.RutaOrigen,this.RutaDestino);
                        }
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

        private void DataGridListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }//no se ocupa

        private void DataGridListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.LimpiarIngresos();
                BtnActualizar.Visible = true;
                btnInsertar.Visible = false;
                textBoxId.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["ID"].Value);
                comboboxCategoria.SelectedValue = Convert.ToString(DataGridListado.CurrentRow.Cells["idcategoria"].Value);
                txtCodigodeBarras.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Codigo"].Value);
                this.nombreOriginal = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
                textBoxNombre.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
                textBoxPrecio.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Precio_Venta"].Value);
                textBoxStock.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Stock"].Value);
                textBoxDescripcion.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Descripcion"].Value);
                textBoxStockMinimo.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Stock_minimo"].Value);
                string Imagen;
                Imagen = Convert.ToString(DataGridListado.CurrentRow.Cells["Imagen"].Value);
                if (Imagen != string.Empty)
                {
                    pictureBox1.Image = Image.FromFile(this.Carpeta + Imagen);
                    textImagen.Text = Imagen;
                }
                else
                {
                    pictureBox1.Image = null;
                    textImagen.Text = "";
                }
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione el nombre de la celda." + "| Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }//no se ocupa

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (textBoxId.Text == string.Empty|| comboboxCategoria.Text == string.Empty || textBoxNombre.Text == string.Empty || textBoxPrecio.Text == string.Empty || textBoxStock.Text == string.Empty || textBoxStockMinimo.Text == string.Empty)
                {
                    this.MensajeError("Campos vacio, por favor rellenelos, ");
                    error.SetError(comboboxCategoria, "Seleccione una categoria");
                    error.SetError(textBoxNombre, "ingrese el nombre");
                    error.SetError(textBoxStock, "ingrese el stock");
                    error.SetError(textBoxPrecio, "ingrese el precio");
                    error.SetError(textBoxStockMinimo, "ingrese el stock minimo");
                }
                else
                {
                    Respuesta = Narticulo.Actualizar(Convert.ToInt32(textBoxId.Text),Convert.ToInt32(comboboxCategoria.SelectedValue), txtCodigodeBarras.Text.Trim(), 
                        this.nombreOriginal, textBoxNombre.Text.Trim(), Convert.ToDecimal(textBoxPrecio.Text),Convert.ToInt32(textBoxStock.Text), 
                        textBoxDescripcion.Text.Trim(), textImagen.Text.Trim(), Convert.ToInt32(textBoxStockMinimo.Text));
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Actualizado correctamente");
                        if (textImagen.Text != string.Empty && this.RutaOrigen !=string.Empty )
                        {
                            this.RutaDestino = this.Carpeta + textImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarIngresos();
            tabControl1.SelectedIndex = 0;
        }

        private void DataGridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridListado.Columns["Seleccionar"].Index)
            {//marcar y desmarcar
                DataGridViewCheckBoxCell CheckBoxEliminar = (DataGridViewCheckBoxCell)DataGridListado.Rows[e.RowIndex].Cells["Seleccionar"];
                CheckBoxEliminar.Value = !Convert.ToBoolean(CheckBoxEliminar.Value);
            }
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeleccionar.Checked)
            {
                DataGridListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;

            }
            else
            {
                DataGridListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
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
                    string Imagen = "";
                    foreach (DataGridViewRow row in DataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))// si la celda 0 es true
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Imagen = Convert.ToString(row.Cells[9].Value);
                            Respuesta = Narticulo.Eliminar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeCorrecto("Se eliminó el registro" + Convert.ToString(row.Cells[5].Value));
                                File.Delete(this.Carpeta+Imagen);
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

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("desea desactivar el resgistro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//el resultado de los botones se guarda en opcion
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Respuesta = "";
                    foreach (DataGridViewRow row in DataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))// si la celda 0 es true
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Respuesta = Narticulo.Desactivar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeCorrecto("Se desactivo el registro");
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

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("desea activar el resgistro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//el resultado de los botones se guarda en opcion
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Respuesta = "";
                    foreach (DataGridViewRow row in DataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))// si la celda 0 es true
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Respuesta = Narticulo.Activar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeCorrecto("Se activo el registro");
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

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            Informes.formularioInformeArticulos informe = new Informes.formularioInformeArticulos();
            informe.ShowDialog();
        }

        private void textImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigodeBarras_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
                textImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);//usamos sub string para que obtener el nombre de la imagen
                this.RutaOrigen = file.FileName;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxStockMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigodeBarras_KeyPress(object sender, KeyPressEventArgs e)
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


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
    public partial class FormularioCategoria : Form
    {
        private string NombreAnt;//nombre antes de edita una categoria

        public FormularioCategoria()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DataGridListado.DataSource = Ncategoria.Listar(); //hacemos referencia a clase y metodo, para no crear objetos
                this.Formato();
                this.LimpiarIngresos();
                TotalRegistros.Text = "Total Registros: " + Convert.ToString(DataGridListado.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//
            }
        }
        private void Buscar()
        {
            try
            {
                DataGridListado.DataSource = Ncategoria.Buscar(txtBuscar.Text); 
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
            DataGridListado.Columns[1].Width = 50;//Id
            DataGridListado.Columns[1].Width = 200;//Nombre
            DataGridListado.Columns[1].Width = 400;//Descripcion
            DataGridListado.Columns[1].Width= 100;//Estado
        }
        //metodos de error, lipieza de datos e ingresos correctos
        private void LimpiarIngresos()//limpiar todos los parametros
        {
            textBoxId.Clear();
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            txtBuscar.Clear();
            btnGuardar.Visible = true;
            BtnActualizar.Visible = false;
            error.Clear();

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

        private void FormularioCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void DataGridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DataGridListado.Columns["Seleccionar"].Index){//marcar y desmarcar
                DataGridViewCheckBoxCell CheckBoxEliminar = (DataGridViewCheckBoxCell)DataGridListado.Rows[e.RowIndex].Cells["Seleccionar"];
                CheckBoxEliminar.Value = !Convert.ToBoolean(CheckBoxEliminar.Value);
            }
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
                    error.SetError(textBoxNombre, "ingrese datos");
                }
                else
                {
                    Respuesta = Ncategoria.Insertar(textBoxNombre.Text.Trim(), textBoxDescripcion.Text.Trim());//enviar a la capa negocio
                    if(Respuesta.Equals("OK")){
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarIngresos();
        }

        private void DataGridListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.LimpiarIngresos();
                BtnActualizar.Visible = true;
                btnGuardar.Visible = false;
                textBoxId.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["ID"].Value);
                this.NombreAnt = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
                textBoxNombre.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Nombre"].Value);
                textBoxDescripcion.Text = Convert.ToString(DataGridListado.CurrentRow.Cells["Descripcion"].Value);
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("seleccione con doble click en la celda nombre");
            }
            
        }

        private void Actualizar(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (textBoxNombre.Text == string.Empty || textBoxId.Text == string.Empty)
                {
                    this.MensajeError("Campos vacio, por favor rellenelos, ");
                    error.SetError(textBoxNombre, "ingrese datos");
                }
                else
                {
                    Respuesta = Ncategoria.Actualizar(Convert.ToInt32(textBoxId.Text),this.NombreAnt,textBoxNombre.Text.Trim(), textBoxDescripcion.Text.Trim());//enviar a la capa negocio
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeCorrecto("actualizado correctamente");
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
                opcion = MessageBox.Show("desea eliminar el resgistro?","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);//el resultado de los botones se guarda en opcion
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Respuesta = "";
                    foreach(DataGridViewRow row in DataGridListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))// si la celda 0 es true
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Respuesta = Ncategoria.Eliminar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
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
                            Respuesta = Ncategoria.Activar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
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
                            Respuesta = Ncategoria.Desactivar(Codigo);//el ID se guarda en la variable codigo, y esa la mandamos al eliminar de Ncategoria
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    
}

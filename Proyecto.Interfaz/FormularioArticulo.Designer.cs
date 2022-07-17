
namespace Proyecto.Interfaz
{
    partial class FormularioArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnActivar = new FontAwesome.Sharp.IconButton();
            this.BtnDesactivar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnGenerarInforme = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.checkBoxSeleccionar = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.TotalRegistros = new System.Windows.Forms.Label();
            this.DataGridListado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarCodigo = new FontAwesome.Sharp.IconButton();
            this.btnCrear = new FontAwesome.Sharp.IconButton();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnInsertar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.Cargar = new FontAwesome.Sharp.IconButton();
            this.textBoxStockMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Imagen = new System.Windows.Forms.Label();
            this.textImagen = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.txtCodigodeBarras = new System.Windows.Forms.TextBox();
            this.CodigodeBarras = new System.Windows.Forms.Label();
            this.comboboxCategoria = new System.Windows.Forms.ComboBox();
            this.etiquetaCategoria = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1360, 647);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnActivar);
            this.tabPage1.Controls.Add(this.BtnDesactivar);
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.btnGenerarInforme);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.checkBoxSeleccionar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.TotalRegistros);
            this.tabPage1.Controls.Add(this.DataGridListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1352, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnActivar
            // 
            this.BtnActivar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnActivar.IconColor = System.Drawing.Color.ForestGreen;
            this.BtnActivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActivar.IconSize = 35;
            this.BtnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActivar.Location = new System.Drawing.Point(207, 426);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(142, 56);
            this.BtnActivar.TabIndex = 13;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActivar.UseVisualStyleBackColor = true;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnDesactivar.IconColor = System.Drawing.Color.Red;
            this.BtnDesactivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDesactivar.IconSize = 35;
            this.BtnDesactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesactivar.Location = new System.Drawing.Point(553, 426);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(149, 56);
            this.BtnDesactivar.TabIndex = 12;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnEliminar.IconColor = System.Drawing.Color.Red;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 35;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(384, 426);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(143, 56);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnGenerarInforme.IconColor = System.Drawing.Color.Black;
            this.btnGenerarInforme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarInforme.IconSize = 35;
            this.btnGenerarInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarInforme.Location = new System.Drawing.Point(649, 9);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(53, 52);
            this.btnGenerarInforme.TabIndex = 10;
            this.btnGenerarInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 35;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(581, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 52);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // checkBoxSeleccionar
            // 
            this.checkBoxSeleccionar.AutoSize = true;
            this.checkBoxSeleccionar.Location = new System.Drawing.Point(19, 426);
            this.checkBoxSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSeleccionar.Name = "checkBoxSeleccionar";
            this.checkBoxSeleccionar.Size = new System.Drawing.Size(104, 21);
            this.checkBoxSeleccionar.TabIndex = 4;
            this.checkBoxSeleccionar.Text = "Seleccionar";
            this.checkBoxSeleccionar.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionar.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionar_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(16, 20);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(537, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // TotalRegistros
            // 
            this.TotalRegistros.AutoSize = true;
            this.TotalRegistros.Location = new System.Drawing.Point(758, 426);
            this.TotalRegistros.Name = "TotalRegistros";
            this.TotalRegistros.Size = new System.Drawing.Size(44, 17);
            this.TotalRegistros.TabIndex = 1;
            this.TotalRegistros.Text = "Total:";
            // 
            // DataGridListado
            // 
            this.DataGridListado.AllowUserToAddRows = false;
            this.DataGridListado.AllowUserToDeleteRows = false;
            this.DataGridListado.AllowUserToOrderColumns = true;
            this.DataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DataGridListado.Location = new System.Drawing.Point(16, 66);
            this.DataGridListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridListado.Name = "DataGridListado";
            this.DataGridListado.ReadOnly = true;
            this.DataGridListado.RowHeadersWidth = 51;
            this.DataGridListado.RowTemplate.Height = 24;
            this.DataGridListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridListado.Size = new System.Drawing.Size(1100, 341);
            this.DataGridListado.TabIndex = 0;
            this.DataGridListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListado_CellContentClick);
            this.DataGridListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListado_CellContentDoubleClick);
            this.DataGridListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListado_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarCodigo);
            this.tabPage2.Controls.Add(this.btnCrear);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.Cargar);
            this.tabPage2.Controls.Add(this.textBoxStockMinimo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.Imagen);
            this.tabPage2.Controls.Add(this.textImagen);
            this.tabPage2.Controls.Add(this.textBoxStock);
            this.tabPage2.Controls.Add(this.textBoxPrecio);
            this.tabPage2.Controls.Add(this.labelStock);
            this.tabPage2.Controls.Add(this.labelPrecio);
            this.tabPage2.Controls.Add(this.panelCodigo);
            this.tabPage2.Controls.Add(this.txtCodigodeBarras);
            this.tabPage2.Controls.Add(this.CodigodeBarras);
            this.tabPage2.Controls.Add(this.comboboxCategoria);
            this.tabPage2.Controls.Add(this.etiquetaCategoria);
            this.tabPage2.Controls.Add(this.textBoxId);
            this.tabPage2.Controls.Add(this.textBoxDescripcion);
            this.tabPage2.Controls.Add(this.textBoxNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1352, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCodigo
            // 
            this.btnGuardarCodigo.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btnGuardarCodigo.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCodigo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCodigo.IconSize = 35;
            this.btnGuardarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCodigo.Location = new System.Drawing.Point(1135, 236);
            this.btnGuardarCodigo.Name = "btnGuardarCodigo";
            this.btnGuardarCodigo.Size = new System.Drawing.Size(137, 54);
            this.btnGuardarCodigo.TabIndex = 34;
            this.btnGuardarCodigo.Text = "Guardar";
            this.btnGuardarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCodigo.UseVisualStyleBackColor = true;
            this.btnGuardarCodigo.Click += new System.EventHandler(this.btnGuardarCodigo_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btnCrear.IconColor = System.Drawing.Color.Black;
            this.btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrear.IconSize = 35;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(833, 236);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(139, 54);
            this.btnCrear.TabIndex = 33;
            this.btnCrear.Text = "Crear ";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnActualizar.IconColor = System.Drawing.Color.Black;
            this.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActualizar.IconSize = 35;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(481, 400);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(156, 62);
            this.BtnActualizar.TabIndex = 32;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnInsertar.IconColor = System.Drawing.Color.Black;
            this.btnInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertar.IconSize = 35;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(161, 399);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(156, 62);
            this.btnInsertar.TabIndex = 31;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 35;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(481, 399);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 64);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCancelar.IconColor = System.Drawing.Color.Red;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 35;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(161, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 64);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Cargar
            // 
            this.Cargar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Cargar.IconColor = System.Drawing.Color.Black;
            this.Cargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cargar.IconSize = 35;
            this.Cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cargar.Location = new System.Drawing.Point(1238, 532);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(56, 50);
            this.Cargar.TabIndex = 28;
            this.Cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStockMinimo
            // 
            this.textBoxStockMinimo.Location = new System.Drawing.Point(481, 348);
            this.textBoxStockMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStockMinimo.Name = "textBoxStockMinimo";
            this.textBoxStockMinimo.Size = new System.Drawing.Size(156, 22);
            this.textBoxStockMinimo.TabIndex = 27;
            this.textBoxStockMinimo.TextChanged += new System.EventHandler(this.textBoxStockMinimo_TextChanged);
            this.textBoxStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockMinimo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Stock minimo";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(833, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Imagen
            // 
            this.Imagen.AutoSize = true;
            this.Imagen.Location = new System.Drawing.Point(728, 318);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(54, 17);
            this.Imagen.TabIndex = 23;
            this.Imagen.Text = "Imagen";
            this.Imagen.Click += new System.EventHandler(this.label3_Click);
            // 
            // textImagen
            // 
            this.textImagen.Enabled = false;
            this.textImagen.Location = new System.Drawing.Point(833, 313);
            this.textImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textImagen.Name = "textImagen";
            this.textImagen.Size = new System.Drawing.Size(449, 22);
            this.textImagen.TabIndex = 21;
            this.textImagen.TextChanged += new System.EventHandler(this.textImagen_TextChanged);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(161, 348);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(156, 22);
            this.textBoxStock.TabIndex = 19;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(188, 297);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(449, 22);
            this.textBoxPrecio.TabIndex = 18;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(87, 348);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(43, 17);
            this.labelStock.TabIndex = 17;
            this.labelStock.Text = "Stock";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(23, 302);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(107, 17);
            this.labelPrecio.TabIndex = 16;
            this.labelPrecio.Text = "Precio de venta";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Location = new System.Drawing.Point(833, 90);
            this.panelCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(449, 125);
            this.panelCodigo.TabIndex = 15;
            // 
            // txtCodigodeBarras
            // 
            this.txtCodigodeBarras.Location = new System.Drawing.Point(833, 39);
            this.txtCodigodeBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigodeBarras.Name = "txtCodigodeBarras";
            this.txtCodigodeBarras.Size = new System.Drawing.Size(449, 22);
            this.txtCodigodeBarras.TabIndex = 12;
            this.txtCodigodeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigodeBarras_KeyPress);
            // 
            // CodigodeBarras
            // 
            this.CodigodeBarras.AutoSize = true;
            this.CodigodeBarras.Location = new System.Drawing.Point(664, 39);
            this.CodigodeBarras.Name = "CodigodeBarras";
            this.CodigodeBarras.Size = new System.Drawing.Size(118, 17);
            this.CodigodeBarras.TabIndex = 11;
            this.CodigodeBarras.Text = "Codigo de Barras";
            this.CodigodeBarras.Click += new System.EventHandler(this.CodigodeBarras_Click);
            // 
            // comboboxCategoria
            // 
            this.comboboxCategoria.FormattingEnabled = true;
            this.comboboxCategoria.Location = new System.Drawing.Point(188, 68);
            this.comboboxCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxCategoria.Name = "comboboxCategoria";
            this.comboboxCategoria.Size = new System.Drawing.Size(449, 24);
            this.comboboxCategoria.TabIndex = 10;
            // 
            // etiquetaCategoria
            // 
            this.etiquetaCategoria.AutoSize = true;
            this.etiquetaCategoria.Location = new System.Drawing.Point(61, 71);
            this.etiquetaCategoria.Name = "etiquetaCategoria";
            this.etiquetaCategoria.Size = new System.Drawing.Size(69, 17);
            this.etiquetaCategoria.TabIndex = 9;
            this.etiquetaCategoria.Text = "Categoria";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(400, 25);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(193, 22);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(188, 183);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(449, 75);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(188, 142);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(449, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // FormularioArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 670);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioArticulo";
            this.Text = "FormularioArticulo";
            this.Load += new System.EventHandler(this.FormularioArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBoxSeleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label TotalRegistros;
        private System.Windows.Forms.DataGridView DataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxCategoria;
        private System.Windows.Forms.Label etiquetaCategoria;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelCodigo;
        private System.Windows.Forms.TextBox txtCodigodeBarras;
        private System.Windows.Forms.Label CodigodeBarras;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textImagen;
        private System.Windows.Forms.Label Imagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxStockMinimo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnGenerarInforme;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnDesactivar;
        private FontAwesome.Sharp.IconButton BtnActivar;
        private FontAwesome.Sharp.IconButton Cargar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton BtnActualizar;
        private FontAwesome.Sharp.IconButton btnInsertar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private FontAwesome.Sharp.IconButton btnGuardarCodigo;
    }
}
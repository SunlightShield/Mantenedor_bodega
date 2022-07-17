
namespace Proyecto.Interfaz
{
    partial class formularioConsultaFechaCompras
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
            this.TotalRegistros = new System.Windows.Forms.Label();
            this.DataGridListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTotalD = new System.Windows.Forms.TextBox();
            this.panelMostrarDetalles = new System.Windows.Forms.Panel();
            this.txtTotalImpuestoD = new System.Windows.Forms.TextBox();
            this.txtSubtotalD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCerrarDetalles = new System.Windows.Forms.Button();
            this.DgvMostrarDetalles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnComprobante = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListado)).BeginInit();
            this.panelMostrarDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalles)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // TotalRegistros
            // 
            this.TotalRegistros.AutoSize = true;
            this.TotalRegistros.Location = new System.Drawing.Point(835, 486);
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
            this.DataGridListado.Location = new System.Drawing.Point(5, 66);
            this.DataGridListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridListado.Name = "DataGridListado";
            this.DataGridListado.ReadOnly = true;
            this.DataGridListado.RowHeadersWidth = 51;
            this.DataGridListado.RowTemplate.Height = 24;
            this.DataGridListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridListado.Size = new System.Drawing.Size(1105, 405);
            this.DataGridListado.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // txtTotalD
            // 
            this.txtTotalD.Location = new System.Drawing.Point(671, 388);
            this.txtTotalD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalD.Name = "txtTotalD";
            this.txtTotalD.Size = new System.Drawing.Size(132, 22);
            this.txtTotalD.TabIndex = 7;
            // 
            // panelMostrarDetalles
            // 
            this.panelMostrarDetalles.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMostrarDetalles.Controls.Add(this.txtTotalD);
            this.panelMostrarDetalles.Controls.Add(this.txtTotalImpuestoD);
            this.panelMostrarDetalles.Controls.Add(this.txtSubtotalD);
            this.panelMostrarDetalles.Controls.Add(this.label13);
            this.panelMostrarDetalles.Controls.Add(this.label12);
            this.panelMostrarDetalles.Controls.Add(this.label11);
            this.panelMostrarDetalles.Controls.Add(this.btnCerrarDetalles);
            this.panelMostrarDetalles.Controls.Add(this.DgvMostrarDetalles);
            this.panelMostrarDetalles.Location = new System.Drawing.Point(228, 145);
            this.panelMostrarDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMostrarDetalles.Name = "panelMostrarDetalles";
            this.panelMostrarDetalles.Size = new System.Drawing.Size(892, 427);
            this.panelMostrarDetalles.TabIndex = 7;
            this.panelMostrarDetalles.Visible = false;
            // 
            // txtTotalImpuestoD
            // 
            this.txtTotalImpuestoD.Location = new System.Drawing.Point(671, 361);
            this.txtTotalImpuestoD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalImpuestoD.Name = "txtTotalImpuestoD";
            this.txtTotalImpuestoD.Size = new System.Drawing.Size(132, 22);
            this.txtTotalImpuestoD.TabIndex = 6;
            // 
            // txtSubtotalD
            // 
            this.txtSubtotalD.Location = new System.Drawing.Point(671, 335);
            this.txtSubtotalD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtotalD.Name = "txtSubtotalD";
            this.txtSubtotalD.Size = new System.Drawing.Size(132, 22);
            this.txtSubtotalD.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(549, 388);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 361);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total impuesto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 335);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Subtotal";
            // 
            // btnCerrarDetalles
            // 
            this.btnCerrarDetalles.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDetalles.Location = new System.Drawing.Point(827, 5);
            this.btnCerrarDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarDetalles.Name = "btnCerrarDetalles";
            this.btnCerrarDetalles.Size = new System.Drawing.Size(47, 38);
            this.btnCerrarDetalles.TabIndex = 1;
            this.btnCerrarDetalles.Text = "X";
            this.btnCerrarDetalles.UseVisualStyleBackColor = false;
            // 
            // DgvMostrarDetalles
            // 
            this.DgvMostrarDetalles.AllowUserToAddRows = false;
            this.DgvMostrarDetalles.AllowUserToDeleteRows = false;
            this.DgvMostrarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarDetalles.Location = new System.Drawing.Point(17, 50);
            this.DgvMostrarDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvMostrarDetalles.Name = "DgvMostrarDetalles";
            this.DgvMostrarDetalles.ReadOnly = true;
            this.DgvMostrarDetalles.RowHeadersWidth = 51;
            this.DgvMostrarDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarDetalles.Size = new System.Drawing.Size(859, 276);
            this.DgvMostrarDetalles.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(492, 18);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFin.TabIndex = 11;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(87, 20);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(23, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 604);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnComprobante);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpFechaFin);
            this.tabPage1.Controls.Add(this.dtpFechaInicio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panelMostrarDetalles);
            this.tabPage1.Controls.Add(this.TotalRegistros);
            this.tabPage1.Controls.Add(this.DataGridListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1123, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 35;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(780, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 45);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnComprobante.IconColor = System.Drawing.Color.Black;
            this.btnComprobante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprobante.IconSize = 35;
            this.btnComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobante.Location = new System.Drawing.Point(857, 9);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(137, 52);
            this.btnComprobante.TabIndex = 14;
            this.btnComprobante.Text = "Comprobante";
            this.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprobante.UseVisualStyleBackColor = true;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // formularioConsultaFechaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 617);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formularioConsultaFechaCompras";
            this.Text = "formularioConsultaFechaCompras";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListado)).EndInit();
            this.panelMostrarDetalles.ResumeLayout(false);
            this.panelMostrarDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalles)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMostrarDetalles;
        private System.Windows.Forms.TextBox txtTotalD;
        private System.Windows.Forms.TextBox txtTotalImpuestoD;
        private System.Windows.Forms.TextBox txtSubtotalD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCerrarDetalles;
        private System.Windows.Forms.DataGridView DgvMostrarDetalles;
        private System.Windows.Forms.Label TotalRegistros;
        private System.Windows.Forms.DataGridView DataGridListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnComprobante;
    }
}
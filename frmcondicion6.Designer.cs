namespace Practica_de_SQL_Base_de_datos
{
    partial class frmcondicion6
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
            this.tbVentas = new System.Windows.Forms.TabControl();
            this.tbCargar = new System.Windows.Forms.TabPage();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbConsultar = new System.Windows.Forms.TabPage();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.tbVentas.SuspendLayout();
            this.tbCargar.SuspendLayout();
            this.tbConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVentas
            // 
            this.tbVentas.Controls.Add(this.tbCargar);
            this.tbVentas.Controls.Add(this.tbConsultar);
            this.tbVentas.Location = new System.Drawing.Point(12, 12);
            this.tbVentas.Name = "tbVentas";
            this.tbVentas.SelectedIndex = 0;
            this.tbVentas.Size = new System.Drawing.Size(465, 286);
            this.tbVentas.TabIndex = 1;
            // 
            // tbCargar
            // 
            this.tbCargar.Controls.Add(this.txtCantidad);
            this.tbCargar.Controls.Add(this.btnCargar);
            this.tbCargar.Controls.Add(this.dtpFecha);
            this.tbCargar.Controls.Add(this.txtProducto);
            this.tbCargar.Controls.Add(this.txtId);
            this.tbCargar.Controls.Add(this.lblCantidad);
            this.tbCargar.Controls.Add(this.lblProducto);
            this.tbCargar.Controls.Add(this.txtFecha);
            this.tbCargar.Controls.Add(this.lblId);
            this.tbCargar.Location = new System.Drawing.Point(4, 22);
            this.tbCargar.Name = "tbCargar";
            this.tbCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCargar.Size = new System.Drawing.Size(457, 260);
            this.tbCargar.TabIndex = 0;
            this.tbCargar.Text = "Cargar";
            this.tbCargar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(72, 160);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(208, 196);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(106, 74);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(72, 116);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(144, 20);
            this.txtProducto.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(16, 160);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(16, 119);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(16, 74);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(83, 13);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.Text = "Fecha de Venta";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // tbConsultar
            // 
            this.tbConsultar.Controls.Add(this.txtNumero);
            this.tbConsultar.Controls.Add(this.btnConsultar);
            this.tbConsultar.Controls.Add(this.dgvVentas);
            this.tbConsultar.Controls.Add(this.lblConsulta);
            this.tbConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultar.Size = new System.Drawing.Size(457, 260);
            this.tbConsultar.TabIndex = 1;
            this.tbConsultar.Text = "Consultar";
            this.tbConsultar.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(163, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(85, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(292, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Producto,
            this.Cantidad});
            this.dgvVentas.Location = new System.Drawing.Point(6, 60);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(445, 194);
            this.dgvVentas.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(6, 24);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(150, 13);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Ingresar una cantidad mayor a";
            // 
            // frmcondicion6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 304);
            this.Controls.Add(this.tbVentas);
            this.Name = "frmcondicion6";
            this.Text = "frmcondicion6";
            this.tbVentas.ResumeLayout(false);
            this.tbCargar.ResumeLayout(false);
            this.tbCargar.PerformLayout();
            this.tbConsultar.ResumeLayout(false);
            this.tbConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbVentas;
        private System.Windows.Forms.TabPage tbCargar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabPage tbConsultar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label lblConsulta;
    }
}
namespace Practica_de_SQL_Base_de_datos
{
    partial class frmcondicionesconradiobuton5
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
            this.btnConsular = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.rbProductos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsular
            // 
            this.btnConsular.Location = new System.Drawing.Point(211, 21);
            this.btnConsular.Name = "btnConsular";
            this.btnConsular.Size = new System.Drawing.Size(75, 23);
            this.btnConsular.TabIndex = 7;
            this.btnConsular.Text = "Consultar";
            this.btnConsular.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 64);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(459, 232);
            this.dgvConsulta.TabIndex = 6;
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(118, 24);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(76, 17);
            this.rbVentas.TabIndex = 5;
            this.rbVentas.TabStop = true;
            this.rbVentas.Text = "tabla Autor";
            this.rbVentas.UseVisualStyleBackColor = true;
            // 
            // rbProductos
            // 
            this.rbProductos.AutoSize = true;
            this.rbProductos.Location = new System.Drawing.Point(22, 24);
            this.rbProductos.Name = "rbProductos";
            this.rbProductos.Size = new System.Drawing.Size(70, 17);
            this.rbProductos.TabIndex = 4;
            this.rbProductos.TabStop = true;
            this.rbProductos.Text = "tabla libro";
            this.rbProductos.UseVisualStyleBackColor = true;
            // 
            // frmcondicionesconradiobuton5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 334);
            this.Controls.Add(this.btnConsular);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.rbVentas);
            this.Controls.Add(this.rbProductos);
            this.Name = "frmcondicionesconradiobuton5";
            this.Text = "frmcondicionesconradiobuton5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsular;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.RadioButton rbProductos;
    }
}
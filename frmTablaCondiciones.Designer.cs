﻿namespace Practica_de_SQL_Base_de_datos
{
    partial class frmTablaCondiciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdCondicion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdCondicion
            // 
            this.cmdCondicion.Location = new System.Drawing.Point(1, 325);
            this.cmdCondicion.Name = "cmdCondicion";
            this.cmdCondicion.Size = new System.Drawing.Size(107, 23);
            this.cmdCondicion.TabIndex = 1;
            this.cmdCondicion.Text = "Condicion";
            this.cmdCondicion.UseVisualStyleBackColor = true;
            this.cmdCondicion.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTablaCondiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 360);
            this.Controls.Add(this.cmdCondicion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTablaCondiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTablaCondiciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdCondicion;
    }
}
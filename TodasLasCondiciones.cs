using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_SQL_Base_de_datos
{
    public partial class TodasLasCondiciones : Form
    {
        public TodasLasCondiciones()
        {
            InitializeComponent();
        }

        private void condicion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void condicion1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTablaCondiciones frmTabla = new frmTablaCondiciones();   
            frmTabla.ShowDialog();  
        }

        private void condicion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaCondiciones2 frmTablaCondiciones2 = new frmTablaCondiciones2();
            frmTablaCondiciones2.ShowDialog();
        }

        private void guardartablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmguardartabla frmguardartabla = new frmguardartabla();    
            frmguardartabla.ShowDialog();   
        }

        private void condicion4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcondicion3combox_cajadetexto frmcondicion3combox_ =  new frmcondicion3combox_cajadetexto();
            frmcondicion3combox_.ShowDialog ();
        }

        private void condicion6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          frmCondicion5TablaCompleta frm  = new frmCondicion5TablaCompleta();
            frm.ShowDialog ();
        }
    }
}

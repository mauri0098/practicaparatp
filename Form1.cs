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
    public partial class Form1 : Form
    {
        ConexionBD objconexionBD;

        public Form1()
        {
            InitializeComponent();
            objconexionBD = new ConexionBD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objconexionBD.conectarBD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objconexionBD.conectarBD();
            objconexionBD.Traertabla(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTablaCondiciones frmTablaCondiciones = new frmTablaCondiciones();    
            frmTablaCondiciones.ShowDialog();
        }
    }
}

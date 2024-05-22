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
    public partial class frmTablaCondiciones2 : Form
    {
        public frmTablaCondiciones2()
        {
            InitializeComponent();
        }

        private void frmTablaCondiciones2_Load(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();
            
            conexionBD.CondicionTabla2(dataGridView1);
        }
    }
}

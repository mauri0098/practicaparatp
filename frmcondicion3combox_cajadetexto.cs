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
    public partial class frmcondicion3combox_cajadetexto : Form
    {
        public frmcondicion3combox_cajadetexto()
        {
            InitializeComponent();
            
        }
        ConexionBD conexionBD = new ConexionBD();
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            conexionBD.CondicionTabla4(dgvProducto);
        }
    }
}

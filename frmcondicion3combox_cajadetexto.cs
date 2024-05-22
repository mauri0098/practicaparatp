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
            // Asumimos que 'conexionBD' es una instancia de la clase que contiene el método 'CondicionTabla4'
            // Asegurarse de que la conexión a la base de datos esté abierta
            conexionBD.conectarBD();

            // Obtener el texto del TextBox y pasarlo como argumento al método 'CondicionTabla4'
            string etiqueta = txtConsulta.Text;
            conexionBD.CondicionTabla4(dgvProducto, etiqueta);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

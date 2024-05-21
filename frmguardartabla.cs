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
    public partial class frmguardartabla : Form
    {
        public frmguardartabla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();

            // Verifica si el valor del libro es menor que 500
            if (Convert.ToInt32(textBox3.Text) >= 2000)
            {
                MessageBox.Show("El valor del libro es muy grande. No se guardarán registros.");
                // Cierra la conexión sin guardar registros
                conexionBD.conexioncerrada();
            }
            else
            {
                // Si el valor del libro es menor que 500, se conecta a la base de datos y guarda los datos.
                conexionBD.conectarBD();
                conexionBD.guardardatos(dataGridView1, Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));
                // Se cierra la conexión después de guardar los datos
                conexionBD.conexioncerrada();
            }

        }
    }
}

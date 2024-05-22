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
    public partial class frmCondicion5TablaCompleta : Form
    {
        public frmCondicion5TablaCompleta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           ConexionBD conexionBD = new ConexionBD();
            conexionBD.CondicionTabla5(dataGridView1, comboBox1);
            conexionBD.condiciontablaLISTA55(listBox1);
        }

        private void frmCondicion5TablaCompleta_Load(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();
            conexionBD.conectarBD();
            conexionBD.CONDICIONCOMBO(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

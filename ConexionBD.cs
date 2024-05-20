using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;


namespace Practica_de_SQL_Base_de_datos
{
    internal class ConexionBD
    {
        


        //instanciamos 3 obj
        OleDbConnection Conexion = new OleDbConnection();
        OleDbCommand Comando = new OleDbCommand();
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        OleDbDataReader lectorBD;

        string CadenadeConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        public void conectarBD()
        {
            try
            {
                Conexion.ConnectionString = CadenadeConexion;

                Conexion.Open();
                Comando.Connection = Conexion;
               
                MessageBox.Show("se conecto ");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }




        }

        public void Traertabla( DataGridView grilla)
        {
            try
            {
               
                Comando = new OleDbCommand();
               
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.TableDirect;
                Comando.CommandText = "SELECT * FROM Libro";

                // Establecer el comando para el adaptador
                Adaptador.SelectCommand = Comando;

                // Crear un nuevo DataTable para almacenar los resultados
                DataTable tabla = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                Adaptador.Fill(tabla);

                // Enlazar el DataTable al DataGridView
                grilla.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error");
                throw ex;
            }




        }







    }
}

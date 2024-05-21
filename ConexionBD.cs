using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Collections;


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
      
        
        public void Condicion1(DataGridView grilla)
        {
            try
            {
                // Create a new command
                OleDbCommand comando = new OleDbCommand
                {
                    Connection = Conexion, // Assuming Conexion is your OleDbConnection object
                    CommandType = CommandType.Text, // Using Text instead of TableDirect for a standard SQL query
                    CommandText = "SELECT IdLibro, Titulo FROM Libro"
                };

                // Create a new data adapter with the command
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);

                // Create a new DataTable to hold the query results
                DataTable tabla = new DataTable();

                // Fill the DataTable with the results of the query
                adaptador.Fill(tabla);

                // Bind the DataTable to the DataGridView
                grilla.DataSource = tabla;
            }
            catch (Exception ex)
            {
                // Show a message box with the error message
                MessageBox.Show("Hubo un error: " + ex.Message);
                // Optionally rethrow the exception if needed
                // throw;
            }
        }

        public void CondicionTabla2(DataGridView grilla) // Método público llamado CondicionTabla2 que toma un DataGridView como parámetro
        {
            OleDbCommand comando = new OleDbCommand  // Declara e instancia un nuevo objeto OleDbCommand llamado comando
            {
                Connection = Conexion,               // Asigna la conexión a la base de datos (objeto OleDbConnection) a la propiedad Connection del comando
                CommandType = CommandType.Text,      // Especifica que el tipo de comando es Text, indicando que se trata de una consulta SQL
                CommandText = "Select Titulo, IdAutor from Libro" // Define la consulta SQL que selecciona las columnas Titulo e IdAutor de la tabla Libro
            };

            Adaptador.SelectCommand = comando;       // Asigna el comando OleDbCommand al SelectCommand del adaptador OleDbDataAdapter (suponiendo que Adaptador está definido en otro lugar; esto parece un error común)

            OleDbDataReader dr = comando.ExecuteReader(); // Ejecuta la consulta SQL y devuelve un OleDbDataReader que permite leer los datos devueltos por la consulta

            grilla.Rows.Clear();                      // Limpia todas las filas existentes en el DataGridView para asegurarse de que no hay datos anteriores

            while (dr.Read())                         // Mientras haya registros para leer en el DataReader (itera sobre cada registro devuelto por la consulta)
            {
                grilla.Rows.Add(dr["Titulo"], dr["IdAutor"]); // Agrega una nueva fila al DataGridView con los valores de las columnas Titulo e IdAutor del registro actual
            }

            Conexion.Close();                         // Cierra la conexión a la base de datos una vez que todos los registros han sido leídos y procesados
        }
        public void guardardatos(DataGridView grilla, int idautor, string titulo, int precio)
        {
            try
            {
                // Se instancia un nuevo objeto OleDbCommand para ejecutar comandos SQL.
                Comando = new OleDbCommand();

                // Se establece la conexión del comando al objeto de conexión proporcionado.
                Comando.Connection = Conexion;

                // Se especifica que el tipo de comando a ejecutar es de tipo texto.
                Comando.CommandType = System.Data.CommandType.Text;

                // Se construye una consulta SQL de inserción utilizando los parámetros proporcionados.
                // Los valores de idautor, titulo y precio se insertan directamente en la consulta.
                // Es importante tener en cuenta que esta forma de concatenar valores en la consulta puede ser susceptible a inyección SQL si no se sanitizan adecuadamente.
                // Idealmente, se debería utilizar consultas parametrizadas para evitar este problema.
                Comando.CommandText = $"INSERT INTO Libro (IdLibro, Titulo, Precio) VALUES ({idautor}, '{titulo}', {precio})";

                // Se ejecuta el comando SQL en la base de datos sin esperar ningún resultado.
                Comando.ExecuteNonQuery();

                // Se cierra la conexión a la base de datos después de ejecutar el comando.
                Conexion.Close();

                // Se muestra un mensaje al usuario indicando que los datos se guardaron correctamente.
                MessageBox.Show("sus registros se guardaron");
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción durante el proceso de guardado, se muestra un mensaje de error al usuario.
                MessageBox.Show("Hubo un error al intentar guardar los datos.");

                // La excepción se relanza para que pueda ser manejada por código externo si es necesario.
                throw ex;
            }
        }
        public void conexioncerrada()
        {

            OleDbCommand comando = new OleDbCommand
            {
                Connection = Conexion,

            };
            Conexion.Close();
        }

        public void CondicionTabla4(DataGridView grilla)
        {
            OleDbCommand comando = new OleDbCommand
            {
                Connection = Conexion,
                CommandType = CommandType.Text,
                CommandText = "SELECT IdLIBRO, Titulo, idPais FROM Libro WHERE idPais < 5" //paises menores a 5
            };

            OleDbDataReader dr = comando.ExecuteReader();

            grilla.Rows.Clear();

            while (dr.Read())
            {
                grilla.Rows.Add(dr["IdLIBRO"], dr["Titulo"], dr["idPais"]);
            }

            Conexion.Close();
        }






    }

}

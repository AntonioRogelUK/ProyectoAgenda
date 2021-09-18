using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    public class Contacto
    {
        private string connectionString;

        public Contacto()
        {
            // ConnectionString cuando es con la seguridad de SQL
            connectionString = "Server=localhost;Database=AgendaDB;User Id=sa;Password=123456;";

            // ConnectionString cuando es con la seguridad de Windows
            //connectionString = "Server=localhost;Database=AgendaDB;Trusted_Connection=True;";
        }
        
        public bool ProbarConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo conectar {ex.Message}");
            }
            finally 
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public DataTable ObtenerContactos() 
        {
            try
            {
                string query = "SELECT * FROM Contactos";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                
                sqlCommand.CommandType = CommandType.Text;

                try
                {
                    sqlConnection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    DataTable dtContactos = new DataTable();
                    sqlDataAdapter.Fill(dtContactos);
                    return dtContactos;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    sqlConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}

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

        public int ContactoId { get; set; }
        public DateTime FechaCaptura { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string TelefonoParticular { get; set; }
        public string TelefonoCelular { get; set; }
        public bool Activo { get; set; }


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

        public DataTable ObtenerContactos(bool activo = true) 
        {
            try
            {
                string query = "SELECT * FROM Contactos WHERE Activo = @Activo";
                
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Activo", activo);
                
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

        public DataTable ObtenerContactosPorNombre(string nombre)
        {
            try
            {
                string query = "SELECT * FROM Contactos WHERE Activo = 1 AND Nombre like '%' + @Nombre + '%'";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Nombre", nombre.Trim());

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

        public void AgregarContacto(Contacto contacto) 
        {
            try
            {
                string query = "INSERT INTO Contactos (FechaCaptura, Nombre, FechaNacimiento, Email, TelefonoParticular, TelefonoCelular, Activo) " +
                                            "VALUES (GETDATE(), @Nombre, @FechaNacimiento, @Email, @TelefonoParticular, @TelefonoCelular, 1)";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.AddWithValue("@Nombre",contacto.Nombre);
                sqlCommand.Parameters.AddWithValue("@FechaNacimiento", contacto.FechaNacimiento.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@Email", contacto.Email);
                sqlCommand.Parameters.AddWithValue("@TelefonoParticular", contacto.TelefonoParticular);
                sqlCommand.Parameters.AddWithValue("@TelefonoCelular", contacto.TelefonoCelular);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();

                    //sqlCommand.ExecuteNonQuery();
                    //sqlCommand.ExecuteReader();
                    //sqlCommand.ExecuteScalar();
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
            catch (Exception)
            {

                throw;
            }
        }
    }
}

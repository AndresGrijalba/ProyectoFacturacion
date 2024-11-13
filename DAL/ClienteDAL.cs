using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL

{
    public class ClienteDAL
    {
        private string connectionString = "your_connection_string_here"; // Reemplaza con tu cadena de conexión

        
        public bool InsertarCliente(Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nombre, Email, Telefono) VALUES (@Nombre, @Apellido, @TipoDocumento, @NumeroDocumento, @Telefono, @CorreoElectronico)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                command.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Método para obtener un cliente por ID
        public Cliente ObtenerClientePorNumeroDocumento(int NumeroDocumento)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes WHERE ClienteId = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Cliente
                        {
                            NumeroDocumento = (int)reader["NumeroDocumento"],
                            Nombre = reader["Nombre"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            CorreoElectronico = reader["CorreoElectronico"].ToString()
                        };
                    }
                }
            }
            return null; // Devuelve null si no encuentra el cliente
        }

        // Método para actualizar un cliente
        public bool ActualizarCliente(Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Clientes SET Nombre = @Nombre, Email = @Email, Telefono = @Telefono WHERE ClienteId = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                command.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Método para eliminar un cliente
        public bool EliminarCliente(int NumeroDocumento)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Clientes WHERE NumeroDocumento = @NumeroDocumento";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Método para obtener todos los clientes
        public List<Cliente> ObtenerTodosLosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            NumeroDocumento = (int)reader["NumeroDocumento"],
                            Nombre = reader["Nombre"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        });
                    }
                }
            }
            return clientes;
        }
    }
}


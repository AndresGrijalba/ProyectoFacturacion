using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;



namespace BLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL;

        public ClienteBLL()
        {
            clienteDAL = new ClienteDAL();
        }

        // Método para agregar un nuevo cliente
        public bool AgregarCliente(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.CorreoElectronico))
                throw new ArgumentException("El nombre y el email del cliente no pueden estar vacíos.");

            if (!EsEmailValido(cliente.CorreoElectronico))
                throw new ArgumentException("El email proporcionado no es válido.");

            return clienteDAL.InsertarCliente(cliente);
        }

        // Método para obtener un cliente por ID
        public Cliente ObtenerCliente(int NumeroDocumento)
        {
            if (NumeroDocumento <= 0)
                throw new ArgumentException("El ID del cliente debe ser mayor a cero.");

            return clienteDAL.ObtenerClientePorNumeroDocumento(NumeroDocumento);
        }

        // Método para actualizar un cliente existente
        public bool ActualizarCliente(Cliente cliente)
        {
            if (cliente.NumeroDocumento <= 0)
                throw new ArgumentException("El ID del cliente no es válido.");

            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.CorreoElectronico))
                throw new ArgumentException("El nombre y el email del cliente no pueden estar vacíos.");

            if (!EsEmailValido(cliente.CorreoElectronico))
                throw new ArgumentException("El email proporcionado no es válido.");

            return clienteDAL.ActualizarCliente(cliente);
        }

        // Método para eliminar un cliente por ID
        public bool EliminarCliente(int NumeroDocumento)
        {
            if (NumeroDocumento <= 0)
                throw new ArgumentException("El ID del cliente debe ser mayor a cero.");

            return clienteDAL.EliminarCliente(NumeroDocumento);
        }

        // Método para obtener todos los clientes
        public List<Cliente> ObtenerTodosLosClientes()
        {
            return clienteDAL.ObtenerTodosLosClientes();
        }

        // Método privado para validar el formato de email
        private bool EsEmailValido(string CorreoElectronico)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(CorreoElectronico);
                return addr.Address == CorreoElectronico;
            }
            catch
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAP4.ClienteLibros.ClientesService;

namespace DAP4.ClienteLibros
{ 
    public class MetodosClientes
    {
        ClientesServiceClient cliente = new ClientesServiceClient();

        public IEnumerable<Clientes> listarClientes()
        {
            return cliente.ListarClientes();
        }
        public Clientes buscarPorApellido(string apellido)
        {
            var resultado = cliente.ObtenerClientePorApellido(apellido);
            return resultado;
        }
        public Clientes buscarPorId(int id)
        {
            var resultado = cliente.ObtenerClientePorId(id);
            return resultado;
        }
        public Clientes insertarCliente(Clientes input)
        {
            var resultado = cliente.InsertarCliente(input);
            return resultado;
        }
    }
}

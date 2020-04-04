using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAP4.ClienteLibros.EmpleadosService;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DAP4.ClienteLibros
{
    public class MetodosEmpleados
    {
        public IEnumerable<Empleados> listarEmpleados()
        {
            WebClient proxy = new WebClient();
            string urlServicio = "http://localhost/WcfBibliotecaService/EmpleadosService.svc/rest/ListarEmpleados";
            byte[] datos = proxy.DownloadData(urlServicio);
            Stream flujo = new MemoryStream(datos);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Empleados>));
            IEnumerable<Empleados> lista = obj.ReadObject(flujo) as IEnumerable<Empleados>;

            return lista;
        }
        public Empleados obtenerEmpleadoPorId(string id)
        {
            WebClient proxy = new WebClient();
            string urlServicio = "http://localhost/WcfBibliotecaService/EmpleadosService.svc/rest/ObtenerEmpleadoPorId/?id=" + id;
            byte[] datos = proxy.DownloadData(urlServicio);
            Stream flujo = new MemoryStream(datos);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Empleados));

            Empleados resultado = obj.ReadObject(flujo) as Empleados;

            return resultado;
        }
        public Empleados obtenerEmpleadoPorApellido(string apellido)
        {
            WebClient proxy = new WebClient();
            string urlServicio = "http://localhost/WcfBibliotecaService/EmpleadosService.svc/rest/ObtenerEmpleadoPorNombre/?apellido=" + apellido;
            byte[] datos = proxy.DownloadData(urlServicio);
            Stream flujo = new MemoryStream(datos);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Empleados));

            Empleados resultado = obj.ReadObject(flujo) as Empleados;

            return resultado;
        }
        public void insertarEmpleado(Empleados empleado)
        {

            WebClient proxy = new WebClient();

            string urlServicio = "http://localhost/WcfBibliotecaService/EmpleadosService.svc/rest/InsertarEmpleado";
            MemoryStream flujo = new MemoryStream();
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Empleados));
            obj.WriteObject(flujo, empleado);
            string data = Encoding.UTF8.GetString(flujo.ToArray(), 0, (int)flujo.Length);
            proxy.Headers["Content-type"] = "application/json";
            proxy.Encoding = Encoding.UTF8;
            proxy.UploadString(urlServicio, "POST", data);
        }
        public void actualizarEmpleado(Empleados empleado)
        {
            WebClient proxy = new WebClient();

            string urlServicio = "http://localhost/WcfBibliotecaService/EmpleadosService.svc/rest/ActualizarEmpleado";
            MemoryStream flujo = new MemoryStream();
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Empleados));
            obj.WriteObject(flujo, empleado);
            string data = Encoding.UTF8.GetString(flujo.ToArray(), 0, (int)flujo.Length);
            proxy.Headers["Content-type"] = "application/json";
            proxy.Encoding = Encoding.UTF8;
            proxy.UploadString(urlServicio, "PUT", data);
        }
        public void elimnarEmpleado(string id)
        {
            WebClient proxy = new WebClient();

            string urlServicio = "http://localhost/WcfBibliotecaService/EmpleadosService.svc/rest/EliminarEmpleado/?id=" + id;

            proxy.UploadString(urlServicio, "DELETE", id);
        }
    }
}

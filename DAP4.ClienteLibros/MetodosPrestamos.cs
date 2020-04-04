using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//para usar REST
using DAP4.ClienteLibros.PrestamosService;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DAP4.ClienteLibros
{
    public class MetodosPrestamos
    {
        public IEnumerable<Prestamos> listarPrestamos()
        {
            WebClient proxy = new WebClient();
            string urlServicio = "http://localhost/WcfBibliotecaService/PrestamosService.svc/rest/ListarPrestamos";
            byte[] datos = proxy.DownloadData(urlServicio);
            Stream flujo = new MemoryStream(datos);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Prestamos>));
            IEnumerable<Prestamos> lista = obj.ReadObject(flujo) as IEnumerable<Prestamos>;

            return lista;
        }

        public Prestamos obtenerPrestamo(string codigo)
        {
            WebClient proxy = new WebClient();
            string urlServicio = "http://localhost/WcfBibliotecaService/PrestamosService.svc/rest/ObtenerPrestamoPorCodigo/?codigo=" + codigo;
            byte[] datos = proxy.DownloadData(urlServicio);
            Stream flujo = new MemoryStream(datos);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Prestamos));

            Prestamos resultado = obj.ReadObject(flujo) as Prestamos;

            return resultado;
        }

        public void insertarPrestamo(Prestamos prestamo)
        {

            WebClient proxy = new WebClient();

            string urlServicio = "http://localhost/WcfBibliotecaService/PrestamosService.svc/rest/InsertarPrestamo";
            MemoryStream flujo = new MemoryStream();
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Prestamos));
            obj.WriteObject(flujo, prestamo);
            string data = Encoding.UTF8.GetString(flujo.ToArray(), 0, (int)flujo.Length);
            proxy.Headers["Content-type"] = "application/json";
            proxy.Encoding = Encoding.UTF8;
            proxy.UploadString(urlServicio, "POST", data);


        }
        public void actualizarPrestamo(Prestamos prestamo)
        {
            WebClient proxy = new WebClient();

            string urlServicio = "http://localhost/WcfBibliotecaService/PrestamosService.svc/rest/ActualizarPrestamo";
            MemoryStream flujo = new MemoryStream();
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Prestamos));
            obj.WriteObject(flujo, prestamo);
            string data = Encoding.UTF8.GetString(flujo.ToArray(), 0, (int)flujo.Length);
            proxy.Headers["Content-type"] = "application/json";
            proxy.Encoding = Encoding.UTF8;
            proxy.UploadString(urlServicio, "PUT", data);
        }
        public void devolverPrestamo(string id)
        {
            WebClient proxy = new WebClient();

            string urlServicio = "http://localhost/WcfBibliotecaService/PrestamosService.svc/rest/DevolverPrestamo/?id=" + id;

            proxy.UploadString(urlServicio, "PUT", id);
        }
    }
}

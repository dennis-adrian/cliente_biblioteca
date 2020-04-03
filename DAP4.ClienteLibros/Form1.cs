using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DAP4.ClienteLibros.LibrosService;
using DAP4.ClienteLibros.ClientesService;

//para usar REST
using DAP4.ClienteLibros.PrestamosService;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using RestSharp;

namespace DAP4.ClienteLibros
{
    public partial class Form1 : Form
    {
        LibrosServiceClient clienteLibros = new LibrosServiceClient();
        ClientesServiceClient clienteClientes = new ClientesServiceClient();
        MetodosPrestamos metodosPrestamos = new MetodosPrestamos();

                
        public Form1()
        {
            InitializeComponent();

            dtgLibros.DataSource = clienteLibros.ListarLibros();
            dtgPrestamos.DataSource = metodosPrestamos.listarPrestamos();
            dtgClientes.DataSource = clienteClientes.ListarClientes();
        }
        #region ServicioLibros
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var nombre= txtNombre.Text;
            var isbn = txtIsbn.Text;
            var anio = Convert.ToInt32(txtAnio.Text);
            var autor = txtAutor.Text;
            var genero = txtGenero.Text;

            clienteLibros.InsertarLibro(nombre, isbn, anio, autor, genero);

            MessageBox.Show("Se ingresó el libro correctamente.");


            var cargarDatos = clienteLibros.ListarLibros();

            dtgLibros.DataSource = cargarDatos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dtgBusqueda.Rows.Clear();

            try
            {
                if (String.IsNullOrWhiteSpace(txtIdLibroBuscar.Text))
                {
                    var nombre = txtNombreBuscar.Text;

                    var idLibro = clienteLibros.ObtenerLibroPorNombre(nombre).id_libro;
                    var nombreLibro = clienteLibros.ObtenerLibroPorNombre(nombre).libro_nombre;
                    var autor = clienteLibros.ObtenerLibroPorNombre(nombre).autor_nombre;
                    var genero = clienteLibros.ObtenerLibroPorNombre(nombre).genero_nombre;
                    var anio = clienteLibros.ObtenerLibroPorNombre(nombre).libro_anio_publicacion;
                    var isbn = clienteLibros.ObtenerLibroPorNombre(nombre).libro_isbn;

                    dtgBusqueda.Rows.Add(idLibro, nombreLibro, autor, genero, anio, isbn);

                }
                else
                {
                    var id = Convert.ToInt32(txtIdLibroBuscar.Text);

                    var nombreLibro = clienteLibros.ObtenerLibroPorId(id).libro_nombre;
                    var autor = clienteLibros.ObtenerLibroPorId(id).autor_nombre;
                    var genero = clienteLibros.ObtenerLibroPorId(id).genero_nombre;
                    var anio = clienteLibros.ObtenerLibroPorId(id).libro_anio_publicacion;
                    var isbn = clienteLibros.ObtenerLibroPorId(id).libro_isbn;

                    dtgBusqueda.Rows.Add(id, nombreLibro, autor, genero, anio, isbn);
                }
            }
            catch 
            {

                MessageBox.Show("El libro buscado no se encuentra en la base de datos");
            }

            

            txtIdLibroBuscar.Clear();
            txtNombreBuscar.Clear();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgBusqueda.Rows[0].Cells[0].Value.ToString());
            string nombre = dtgBusqueda.Rows[0].Cells[1].Value.ToString();
            string autor = dtgBusqueda.Rows[0].Cells[2].Value.ToString();
            string genero = dtgBusqueda.Rows[0].Cells[3].Value.ToString();
            int publicacion = Convert.ToInt32(dtgBusqueda.Rows[0].Cells[4].Value.ToString());
            string isbn = dtgBusqueda.Rows[0].Cells[5].Value.ToString();

            clienteLibros.ActualizarLibro(id, nombre, isbn, publicacion, autor, genero);

            MessageBox.Show("El libro \"" + nombre + "\" se actualizó correctamente.");

            dtgBusqueda.Rows.Clear();

            var cargarDatos = clienteLibros.ListarLibros();

            dtgLibros.DataSource = cargarDatos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dtgBusqueda.Rows[0].Cells[0].Value.ToString());

            clienteLibros.EliminarLibro(id);


            MessageBox.Show("El libro se eliminó satisfactoriamente.");

            dtgBusqueda.Rows.Clear();

            var cargarDatos = clienteLibros.ListarLibros();

            dtgLibros.DataSource = cargarDatos;

            txtIdLibroBuscar.Clear();
            txtNombreBuscar.Clear();
        }

        #endregion
        #region ServicioClientes
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = new Clientes()
                {
                    cliente_nombre = txtNombreClienteIsrt.Text,
                    cliente_apellido = txtApellidoClienteInsrt.Text,
                    cliente_fecha_nac = dttFechaNacimiento.Value,
                    cliente_domicilio = txtDomicilio.Text,
                    cliente_telefono = txtTelefono.Text,
                    cliente_email = txtEmail.Text,
                    id_cliente = 0
                };

                var resultado = clienteClientes.InsertarCliente(cliente);

                MessageBox.Show("Se resgistró el cliente " + cliente.cliente_apellido + " " + cliente.cliente_nombre+ " satisfactoriamente.");


                var cargarDatos = clienteClientes.ListarClientes();

                dtgClientes.DataSource = cargarDatos;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        private void btnBucarCliente_Click(object sender, EventArgs e)
        {
            dtgBusquedaCliente.Rows.Clear();

            try
            {
                if (String.IsNullOrWhiteSpace(txtIdClienteBusqueda.Text))
                {
                    var apellido = txtApellidoClienteBusqueda.Text;

                    var cliente =  clienteClientes.ObtenerClientePorApellido(apellido);

                    dtgBusquedaCliente.Rows.Add(cliente.id_cliente, cliente.cliente_apellido, cliente.cliente_nombre, cliente.cliente_email, cliente.cliente_telefono, cliente.cliente_fecha_nac.ToString("MM/dd/yyyy"), cliente.cliente_domicilio);

                }
                else
                {
                    var id = Convert.ToInt32(txtIdClienteBusqueda.Text);

                    var cliente = clienteClientes.ObtenerClientePorId(id);

                    dtgBusquedaCliente.Rows.Add(cliente.id_cliente, cliente.cliente_apellido, cliente.cliente_nombre, cliente.cliente_email, cliente.cliente_telefono, cliente.cliente_fecha_nac.ToString("MM/dd/yyyy"), cliente.cliente_domicilio);
                }
            }
            catch
            {

                MessageBox.Show("El libro cliente no se encuentra en la base de datos");
            }

            txtIdClienteBusqueda.Clear();
            txtApellidoClienteBusqueda.Clear();
        }
        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes obj = new Clientes()
                {
                    id_cliente = Convert.ToInt32(dtgBusquedaCliente.Rows[0].Cells[0].Value.ToString()),
                    cliente_nombre = dtgBusquedaCliente.Rows[0].Cells[2].Value.ToString(),
                    cliente_apellido = dtgBusquedaCliente.Rows[0].Cells[1].Value.ToString(),
                    cliente_fecha_nac = Convert.ToDateTime(dtgBusquedaCliente.Rows[0].Cells[5].Value.ToString()),
                    cliente_domicilio = dtgBusquedaCliente.Rows[0].Cells[6].Value.ToString(),
                    cliente_telefono = dtgBusquedaCliente.Rows[0].Cells[4].Value.ToString(),
                    cliente_email = dtgBusquedaCliente.Rows[0].Cells[3].Value.ToString(),
                };

                var cliente = clienteClientes.ActualizarCliente(obj);

                MessageBox.Show("El cliente \"" + cliente.cliente_apellido + " " + cliente.cliente_nombre + "\" se actualizó correctamente.");

                dtgBusquedaCliente.Rows.Clear();

                txtIdClienteBusqueda.Clear();
                txtApellidoClienteBusqueda.Clear();

                dtgBusquedaCliente.Rows.Add(cliente.id_cliente, cliente.cliente_apellido, cliente.cliente_nombre, cliente.cliente_email, cliente.cliente_telefono, cliente.cliente_fecha_nac.ToString("MM/dd/yyyy"), cliente.cliente_domicilio);

                var cargarDatos = clienteClientes.ListarClientes();

                dtgClientes.DataSource = cargarDatos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtgBusquedaCliente.Rows[0].Cells[0].Value.ToString());

                clienteClientes.EliminarCliente(id);


                MessageBox.Show("El cliente se eliminó satisfactoriamente.");

                dtgBusquedaCliente.Rows.Clear();

                var cargarDatos = clienteClientes.ListarClientes();

                dtgClientes.DataSource = cargarDatos;

                txtIdClienteBusqueda.Clear();
                txtApellidoClienteBusqueda.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region ServicioPrestamos
        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                var codigoPrestamo = txtCodigoPrestamo.Text;
                var nombreLibro = txtNombreLibro.Text;
                var nombreCliente = txtNombreCliente.Text;
                var apellidoCliente = txtApellidoCliente.Text;

                Prestamos prestamo = new Prestamos()
                {
                    prestamo_codigo = codigoPrestamo,
                    libro_nombre = nombreLibro,
                    cliente_apellido = apellidoCliente,
                    cliente_nombre = nombreCliente,
                    id_empleado = 5,
                    id_prestamo = 0,
                    prestamo_devolucion = DateTime.Now,
                    prestamo_fecha = DateTime.Now,
                    prestamo_devuelto = false,
                };
                metodosPrestamos.insertarPrestamo(prestamo);

                MessageBox.Show("El prestamo se registro correctamente");
                dtgPrestamos.DataSource = metodosPrestamos.listarPrestamos();

            }
            catch
            {
                MessageBox.Show("No se pudo registrar el prestamo. Verifique los datos ingresados");
            }
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            dtgBusquedaPrestamos.Rows.Clear();

            try
            {
                var codigo = txtCodigoBusqueda.Text;
                var prestamo = metodosPrestamos.obtenerPrestamo(codigo);
                string devuelto;
                
                if (prestamo.prestamo_devuelto) 
                {
                    devuelto = "SI";

                    dtgBusquedaPrestamos.Rows.Add(prestamo.id_prestamo, prestamo.prestamo_codigo, prestamo.prestamo_fecha, devuelto, prestamo.prestamo_devolucion, prestamo.libro_nombre, prestamo.cliente_apellido, prestamo.cliente_nombre);
                }
                else 
                { 
                    devuelto = "NO";

                    string fecha_devolucion = String.Empty;

                    dtgBusquedaPrestamos.Rows.Add(prestamo.id_prestamo, prestamo.prestamo_codigo,prestamo.prestamo_fecha, devuelto, fecha_devolucion, prestamo.libro_nombre, prestamo.cliente_apellido, prestamo.cliente_nombre);
                }
            }
            catch
            {
                MessageBox.Show("El prestamo buscado no se encuentra en la base de datos");
            }

            txtCodigoBusqueda.Clear();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dtgBusquedaPrestamos.Rows[0].Cells[0].Value.ToString();

                metodosPrestamos.devolverPrestamo(id);
                              
                MessageBox.Show("Libro devuelto.");

                var prestamo = metodosPrestamos.obtenerPrestamo(dtgBusquedaPrestamos.Rows[0].Cells[1].Value.ToString());

                dtgBusquedaPrestamos.Rows.Clear();

                dtgBusquedaPrestamos.Rows.Add(prestamo.id_prestamo, prestamo.prestamo_codigo, prestamo.prestamo_fecha, "SI", prestamo.prestamo_devolucion, prestamo.libro_nombre, prestamo.cliente_apellido, prestamo.cliente_nombre);

                txtCodigoBusqueda.Clear();

                dtgPrestamos.DataSource = metodosPrestamos.listarPrestamos();
            }
            catch
            {
                MessageBox.Show("No se pudo ejecutar la devolución del libro. Revise que el código de préstamo sea el correcto.");;
            }
        }

        private void btnActualizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dtgBusquedaPrestamos.Rows[0].Cells[0].Value.ToString();
                var codigoPrestamo = dtgBusquedaPrestamos.Rows[0].Cells[1].Value.ToString();
                var nombreLibro = dtgBusquedaPrestamos.Rows[0].Cells[5].Value.ToString();
                var apellidoCliente = dtgBusquedaPrestamos.Rows[0].Cells[6].Value.ToString();
                var nombreCliente = dtgBusquedaPrestamos.Rows[0].Cells[7].Value.ToString();

                Prestamos prestamo = new Prestamos()
                {
                    prestamo_codigo = codigoPrestamo,
                    libro_nombre = nombreLibro,
                    cliente_apellido = apellidoCliente,
                    cliente_nombre = nombreCliente,
                    id_empleado = 5,
                    id_prestamo = Convert.ToInt32(id),
                    prestamo_devolucion = DateTime.Now,
                    prestamo_fecha = DateTime.Now,
                    prestamo_devuelto = false,
                };

                metodosPrestamos.actualizarPrestamo(prestamo);
                MessageBox.Show("Se actualizaron los datos correctamente.");
                txtCodigoBusqueda.Clear();
                dtgPrestamos.DataSource = metodosPrestamos.listarPrestamos();
            }
            catch 
            {
                MessageBox.Show("No se pudieron actualizar los datos del préstamo.");
            }
        }
        #endregion

    }
}

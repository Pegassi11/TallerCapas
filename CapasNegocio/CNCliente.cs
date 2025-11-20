using System.Data;
using CapasDatos;
using CapasEntidad;

namespace CapasNegocio
{
    public class CNCliente
    {
        // importante la variable global. Instanciamos CD
        CDCliente CDCliente = new CDCliente();
        // validamos que los datos esten siendo registrados correctamente.  
        public bool validarDatos(CEClientes cliente)
        {
            bool validado = true; //variable de control 
            if (cliente.nombreComp == string.Empty)
            {
                MessageBox.Show("el campo nombre es obligatorio");
                validado = false;
            }
            if (cliente.cedCliente == string.Empty)
            {
                MessageBox.Show("el campo cedula es obligatorio");
                validado = false;
            }
            if (cliente.fotoCliente == string.Empty)
            {
                MessageBox.Show("el campo foto es obligatorio");
                validado = false;
            }
            if (cliente.montoTotal <= 0)
            {
                throw new Exception("El monto debe ser mayor que cero.");
            }

            return validado;
        }
        public void CrearCliente(CEClientes cE)
        {
            CDCliente.Crear(cE);
        }
        public DataSet obtenerDatos()
        {
            return CDCliente.lista();
        }

        // Nuevo método para devolver un DataTable directamente
        public DataTable obtenerDatosTabla()
        {
            var ds = CDCliente.lista();
            if (ds != null && ds.Tables.Contains("clientes"))
                return ds.Tables["clientes"];
            // Si por alguna razón no existe la tabla, devolver una tabla vacía para evitar null refs
            return new DataTable();
        }

        public void ActualizarCliente(CEClientes cE)
        {
            // Se reutiliza la validación para asegurar que los datos son correctos.
            validarDatos(cE);

            // Se pasa la orden a la capa de datos.
            CDCliente.Actualizar(cE);
        }
    }
}

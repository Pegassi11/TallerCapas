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
                MessageBox.Show("El monto debe ser mayor que cero.");
                validado = false;
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
    }
}

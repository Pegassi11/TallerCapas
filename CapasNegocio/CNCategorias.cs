using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapasDatos;

namespace CapasNegocio
{
    public class CNCategorias
    {
        private CDCategorias cDCategorias = new CDCategorias();

        public DataSet obtenerDatos()
        {
            return cDCategorias.lista();
        }
    }
}

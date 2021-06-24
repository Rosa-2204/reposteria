using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposteria.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListadeProdcutos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProdcutos = new List<Producto>();
        }

        public List<Producto> ObtenerProductos()
        {
            ListadeProdcutos = _contexto.Productos.ToList();
            return ListadeProdcutos;
        }
    }
}

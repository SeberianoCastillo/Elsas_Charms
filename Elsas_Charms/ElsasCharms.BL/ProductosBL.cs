using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsasCharms.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Anillo de Plata liso";
            producto1.Precio = 250;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Anillo de Plata decorado dama";
            producto2.Precio = 350;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Anillo de Plata decorado caballero";
            producto3.Precio = 350;

            var listaProductos = new List<Producto>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);

            return listaProductos;
        }
    }
}

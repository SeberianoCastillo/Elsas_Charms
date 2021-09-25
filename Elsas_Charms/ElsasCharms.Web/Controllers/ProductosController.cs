using ElsasCharms.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElsasCharms.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Anillo Plata liso";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Anillo Plata decorado dama";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Anillo Plata decorado caballero";

            var listaProductos = new List<ProductoModel>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);

            return View(listaProductos);
        }
    }
}
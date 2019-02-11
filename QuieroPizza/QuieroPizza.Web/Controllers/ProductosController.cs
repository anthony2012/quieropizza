using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 4 Estaciones";


            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pechurricas";


            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pan de ajo";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pizza Mexicana";


            var ListaProductos = new List<ProductoModel>();
            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);
            ListaProductos.Add(producto4);



            return View(ListaProductos  );
        }
    }
}
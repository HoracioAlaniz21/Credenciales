using DatosMVC.DAO;
using DatosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatosMVC.Controllers
{
    public class DatosController : Controller
    {
        DatosClass datosClass = new DatosClass();
        // GET: Datos
        public ActionResult Index()
        {
            List<Datos> datos = datosClass.Consultar();
            return View(datos);
        }

        public ActionResult Detalles(int id)
        {
            Datos datos = datosClass.Consultar(id);
            return View(datos);
        }

        public ActionResult Guardar()
        {
            return View();
        }

        public ActionResult Nuevo(Datos datos)
        {
            datosClass.Guardar(datos);
            //return View("Guardar", datos);
            return RedirectToAction("Index");
        }

       public ActionResult Editar(int id)
        {
            Datos datos = datosClass.Consultar(id);
            return View(datos);
        }
        public ActionResult Actualizar(Datos datos)
        {
            datosClass.Editar(datos);
            //return View("Editar", datos);
            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int id)
        {
            Datos datos = datosClass.Consultar(id);
            datosClass.Eliminar(datos);

           List<Datos> list = datosClass.Consultar();
            return View("Index", list);

        }
    }
}
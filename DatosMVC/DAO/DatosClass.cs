using DatosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatosMVC.DAO
{
    public class DatosClass
    {
        public List<Datos> Consultar()
        {
            using (DatosPersonalesEntities db = new DatosPersonalesEntities())
            {
                List<Datos> datos = db.Datos.ToList();
                return datos;
            }
        }

        public Datos Consultar(int id)
        {
            using (DatosPersonalesEntities db = new DatosPersonalesEntities())
            {
                Datos datos = db.Datos.FirstOrDefault(x=> x.DatosId == id);
                return datos;
            }
        }

        public void Guardar(Datos datos)
        {
            using (DatosPersonalesEntities db = new DatosPersonalesEntities())
            {
                db.Datos.Add(datos);
                db.SaveChanges();    
            }           
        }
        public void Editar(Datos datos)
        {
            using (DatosPersonalesEntities db = new DatosPersonalesEntities())
            {
                db.Entry(datos).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(Datos datos)
        {
            using (DatosPersonalesEntities db = new DatosPersonalesEntities())
            {
                db.Entry(datos).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
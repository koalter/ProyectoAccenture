using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MCV_Cualquiera.Models;

namespace MCV_Cualquiera.Controllers
{
    public class ArticulosController : Controller
    {
        private CualquieraDBEntities db = new CualquieraDBEntities();

        // GET: Articulos
        //public ActionResult Index()
        //{
        //    return View(db.Articulos.ToList());
        //}

        // GET: Articulos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulos.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // GET: Articulos/Create
        public ActionResult Create()
        {
            return View();
        }



        public ViewResult Index(string buscarCategoria, int buscarPrecio = 0)
        {
            List<Articulo> articulos = db.Articulos.ToList();
            
            if (!String.IsNullOrEmpty(buscarCategoria))
            {
            //Contiene las letras
            //autores = autores.Where(p => p.Apellido.Contains(buscar));
            //Comienza con la letra
                articulos = (from a in db.Articulos
                            where (a.categoria.StartsWith(buscarCategoria)
                                    && a.precio > buscarPrecio)
                            select a).ToList();
            }
            else
            {
                articulos = (from a in db.Articulos
                             where (a.precio > buscarPrecio)
                             select a).ToList();
            }
            //if (!String.IsNullOrEmpty(buscarPrecio.ToString()))
            //{
            //    articulos = (from a in db.Articulos
            //                 where a.precio > buscarPrecio
            //                 select a).ToList();
            //}

            return View(articulos);
        }

        //public ViewResult Index(int buscarPrecio)
        //{
        //    List<Articulo> articulos = db.Articulos.ToList();

        //    if (!String.IsNullOrEmpty(buscarPrecio.ToString()))
        //    {
        //        //Contiene las letras
        //        //autores = autores.Where(p => p.Apellido.Contains(buscar));
        //        //Comienza con la letra
        //        articulos = (from a in db.Articulos
        //                     where a.precio > buscarPrecio
        //                     select a).ToList();
        //    }

        //    return View(articulos);
        //}



        // POST: Articulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "articuloID,nombre,descripcion,precio,categoria")] Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                db.Articulos.Add(articulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(articulo);
        }

        // GET: Articulos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulos.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // POST: Articulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "articuloID,nombre,descripcion,precio,categoria")] Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(articulo);
        }

        // GET: Articulos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulos.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // POST: Articulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Articulo articulo = db.Articulos.Find(id);
            db.Articulos.Remove(articulo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

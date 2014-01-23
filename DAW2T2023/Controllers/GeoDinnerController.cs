using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAW2T2023.Controllers
{
    public class GeoDinnerController : Controller
    {
        //
        // GET: /GeoDinner/
        
        public ActionResult Index()
        {
            ViewBag.accion = RouteData.Values["action"];
            return View();
        }

        public ActionResult Restaurante(String value="Default")
        {
            ViewBag.accion = RouteData.Values["action"];
            ViewBag.valor = value;
            return View();
        }

        //
        // GET: /GeoDinner/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /GeoDinner/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GeoDinner/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GeoDinner/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /GeoDinner/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GeoDinner/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /GeoDinner/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

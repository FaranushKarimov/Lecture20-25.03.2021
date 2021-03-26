using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class AddController : Controller
    {
        // GET: AddController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

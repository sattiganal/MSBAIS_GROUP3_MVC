using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Group3MVCApp.Controllers
{
    public class InputController : Controller
    {
        // GET: InputController
        public ActionResult Name()
        {
            return View();
        }

        // GET: InputController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InputController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InputController/Create
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

        // GET: InputController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InputController/Edit/5
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

        // GET: InputController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InputController/Delete/5
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

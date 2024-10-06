using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PC0120240220200046RODRIGUEZ.API.Controllers
{
    public class OrganizersController : Controller
    {
        // GET: OrganizerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrganizerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrganizerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrganizerController/Create
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

        // GET: OrganizerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrganizerController/Edit/5
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

        // GET: OrganizerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrganizerController/Delete/5
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

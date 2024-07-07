using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Inovatube.Controllers
{
    public class InovatubeController : Controller
    {
        // GET: InovatubeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InovatubeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InovatubeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InovatubeController/Create
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

        // GET: InovatubeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InovatubeController/Edit/5
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

        // GET: InovatubeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InovatubeController/Delete/5
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

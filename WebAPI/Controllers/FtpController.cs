using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class FtpController : Controller
    {
        // GET: FtpController
        public ActionResult ListCustomer()
        {
            return View();
        }


        // GET: FtpController/Add
        public ActionResult AddCustomer()
        {
            return View();
        }

        // POST: FtpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCustomer(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(ListCustomer));
            }
            catch
            {
                return View();
            }
        }


        // GET: FtpController/Delete/5
        public ActionResult DeleteCustomer(int id)
        {
            return View();
        }

        // POST: FtpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCustomer(int id, IFormCollection collection)
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

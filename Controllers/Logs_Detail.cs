using Document_vault.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace dcvault_.Controllers
{
    public class Logs_Detail : Controller
    {
        // GET: Logs_Detail

        private readonly FileStoreContext _context;

        public Logs_Detail(FileStoreContext context)
        {

            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Logs_Detail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Route("[controller]/create")]
        // GET: Logs_Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logs_Detail/Create
        [HttpPost]
        [Route("[controller]/create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Logs_Details Model)
        {
           if(ModelState.IsValid)
            {
                _context.Add(Model);
                _context.SaveChanges();
            }
            return View();
        }

        // GET: Logs_Detail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Logs_Detail/Edit/5
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

        // GET: Logs_Detail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Logs_Detail/Delete/5
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

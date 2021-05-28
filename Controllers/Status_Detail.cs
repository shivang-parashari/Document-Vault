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
    public class Status_Detail : Controller
    {
        private readonly FileStoreContext _context;

        public Status_Detail(FileStoreContext context)
        {

            _context = context;
        }
        // GET: Status_Detail
        public ActionResult Index()
        {
            return View();
        }

        // GET: Status_Detail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Status_Detail/Create
        [Route("[controller]/create")]
        public ActionResult Create()
        {
            return View();
          
        }

        // POST: Status_Detail/Create
        [HttpPost]
        [Route("[controller]/create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Status_Details Model)
        {
           if(ModelState.IsValid)
            {
                _context.Add(Model);
                _context.SaveChanges();
            }
            return View();
        }

        // GET: Status_Detail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Status_Detail/Edit/5
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

        // GET: Status_Detail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Status_Detail/Delete/5
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

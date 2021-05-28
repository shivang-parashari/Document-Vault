using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using Document_vault.Data;

namespace dcvault_.Controllers
{
    public class Contact_Detail : Controller
    {
        private readonly FileStoreContext _context;

        public Contact_Detail(FileStoreContext context)
        {

            _context = context;
        }
        // GET: Contact_Detail
        [Route("[Controller]/create")]
       public ActionResult Index()
        {
            return View();
        }

        // GET: Contact_Detail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Route("[Controller]/create")]
        // GET: Company_detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company_detail/Create
        [HttpPost]
        [Route("[Controller]/create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Document_vault.Data.Contact_Detail Model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Model);
                _context.SaveChanges();
            }


            return View();
        }


        // GET: Contact_Detail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact_Detail/Edit/5
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

        // GET: Contact_Detail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact_Detail/Delete/5
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

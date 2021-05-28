using Document_vault.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
namespace dcvault_.Controllers
{
    [Route("[controller]")]
    public class Document_Date_Detail : Controller
    {

        private readonly FileStoreContext _context;

        public Document_Date_Detail(FileStoreContext context)
        {

            _context = context;
        }

        [Route("all")]
        [Authorize(Roles ="User,Admin")]
        // GET: Document_Date_Detail
        public ActionResult Index()
        {
            var ret = _context.Document_Date_Details.ToList();
            return View(ret);
        }

        [Route("all1")]
        [Authorize(Roles = "User")]
        // GET: Document_Date_Detail/Details/5
        public ActionResult Details(int id)
        {
            var ret = _context.Document_Date_Details.Find(id);
            return View(ret);
        }

        [Route("create")]
        [Authorize(Roles="User")]
        // GET: Document_Date_Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document_Date_Detail/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        [Authorize(Roles = "User")]
        public ActionResult Create(Document_Date_Detail model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();

            }
            return View();
        }


        // GET: Document_Date_Detail/Edit/5
        [Authorize(Roles = "User")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Document_Date_Detail/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User")]
        public ActionResult Edit(int id, Document_Date_Detail collection)
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

        // GET: Document_Date_Detail/Delete/5
        [Authorize(Roles = "User")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Document_Date_Detail/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Document_Date_Detail collection)
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

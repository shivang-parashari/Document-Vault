using Document_vault.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace dcvault_.Controllers
{
    public class User_detail : Controller
    {
        // GET: User_detail

        private readonly FileStoreContext _context;

        public User_detail(FileStoreContext context)
        {

            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: User_detail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Route("[controller]/create")]
        // GET: User_detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User_detail/Create
        [HttpPost]
     
        [Route("[controller]/create")]
        public ActionResult Create(User_Details model)
        {

            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();

            }
            return View();
        }

        // GET: User_detail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User_detail/Edit/5
    //    [HttpPost]
      //  [ValidateAntiForgeryToken]
  /**      public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: User_detail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User_detail/Delete/5
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
        }**/
    }
}

using Document_vault.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace dcvault_.Controllers
{
    public class Company_detail : Controller
    {
        private readonly FileStoreContext _context;

        public Company_detail(FileStoreContext context)
        {

            _context = context;
        }
        // GET: Company_detail
        [Route("Company")]
        
        public ActionResult Index()
        {
            var ret = _context.Company_Details.ToList();
            List<Company_Details> ret2 = ret;
            return View(ret2);
        }

        // GET: Company_detail/Details/5
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
        public ActionResult Create(Company_Details Model)
        {
            if(ModelState.IsValid)
            {
                _context.Add(Model);
                _context.SaveChanges();
            }

            
            return View();
        }

        // GET: Company_detail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company_detail/Edit/5
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

        // GET: Company_detail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company_detail/Delete/5
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

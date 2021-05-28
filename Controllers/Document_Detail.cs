using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Document_vault.Data;
using System.IO;
using WebApplication2.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace dcvault_.Controllers
{
    [Authorize]
    public class Document_Detail : Controller
    {

        private readonly FileStoreContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Document_Detail(FileStoreContext context, IWebHostEnvironment webHostEnvironment)
        {

            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }



         [Authorize(Roles ="User,Admin")]
        [Route("[controller]/Index")]
        public ActionResult Index()
        {
            return View(_context.Document_Details.ToList());
           
        }





        [Authorize(Roles = "User,Admin")]
        public ActionResult Details(int id)
        {
            var ret = _context.Document_Details.Find(id);
            return View(ret);
        }



        [Authorize(Roles = "User")]
        [Route("[controller]/create")]
        public ActionResult Create()
        {
            return View();
        }


        [Authorize(Roles = "User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[controller]/create")]
        public ActionResult Create(dcvault_.Models.Docs_detail Model)
         {
            if (ModelState.IsValid)
            {
                if (Model.Image_ != null)
                {
                    string folder = "Docs/";
                    folder += Guid.NewGuid().ToString() + Model.Image_.FileName;
                    Model.ScannedDoc = folder;
                    string serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    Model.Image_.CopyTo(new FileStream(serverfolder, FileMode.Create));
                }

                  var NewModel = new Document_vault.Data.Document_Detail()
                   {
                       DocType = Model.DocType,
                       DateId = Model.DateId,
                       DocTraffic = Model.DocTraffic,
                
                       PriorityLevel = Model.PriorityLevel,
                       ScannedDoc = Model.ScannedDoc,
                       StatusId = Model.StatusId,
                       Subject = Model.Subject,
                       IsoNum = Model.IsoNum,
                       ProfileId = Model.ProfileId,
                       Status_Details = Model.Status_Details,
                       Document_Date_Detail = Model.Document_Date_Detail

                   };
                
                _context.Add(NewModel);
                _context.SaveChanges();
            }
            return View();

        }



        [Authorize(Roles = "User")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var det = _context.Document_Details.Find(id);
            return View(det);
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Document_Detail model)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);


        }



        [Authorize(Roles = "User")]

        public ActionResult Delete(int id)
        {
            var ret = _context.Document_Details.Find(id);
            _context.Document_Details.Remove(ret);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
      
    }
}

using dcvault_.Models;
using Document_vault.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace dcvault_.Controllers
{
    public class User_Profile_Detail : Controller
    {

        private readonly FileStoreContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public User_Profile_Detail(FileStoreContext context , IWebHostEnvironment webHostEnvironment)
        {

            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

       


        [Authorize(Roles ="Admin")]
        [Route("[controller]/Index")]
        public ActionResult Index()
        {
           

            return View(_context.User_Profile_Details.ToList());
        }



        [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            var ret = _context.User_Profile_Details.Find(id);
            return View(ret);
        }
        [Route("[controller]/create")]

        [Authorize(Roles = "User")]
        public ActionResult Create()
        {
            return View();
        }



        [Authorize(Roles = "User")]
        [HttpPost]
        [Route("[controller]/create")]
        public ActionResult Create(userdetail Model)
        {
           if(ModelState.IsValid)
            {
               if( Model.Image_ != null)
                {
                    string folder = "Image/";
                    folder += Guid.NewGuid().ToString()+Model.Image_.FileName;
                    Model.Image = folder;
                    string serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    Model.Image_.CopyTo(new FileStream(serverfolder,FileMode.Create));
                }
                var newmodel = new User_Profile_Details()
                {
                    // ProfileId = Model.ProfileId,
                    UserId = Model.UserId,
                    CompanyId = Model.CompanyId,
                    Name = Model.Name,
                    Birthday = Model.Birthday,
                    Address = Model.Address,
                    Contact = Model.Contact,
                    Position = Model.Position,
                    Image = Model.Image,
                    Company_Details  = new Company_Details()
                    {
                        CompanyId = Model.CompanyId,
                        CompanyName = "abs",
                        CompanyAddress = "fg",
                        ContactNumber = 9758,
                        CompanyCategory = "op"
                    }
                };

                _context.Add(newmodel);
                _context.SaveChanges();
            }
            return View(); 
        }



        [Authorize(Roles = "User")]
        public ActionResult Edit(int id)
        {
            return View();
        }



        [Authorize(Roles = "User")]
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





        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var ret = _context.User_Profile_Details.Find(id);
            _context.User_Profile_Details.Remove(ret);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       
        
    }
}

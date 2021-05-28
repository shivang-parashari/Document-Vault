using Document_vault.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication2.Data;




namespace WebApplication2.Controllers
{

    

    public class AccountController : Controller
    {

        private readonly FileStoreContext _context;


        public AccountController(FileStoreContext context)
        {

            _context = context;
        }

        [Route("[controller]/LoginAdmin")]
        public IActionResult LoginAdmin()
        {
            return View();
        }

        [Route("[controller]/LoginAdmin")]
        [HttpPost]
        public IActionResult LoginAdmin(LoginAdmin model)
        {
            if (_context.Admin_s.Any(x => x.AdminId == model.Email && x.Password == model.Password))
            {
                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.Email),
                      new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Signup");




            }
            else
                ModelState.AddModelError("", "Invalid Login Credential");
            return View();
        }




        [Route("Role")]
        public IActionResult Role()
        {
            return View();
        }

        [HttpPost]
        [Route("Role")]
        public IActionResult Role(Role_Selection model)
        {
            if (ModelState.IsValid)
            {


                if (model.RoleId == "Admin")
                {
                    return RedirectToAction("LoginAdmin");

                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }


        [Route("[controller]/Signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [Route("[controller]/Signup")]
        [HttpPost]
        public IActionResult Signup(SignUp model)
        {

            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();

            }
            return RedirectToAction("Login");
        }


        [Route("[controller]/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("[controller]/Login")]
        [HttpPost]
        public IActionResult Login(Login model)
        {




            if (_context.SignUps.Any(x => x.Email == model.Email && x.Password == model.Password))
            {


                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.Email),
                     new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index","Home") ;

            }
            else
                ModelState.AddModelError("", "Invalid Login Credential");
            return View();
        }


        
        [Route("[controller]/signout")]
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Role");
        }




    }
}


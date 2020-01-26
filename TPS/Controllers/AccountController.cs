using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET_Core_3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_3.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
        }

        public IActionResult Login()
        {
            return View("Login1");
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var result = await SignInMgr.PasswordSignInAsync(username, password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Main", "Home");
            }
            else
            {
                ViewBag.Result = "result is " + result;
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();

            return RedirectToAction("Login", "Account");
        }

        public IActionResult Register()
        {
            return View("Register1");
        }

        [HttpPost]
        //public async Task<IActionResult> Register(string firstName, string lastName, string username, string password, string email)
        public async Task<IActionResult> Register(RegisterInfo registerInfo)
        {
            IdentityResult result;

            try
            {
                AppUser user = await UserMgr.FindByNameAsync(registerInfo.UserName);

                if (user == null)
                {
                    user = new AppUser
                    {
                        UserName = registerInfo.UserName,
                        Email = registerInfo.Email,
                        FirstName = registerInfo.FirstName,
                        LastName = registerInfo.LastName
                    };

                    result = await UserMgr.CreateAsync(user, registerInfo.Password);
                }
            
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return RedirectToAction("Login", "Account");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET_Core_3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TPS.Models;
using TPS.Services;

namespace ASPNET_Core_3.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        private IEmailService EmailService { get; }
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailService emailService)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
            EmailService = emailService;

            //emailService.SendAsync();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserMgr.FindByEmailAsync(model.Email);
                if (user != null /*&& await UserMgr.IsEmailConfirmedAsync(user)*/)
                {
                    var token = await UserMgr.GeneratePasswordResetTokenAsync(user);
                    var passwordResetLink =
                        Url.Action("ResetPassword", "Account", new {email = model.Email, token = token},
                            Request.Scheme);

                    var message = "Please click <a href=\"" + passwordResetLink + "\">" + "here" + "</a>" +
                                  " to reset password";

                    await EmailService.SendAsync(model.Email, message);

                    return View("ForgotPasswordConfirmation");
                }

                return View("ForgotPasswordConfirmation");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string token, string email)
        {
            if (token == null || email == null)
            {
                ModelState.AddModelError("", "Invalid password reset token");
            }

            return View();
        }

        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserMgr.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await UserMgr.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        return View("ResetPasswordConfirmation");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }

                return View("ResetPasswordConfirmation");
            }


            return View("ResetPasswordConfirmation");
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
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Result = "Invalid User or Password";

            return View("Login1");
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
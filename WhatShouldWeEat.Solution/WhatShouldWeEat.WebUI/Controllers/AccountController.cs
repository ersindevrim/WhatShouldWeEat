using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhatShouldWeEat.Business;
using WhatShouldWeEat.Business.Results;
using WhatShouldWeEat.Entities;
using WhatShouldWeEat.WebUI.ViewModels;

namespace WhatShouldWeEat.WebUI.Controllers
{
    public class AccountController : Controller
    {
        UManager _userManager = new UManager();

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(users loginModel)
        {
            string returnurlm = "";
            if (TempData["returnUrl"] != null)
            {
                returnurlm = TempData["returnUrl"].ToString();
            }
            ModelState.Clear();
            users user = _userManager.Find(x=>x.username == loginModel.username && x.password == loginModel.password);
            if (user != null)
            {
                if(user.isactive)
                {
                    if (LoginUser(user.username, user.password))
                    {
                        List<Claim> claims = new List<Claim>{
                        new Claim(ClaimTypes.Name, user.username)
                    };

                        if (user.isadmin == true)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                        }

                        ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync(principal);
                        if(Url.IsLocalUrl(returnurlm))
                        {
                            return Redirect(returnurlm);
                        }
                        return Redirect("/");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı Aktif Edilmemiş.");
                    return View(loginModel);
                }
            }
            ModelState.AddModelError("", "Kullanıcı Adı Yada Şifre Hatalı");
            return View(loginModel);
        }

        private bool LoginUser(string username, string password)
        {
            return true;
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(users model)
        {
            if (ModelState.IsValid)
            {
                BusinessResult<users> result = _userManager.RegisterNewUser(model);

                if (result.Errors.Count > 0)
                {
                    result.Errors.ForEach(x => ModelState.AddModelError("", x.Messages));
                    return View(model);
                }

                OkViewModel notifyObject = new OkViewModel()
                {
                    Title = "Kayıt Başarılı",
                    RedirectingUrl = "/Account/Login"
                };

                notifyObject.Items.Add("Lütfen E-Posta adresinize gönderilen aktivasyon linkini kontrol ediniz.");
                return View("Ok", notifyObject);
            }

            return View(model);
        }

        public ActionResult ActivateUser(string id)
        {

            BusinessResult<users> user = _userManager.ActivateUser(id);

            if (user.Errors.Count > 0)
            {
                ErrorViewModel notifyObject = new ErrorViewModel()
                {
                    Title = "Aktivasyon sırasında hata meydana geldi.",
                    Items = user.Errors
                };
                return View("Error", notifyObject);
            }

            OkViewModel notifyObj = new OkViewModel()
            {
                Title = "Kayıt aktif edildi",
                RedirectingUrl = "/Account/Login"
            };
            notifyObj.Items.Add("Aktivasyon işlemi başarı ile gerçekleşti.");
            return RedirectToAction("Login");
        }



        //Admin Paneli için
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(_userManager.List());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            users user = _userManager.Find(x => x.id == id.Value);
            if (user == null)
            {
                return StatusCode(404);
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(users user)
        {
            if (ModelState.IsValid)
            {
                users oldUser = _userManager.Find(x => x.id == user.id);

                oldUser.userkey = user.userkey;
                oldUser.username = user.username;
                oldUser.password = user.password;
                oldUser.mailadress = user.mailadress;
                oldUser.migroskey = user.migroskey;
                oldUser.getirkey = user.getirkey;
                oldUser.isactive = user.isactive;
                oldUser.isadmin = user.isadmin;

                _userManager.Update(oldUser);

                return RedirectToAction("Index");
            }
            return View(user);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode(400);
            }
            users user = _userManager.Find(x => x.id == id);
            if (user == null)
            {
                return StatusCode(404);
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            users user = _userManager.Find(x => x.id == id);
            _userManager.Delete(user);
            return RedirectToAction("Index");
        }
    }
}

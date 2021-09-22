using DuAnTotNghiep.Constant;
using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _webhostenvironment;
        private INguoiDungService _nguoidungservice;

        public AdminController(IWebHostEnvironment webhostenvironment, INguoiDungService nguoidungservice)
        {
            _webhostenvironment = webhostenvironment;
            _nguoidungservice = nguoidungservice;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string returnUrl)
        {
            string username = HttpContext.Session.GetString(SessionKey.NguoiDung.UserName);
            if (username != null && username != "")
            {
                return RedirectToAction("Index", "Home");
            }
            ViewLogin login = new ViewLogin();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(ViewLogin viewlogin)
        {
            if (ModelState.IsValid)
            {
                NguoiDung nguoidung = _nguoidungservice.Login(viewlogin);
                if (nguoidung != null)
                {
                    HttpContext.Session.SetString(SessionKey.NguoiDung.UserName, nguoidung.UserName);
                    HttpContext.Session.SetString(SessionKey.NguoiDung.FullName, nguoidung.FullName);
                    HttpContext.Session.SetString(SessionKey.NguoiDung.NguoiDungContext, JsonConvert.SerializeObject(nguoidung));
                    return RedirectToAction(nameof(Index), "Admin");
                }
            }
            return View(viewlogin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.GetString(SessionKey.NguoiDung.UserName);
            HttpContext.Session.GetString(SessionKey.NguoiDung.FullName);
            HttpContext.Session.GetString(SessionKey.NguoiDung.NguoiDungContext);
            return RedirectToAction(nameof(Index), "Admin");
        }
    }
}
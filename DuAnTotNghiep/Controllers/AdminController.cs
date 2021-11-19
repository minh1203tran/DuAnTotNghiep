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
        private INhanVienService _nhanvienservice;

        public AdminController(IWebHostEnvironment webhostenvironment, INhanVienService nhanvienservice)
        {
            _webhostenvironment = webhostenvironment;
            _nhanvienservice = nhanvienservice;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController
        public ActionResult Login(string returnUrl)
        {
            string username = HttpContext.Session.GetString(SessionKey.NhanVien.UserName);
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
                NhanVien nhanvien = _nhanvienservice.Login(viewlogin);
                if (nhanvien != null)
                {
                    HttpContext.Session.SetString(SessionKey.NhanVien.UserName, nhanvien.UserName);
                    HttpContext.Session.SetString(SessionKey.NhanVien.FullName, nhanvien.FullName);
                    HttpContext.Session.SetString(SessionKey.NhanVien.Role, nhanvien.Role.ToString());
                    HttpContext.Session.SetString(SessionKey.NhanVien.NhanVienContext, JsonConvert.SerializeObject(nhanvien));
                    return RedirectToAction(nameof(Index), "NhanVien");
                }
            }
            return View(viewlogin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKey.NhanVien.UserName);
            HttpContext.Session.Remove(SessionKey.NhanVien.FullName);
            HttpContext.Session.Remove(SessionKey.NhanVien.Role);
            HttpContext.Session.Remove(SessionKey.NhanVien.NhanVienContext);
            return RedirectToAction(nameof(Login), "Admin");
        }
    }
}
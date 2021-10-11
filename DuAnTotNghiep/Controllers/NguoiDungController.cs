using DuAnTotNghiep.Filters;
using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    [AuthenticationFilterAttibute]
    public class NguoiDungController : BaseController
    {
        private readonly IWebHostEnvironment _webhostenvironment;
        private INguoiDungService _nguoidungservice;

        public NguoiDungController(IWebHostEnvironment webhostenvironment, INguoiDungService nguoidungservice)
        {
            _webhostenvironment = webhostenvironment;
            _nguoidungservice = nguoidungservice;
        }

        // GET: NguoiDungController
        public ActionResult Index()
        {
            return View(_nguoidungservice.GetNguoiDungAll());
        }

        // GET: NguoiDungController/Details/5
        public ActionResult Details(int id)
        {
            var nguoidung = _nguoidungservice.GetNguoiDung(id);
            return View(nguoidung);
        }

        // GET: NguoiDungController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NguoiDungController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NguoiDung nguoidung)
        {
            try
            {
                _nguoidungservice.AddNguoiDung(nguoidung);
                return RedirectToAction(nameof(Details), new { id = nguoidung.NguoiDungId });
            }
            catch
            {
                return View();
            }
        }

        // GET: NguoiDungController/Edit/5
        public ActionResult Edit(int id)
        {
            var nguoidung = _nguoidungservice.GetNguoiDung(id);
            return View(nguoidung);
        }

        // POST: NguoiDungController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NguoiDung nguoidung)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _nguoidungservice.EditNguoiDung(id, nguoidung);
                }
                return RedirectToAction(nameof(Details), new { id = nguoidung.NguoiDungId });
            }
            catch
            {
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
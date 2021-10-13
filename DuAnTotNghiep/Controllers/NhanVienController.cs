﻿using DuAnTotNghiep.Filters;
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
    public class NhanVienController : BaseController
    {
        private readonly IWebHostEnvironment _webhostenvironment;
        private INhanVienService _nhanvienservice;

        public NhanVienController(IWebHostEnvironment webhostenvironment, INhanVienService nhanvienservice)
        {
            _webhostenvironment = webhostenvironment;
            _nhanvienservice = nhanvienservice;
        }

        // GET: NhanVienController
        public ActionResult Index()
        {
            return View(_nhanvienservice.GetNhanVienAll());
        }

        // GET: NhanVienController/Details/5
        public ActionResult Details(int id)
        {
            var nhanvien = _nhanvienservice.GetNhanVien(id);
            return View(nhanvien);
        }

        // GET: NhanVienController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVienController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhanVien nhanvien)
        {
            try
            {
                _nhanvienservice.AddNhanVien(nhanvien);
                return RedirectToAction(nameof(Details), new { id = nhanvien.NhanVienId });
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVienController/Edit/5
        public ActionResult Edit(int id)
        {
            var nhanvien = _nhanvienservice.GetNhanVien(id);
            return View(nhanvien);
        }

        // POST: NhanVienController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NhanVien nhanvien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _nhanvienservice.EditNhanVien(id, nhanvien);
                }
                return RedirectToAction(nameof(Details), new { id = nhanvien.NhanVienId });
            }
            catch
            {
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
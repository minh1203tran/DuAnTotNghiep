using DuAnTotNghiep.Filters;
using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    [AuthenticationFilterAttibute]
    public class SanPhamController : Controller
    {
        private readonly IWebHostEnvironment _webhostenvironment;
        private ISanPhamService _sanphamservice;
        private IUploadHelper _uploadhelper;

        public SanPhamController(IWebHostEnvironment webhostenvironment, ISanPhamService sanphamservice,IUploadHelper uploadhelper)
        {
            _webhostenvironment = webhostenvironment;
            _sanphamservice = sanphamservice;
            _uploadhelper = uploadhelper;
        }

        // GET: SanPhamController
        public ActionResult Index()
        {
            return View(_sanphamservice.GetSanPhamAll());
        }

        // GET: SanPhamController/Details/5
        public ActionResult Details(int id)
        {
            var sanpham = _sanphamservice.GetSanPham(id);
            return View(sanpham);
        }

        // GET: SanPhamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPhamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sanpham)
        {
            try
            {
                if (sanpham.ImageFile != null)
                {
                    if (sanpham.ImageFile.Length > 0)
                    {
                        string rootpath = Path.Combine(_webhostenvironment.WebRootPath, "Images");
                        _uploadhelper.UploadImage(sanpham.ImageFile, rootpath, "SanPham");
                        sanpham.HinhAnh = sanpham.ImageFile.FileName;
                    }
                }
                _sanphamservice.AddSanPham(sanpham);
                return RedirectToAction(nameof(Details), new { id = sanpham.SanPhamId });
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPhamController/Edit/5
        public ActionResult Edit(int id)
        {
            var sanpham = _sanphamservice.GetSanPham(id);
            return View(sanpham);
        }

        // POST: SanPhamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SanPham sanpham)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (sanpham.ImageFile != null)
                    {
                        if (sanpham.ImageFile.Length > 0)
                        {
                            string rootpath = Path.Combine(_webhostenvironment.WebRootPath, "Images");
                            _uploadhelper.UploadImage(sanpham.ImageFile, rootpath, "SanPham");
                            sanpham.HinhAnh = sanpham.ImageFile.FileName;
                        }
                    }
                    _sanphamservice.EditSanPham(id, sanpham);
                    return RedirectToAction(nameof(Details), new { id = sanpham.SanPhamId });
                }
            }
            catch
            {
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
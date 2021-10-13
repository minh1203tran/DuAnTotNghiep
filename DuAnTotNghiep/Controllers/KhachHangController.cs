using DuAnTotNghiep.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    public class KhachHangController : BaseController
    {
        private IKhachHangService _khachhangservice;

        public KhachHangController(IKhachHangService khachhangservice)
        {
            _khachhangservice = khachhangservice;
        }

        // GET: KhachHangController
        public ActionResult Index()
        {
            return View(_khachhangservice.GetKhachHangAll());
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(int id)
        {
            var khachhang = _khachhangservice.GetKhachHang(id);
            return View(khachhang);
        }
    }
}

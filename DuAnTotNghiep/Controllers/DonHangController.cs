using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    public class DonHangController : BaseController
    {
        private IDonHangService _donhangservice;
        private DataContext _dataContext;

        public DonHangController(IDonHangService donhangservice, DataContext dataContext)
        {
            _donhangservice = donhangservice;
            _dataContext = dataContext;
        }

        // GET: DonhangController
        public ActionResult Index()
        {
            return View(_donhangservice.GetDonHangAll());
        }

        // GET: DonhangController/Details/5
        public ActionResult Details(int id)
        {
            return View(_donhangservice.GetDonHang(id));
        }

        // GET: DonhangController/Edit/5
        public ActionResult Edit(int id)
        {
            var donhang = _donhangservice.GetDonHang(id);
            return View(donhang);
        }

        // POST: DonhangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DonHang donhang)
        {
            try
            {
                donhang.KhachHang = null;
                _donhangservice.EditDonHang(id, donhang);
                return RedirectToAction(nameof(Details), new { id = donhang.DonHangId });
            }
            catch
            {
                return View();
            }
        }
    }
}

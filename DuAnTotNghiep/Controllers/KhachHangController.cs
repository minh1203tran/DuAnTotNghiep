using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
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
        private DataContext _dataContext;

        public KhachHangController(IKhachHangService khachhangservice, DataContext dataContext)
        {
            _khachhangservice = khachhangservice;
            _dataContext = dataContext;
        }

        // GET: KhachHangController
        public ActionResult Index(string seachBy, string search)
        {
            if (seachBy == "FullName")
            {
                return View(_dataContext.KhachHangs.Where(s => s.FullName.Contains(search) || search == null));
            }
            else if (seachBy == "EmailAddress")
            {
                return View(_dataContext.KhachHangs.Where(s => s.EmailAddress.Contains(search) || search == null));
            }
            else
            {
                return View(_dataContext.KhachHangs.Where(s => s.Phone == search || search == null));
            }
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(int id)
        {
            var khachhang = _khachhangservice.GetKhachHang(id);
            return View(khachhang);
        }
    }
}

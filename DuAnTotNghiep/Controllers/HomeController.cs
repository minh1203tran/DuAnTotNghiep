using Castle.Core.Logging;
using DuAnTotNghiep.Constant;
using DuAnTotNghiep.Filters;
using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webhostenvironment;
        private ISanPhamService _sanphamservice;
        private IKhachHangService _Khachhangservice;
        private IDonHangService _donhangservice;
        private IDonHangChiTietService _donhangchitietservice;
        private DataContext _dataContext;

        public HomeController(IWebHostEnvironment webhostenvironment, ISanPhamService sanphamservice, IKhachHangService khachhangservice, IDonHangService donhangservice, IDonHangChiTietService donhangchitietservice, DataContext dataContext)
        {
            _webhostenvironment = webhostenvironment;
            _sanphamservice = sanphamservice;
            _Khachhangservice = khachhangservice;
            _donhangservice = donhangservice;
            _donhangchitietservice = donhangchitietservice;
            _dataContext = dataContext;
        }

        // GET: HomeController
        public ActionResult Index(string search)
        {
            return View(_dataContext.SanPhams.Where(s => s.Name.Contains(search) || search == null));
            //return View(_sanphamservice.GetSanPhamAll());
        }

        public IActionResult AddCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart == null)
            {
                var sanpham = _sanphamservice.GetSanPham(id);
                List<ViewCart> listcart = new List<ViewCart>()
                {
                    new ViewCart
                    {
                        SanPham = sanpham,
                        Quantity = 1
                    }
                };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listcart));
            }
            else
            {
                List<ViewCart> viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                bool check = true;
                for (int i = 0; i < viewcart.Count; i++)
                {
                    if (viewcart[i].SanPham.SanPhamId == id)
                    {
                        viewcart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    var sanpham = _sanphamservice.GetSanPham(id);
                    viewcart.Add(new ViewCart
                    {
                        SanPham = sanpham,
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(viewcart));
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult AddCartDetails(int id, int soluong)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart == null)
            {
                var sanpham = _sanphamservice.GetSanPham(id);
                List<ViewCart> listcart = new List<ViewCart>()
                {
                    new ViewCart
                    {
                        SanPham = sanpham,
                        Quantity = soluong
                    }
                };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listcart));
            }
            else
            {
                List<ViewCart> viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                bool check = true;
                for (int i = 0; i < viewcart.Count; i++)
                {
                    if (viewcart[i].SanPham.SanPhamId == id)
                    {
                        viewcart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    var sanpham = _sanphamservice.GetSanPham(id);
                    viewcart.Add(new ViewCart
                    {
                        SanPham = sanpham,
                        Quantity = soluong
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(viewcart));
            }
            return Ok();
        }

        //Giỏ hàng
        public IActionResult Cart()
        {
            List<ViewCart> viewcart = new List<ViewCart>();
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
            }
            return View(viewcart);
        }

        [HttpPost]
        public IActionResult UpdateCart(int id, int soluong)
        {
            var cart = HttpContext.Session.GetString("cart");
            double total = 0;
            if (cart != null)
            {
                List<ViewCart> viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                for (int i = 0; i < viewcart.Count; i++)
                {
                    if (viewcart[i].SanPham.SanPhamId == id)
                    {
                        viewcart[i].Quantity = soluong;
                        break;
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(viewcart));
                total = TongTien();
                return Ok(total);
            }
            return BadRequest();
        }

        public IActionResult DeleteCart(int id)
        {
            double total = 0;
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<ViewCart> viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                for (int i = 0; i < viewcart.Count; i++)
                {
                    if (viewcart[i].SanPham.SanPhamId == id)
                    {
                        viewcart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(viewcart));
                total = TongTien();
                return Ok(total);
            }
            return BadRequest();
        }

        [AuthenticationFilterAttibute_KH]
        public IActionResult OrderCart()
        {
            string kh_email = HttpContext.Session.GetString(SessionKey.KhachHang.KH_FullName);
            if (kh_email == null && kh_email == "")
            {
                return BadRequest();
            }
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null && cart.Count() > 0)
            {
                var khachhangcontext = HttpContext.Session.GetString(SessionKey.KhachHang.KhachHangContext);
                var khachhangid = JsonConvert.DeserializeObject<KhachHang>(khachhangcontext).KhachHangId;
                double total = TongTien();
                var donhang = new DonHang()
                {
                    TrangThaiDonHang = TrangThaiDonHang.MoiDat,
                    KhachHangId = khachhangid,
                    TongTien = total,
                    NgayDat = DateTime.Now,
                    GhiChu = ""
                };
                _donhangservice.AddDonHang(donhang);
                int donhangid = donhang.DonHangId;
                List<ViewCart> viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                for (int i = 0; i < viewcart.Count; i++)
                {
                    DonHangChiTiet chitiet = new DonHangChiTiet()
                    {
                        DonHangId = donhangid,
                        SanPhamId = viewcart[i].SanPham.SanPhamId,
                        SoLuong = viewcart[i].Quantity,
                        ThanhTien = viewcart[i].SanPham.Gia * viewcart[i].Quantity,
                        GhiChu = ""
                    };
                    _donhangchitietservice.AddDonHangChiTiet(chitiet);
                }
                HttpContext.Session.Remove("cart");
                return Ok();
            }
            return BadRequest();
        }

        [NonAction]
        private double TongTien()
        {
            double total = 0;
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<ViewCart> viewcart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                for (int i = 0; i < viewcart.Count; i++)
                {
                    total += (viewcart[i].SanPham.Gia * viewcart[i].Quantity);
                }
            }
            return total;
        }

        public IActionResult Login(string returnurl)
        {
            string kh_email = HttpContext.Session.GetString(SessionKey.KhachHang.KH_FullName);
            if (kh_email != null && kh_email != "")
            {
                return RedirectToAction("Index", "Home");
            }
            #region
            ViewWebLogin login = new ViewWebLogin();
            login.ReturnUrl = returnurl;
            return View(login);
            #endregion
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(ViewWebLogin viewWebLogin)
        {
            if (ModelState.IsValid)
            {
                KhachHang khachhang = _Khachhangservice.Login(viewWebLogin);
                if (khachhang != null)
                {
                    HttpContext.Session.SetString(SessionKey.KhachHang.KH_Email, khachhang.EmailAddress);
                    HttpContext.Session.SetString(SessionKey.KhachHang.KH_FullName, khachhang.FullName);
                    HttpContext.Session.SetString(SessionKey.KhachHang.KH_Id, khachhang.KhachHangId.ToString());
                    HttpContext.Session.SetString(SessionKey.KhachHang.KhachHangContext, JsonConvert.SerializeObject(khachhang));
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
            }
            return View(viewWebLogin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKey.KhachHang.KH_Email);
            HttpContext.Session.Remove(SessionKey.KhachHang.KH_FullName);
            HttpContext.Session.Remove(SessionKey.KhachHang.KH_Id);
            HttpContext.Session.Remove(SessionKey.KhachHang.KhachHangContext);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(KhachHang khachhang)
        {
            try
            {
                _Khachhangservice.AddKhachHang(khachhang);
                return RedirectToAction(nameof(Login), new { id = khachhang.KhachHangId });
            }
            catch
            {
                return View();
            }
        }

        [AuthenticationFilterAttibute_KH]
        public ActionResult Info(int id)
        {
            string kh_email = HttpContext.Session.GetString(SessionKey.KhachHang.KH_FullName);
            if (kh_email == null && kh_email == "")
            {
                return RedirectToAction("Index", "Home");
            }
            var khachhang = _Khachhangservice.GetKhachHang(id);
            return View(khachhang);
        }

        [HttpPost]
        [AuthenticationFilterAttibute_KH]
        [ValidateAntiForgeryToken]
        public ActionResult Info(int id, KhachHang khachhang)
        {
            try
            {
                var _khachhang = _Khachhangservice.GetKhachHang(id);
                khachhang.PassWord = _khachhang.PassWord;
                khachhang.ConfirmPassWord = _khachhang.PassWord;
                _Khachhangservice.EditKhachHang(id, khachhang);
                return RedirectToAction(nameof(Index), new { id = khachhang.KhachHangId });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction(nameof(Index));
        }

        [AuthenticationFilterAttibute_KH]
        public IActionResult History(int id)
        {
            string kh_email = HttpContext.Session.GetString(SessionKey.KhachHang.KH_FullName);
            var khachhangcontext = HttpContext.Session.GetString(SessionKey.KhachHang.KhachHangContext);
            id = JsonConvert.DeserializeObject<KhachHang>(khachhangcontext).KhachHangId;
            if (kh_email == null || kh_email == "")
            {
                return RedirectToAction("Index", "Home");
            }
            return View(_donhangservice.GetDonHangbyKhachHang(id));
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }

        public ActionResult TinTuc()
        {
            return View();
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(int id)
        {
            var khachhang = _Khachhangservice.GetKhachHang(id);
            return View(khachhang);
        }

        // POST: KhachHangController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, KhachHang khachHang)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Khachhangservice.EditKhachHang(id, khachHang);
                }
                return RedirectToAction(nameof(Info), new { id = khachHang.KhachHangId });
            }
            catch
            {
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: HomeController/Details/5
        [AuthenticationFilterAttibute_KH]
        public ActionResult ChiTietDonHang(int id)
        {
            return View(_donhangservice.GetDonHang(id));
        }

        public ActionResult ChiTietSanPham(int id)
        {
            var sanpham = _sanphamservice.GetSanPham(id);
            return View(sanpham);
        }        
    }
}
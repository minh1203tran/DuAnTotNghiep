using DuAnTotNghiep.Constant;
using DuAnTotNghiep.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Controllers
{
    [AuthenticationFilterAttibute]
    public class BaseController : Controller
    {
        public BaseController()
        {
        }
        
        protected string GetUserName()
        {
            return HttpContext.Session.GetString(SessionKey.NhanVien.UserName);
        }

        protected string GetFullName()
        {
            return HttpContext.Session.GetString(SessionKey.NhanVien.FullName);
        }

        protected string GetKHEmail()
        {
            return HttpContext.Session.GetString(SessionKey.KhachHang.KH_Email);
        }
    }
}
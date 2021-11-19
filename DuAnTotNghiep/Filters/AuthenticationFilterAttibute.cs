using DuAnTotNghiep.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Filters
{
    public class AuthenticationFilterAttibute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Controller controller = context.Controller as Controller;
            var session = context.HttpContext.Session;
            string userName = context.HttpContext.Session.GetString(SessionKey.NhanVien.UserName);
            string role = context.HttpContext.Session.GetString(SessionKey.NhanVien.Role);
            var sessionStatus = ((userName != null && userName != "") ? true : false);
            if (controller != null)
            {
                if (session == null || !sessionStatus)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Admin" }, { "Action", "Login" } });
                }
            }
            base.OnActionExecuting(context);
        }
    }

    public class AuthenticationFilterAttibute_KH : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Controller controller = context.Controller as Controller;
            var session = context.HttpContext.Session;
            string KH_Email = context.HttpContext.Session.GetString(SessionKey.KhachHang.KH_Email);
            var sessionStatus = ((KH_Email != null && KH_Email != "") ? true : false);
            if (controller != null)
            {
                if (session == null || !sessionStatus)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Login" } });
                }
            }
            base.OnActionExecuting(context);
        }
    }
}
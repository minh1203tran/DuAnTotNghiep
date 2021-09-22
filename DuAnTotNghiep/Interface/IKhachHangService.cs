using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Interface
{
    public interface IKhachHangService
    {
        List<KhachHang> GetKhachHangAll();

        KhachHang GetKhachHang(int id);

        int AddKhachHang(KhachHang khachhang);

        int EditKhachHang(int id, KhachHang khachhang);

        KhachHang Login(ViewWebLogin viewweblogin);
    }
}

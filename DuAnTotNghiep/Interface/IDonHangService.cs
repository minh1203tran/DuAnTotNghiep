using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Interface
{
    public interface IDonHangService
    {
        List<DonHang> GetDonHangAll();

        List<DonHang> GetDonHangbyKhachHang(int KhachHangId);

        DonHang GetDonHang(int id);

        int AddDonHang(DonHang donhang);

        int EditDonHang(int id, DonHang donhang);
    }
}

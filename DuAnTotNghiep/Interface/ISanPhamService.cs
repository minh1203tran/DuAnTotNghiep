using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Interface
{
    public interface ISanPhamService
    {
        List<SanPham> GetSanPhamAdd();

        SanPham GetSanPham(int id);

        int AddSanPham(SanPham sanpham);

        int EditSanPham(int id, SanPham sanpham);
    }
}

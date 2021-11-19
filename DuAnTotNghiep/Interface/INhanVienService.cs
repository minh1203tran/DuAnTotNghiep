using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Interface
{
    public interface INhanVienService
    {
        List<NhanVien> GetNhanVienAll();

        NhanVien GetNhanVien(int id);

        int AddNhanVien(NhanVien nhanvien);

        int EditNhanVien(int id, NhanVien nhanvien);

        NhanVien Login(ViewLogin viewlogin);

        //IEnumerable<NhanVien> ListPaging(int page, int pageSize);
    }
}

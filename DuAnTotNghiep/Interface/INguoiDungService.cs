using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Interface
{
    public interface INguoiDungService
    {
        List<NguoiDung> GetNguoiDungAll();

        NguoiDung GetNguoiDung(int id);

        int AddNguoiDung(NguoiDung nguoidung);

        int EditNguoiDung(int id, NguoiDung nguoidung);

        NguoiDung Login(ViewLogin viewlogin);
    }
}

using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Service
{
    public class SanPhamService : ISanPhamService
    {
        protected DataContext _datacontext;

        public SanPhamService(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<SanPham> GetSanPhamAdd()
        {
            List<SanPham> list = new List<SanPham>();
            list = _datacontext.SanPhams.ToList();
            return list;
        }

        public SanPham GetSanPham(int id)
        {
            SanPham sanpham = null;
            sanpham = _datacontext.SanPhams.Find(id);
            return sanpham;
        }

        public int AddSanPham(SanPham sanpham)
        {
            int ret = 0;
            try
            {
                _datacontext.SanPhams.Add(sanpham);
                _datacontext.SaveChanges();
                ret = sanpham.SanPhamId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditSanPham(int id, SanPham sanpham)
        {
            int ret = 0;
            try
            {
                SanPham _sanpham = null;
                _sanpham = _datacontext.SanPhams.Find(id);
                _sanpham.Name = sanpham.Name;
                _sanpham.Gia = sanpham.Gia;
                _sanpham.PhanLoai = sanpham.PhanLoai;
                _sanpham.HinhAnh = sanpham.HinhAnh;
                _sanpham.Mota = sanpham.Mota;
                _sanpham.TrangThai = sanpham.TrangThai;
                _datacontext.Update(_sanpham);
                _datacontext.SaveChanges();
                ret = sanpham.SanPhamId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}

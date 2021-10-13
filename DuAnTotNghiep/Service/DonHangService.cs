using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Service
{
    public class DonHangService : IDonHangService
    {
        protected DataContext _datacontext;

        public DonHangService(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<DonHang> GetDonHangAll()
        {
            List<DonHang> list = new List<DonHang>();
            list = _datacontext.DonHangs.OrderByDescending(x => x.NgayDat).Include(x => x.KhachHang).Include(x => x.DonHangChiTiets).ToList();
            return list;
        }

        public List<DonHang> GetDonHangbyKhachHang(int KhachHangId)
        {
            List<DonHang> list = new List<DonHang>();
            list = _datacontext.DonHangs.Where(x => x.KhachHangId == KhachHangId).OrderByDescending(x => x.NgayDat).Include(x => x.KhachHang).Include(x => x.DonHangChiTiets).ToList();
            return list;
        }

        public DonHang GetDonHang(int id)
        {
            DonHang donhang = null;
            donhang = _datacontext.DonHangs.Where(x => x.DonHangId == id).Include(x => x.KhachHang).Include(x => x.DonHangChiTiets).ThenInclude(y => y.SanPham).FirstOrDefault();
            return donhang;
        }

        public int AddDonHang(DonHang donhang)
        {
            int ret = 0;
            try
            {
                _datacontext.Add(donhang);
                _datacontext.SaveChanges();
                ret = donhang.DonHangId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditDonHang(int id, DonHang donhang)
        {
            int ret = 0;
            try
            {
                _datacontext.Update(donhang);
                _datacontext.SaveChanges();
                ret = donhang.DonHangId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}
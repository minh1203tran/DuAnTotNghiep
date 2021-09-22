using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Service
{
    public class DonHangChiTietService : IDonHangChiTietService
    {
        protected DataContext _datacontext;

        public DonHangChiTietService(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public int AddDonHangChiTiet(DonHangChiTiet donhangchitiet)
        {
            int ret = 0;
            try
            {
                _datacontext.Add(donhangchitiet);
                _datacontext.SaveChanges();
                ret = donhangchitiet.ChiTietId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}

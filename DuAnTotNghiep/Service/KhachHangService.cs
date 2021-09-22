using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Service
{
    public class KhachHangService : IKhachHangService
    {
        protected DataContext _datacontext;
        protected IMahoaHelper _mahoahelper;

        public KhachHangService(DataContext datacontext, IMahoaHelper mahoahelper)
        {
            _datacontext = datacontext;
            _mahoahelper = mahoahelper;
        }

        public List<KhachHang> GetKhachHangAll()
        {
            List<KhachHang> list = new List<KhachHang>();
            list = _datacontext.KhachHangs.ToList();
            return list;
        }

        public KhachHang GetKhachHang(int id)
        {
            KhachHang khachhang = null;
            khachhang = _datacontext.KhachHangs.Find(id);
            return khachhang;
        }

        public int AddKhachHang(KhachHang khachhang)
        {
            int ret = 0;
            try
            {
                khachhang.PassWord = _mahoahelper.MaHoa(khachhang.PassWord);
                khachhang.ConfirmPassWord = khachhang.PassWord;
                _datacontext.Add(khachhang);
                _datacontext.SaveChanges();
                ret = khachhang.KhachHangId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditKhachHang(int id, KhachHang khachhang)
        {
            int ret = 0;
            try
            {
                KhachHang _khachhang = null;
                _khachhang = _datacontext.KhachHangs.Find(id);
                _khachhang.FullName = khachhang.FullName;
                _khachhang.NgaySinh = khachhang.NgaySinh;
                _khachhang.PhoneName = khachhang.PhoneName;
                _khachhang.EmailAddress = khachhang.EmailAddress;
                if (_khachhang.PassWord != null)
                {
                    khachhang.PassWord = _mahoahelper.MaHoa(khachhang.PassWord);
                    _khachhang.PassWord = khachhang.PassWord;
                    _khachhang.ConfirmPassWord = khachhang.PassWord;
                }
                _khachhang.MoTa = khachhang.MoTa;
                _datacontext.Update(_khachhang);
                _datacontext.SaveChanges();
                ret = khachhang.KhachHangId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public KhachHang Login(ViewWebLogin viewweblogin)
        {
            var u = _datacontext.KhachHangs.Where(p => p.EmailAddress.Equals(viewweblogin.Email) && p.PassWord.Equals(_mahoahelper.MaHoa(viewweblogin.PassWord))).FirstOrDefault();
            return u;
        }
    }
}

using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Service
{
    public class NguoiDungService : INguoiDungService
    {
        protected DataContext _datacontext;
        protected IMahoaHelper _mahoahelper;

        public NguoiDungService(DataContext datacontext, IMahoaHelper mahoahelper)
        {
            _datacontext = datacontext;
            _mahoahelper = mahoahelper;
        }

        public List<NguoiDung> GetNguoiDungAll()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            list = _datacontext.NguoiDungs.ToList();
            return list;
        }

        public NguoiDung GetNguoiDung(int id)
        {
            NguoiDung nguoidung = null;
            nguoidung = _datacontext.NguoiDungs.Find(id);
            return nguoidung;
        }

        public int AddNguoiDung(NguoiDung nguoidung)
        {
            int ret = 0;
            try
            {
                nguoidung.PassWord = _mahoahelper.MaHoa(nguoidung.PassWord);
                _datacontext.Add(nguoidung);
                _datacontext.SaveChanges();
                ret = nguoidung.NguoiDungId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditNguoiDung(int id, NguoiDung nguoidung)
        {
            int ret = 0;
            try
            {
                NguoiDung _nguoidung = null;
                _nguoidung = _datacontext.NguoiDungs.Find(id);
                _nguoidung.UserName = nguoidung.UserName;
                _nguoidung.FullName = nguoidung.FullName;
                _nguoidung.Title = nguoidung.Title;
                _nguoidung.DOB = nguoidung.DOB;
                _nguoidung.Email = nguoidung.Email;
                _nguoidung.Admin = nguoidung.Admin;
                _nguoidung.Looked = nguoidung.Looked;
                if (_nguoidung.PassWord != null)
                {
                    nguoidung.PassWord = _mahoahelper.MaHoa(nguoidung.PassWord);
                    _nguoidung.PassWord = nguoidung.PassWord;
                }
                _datacontext.Update(_nguoidung);
                _datacontext.SaveChanges();
                ret = nguoidung.NguoiDungId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public NguoiDung Login(ViewLogin viewlogin)
        {
            var u = _datacontext.NguoiDungs.Where(p => p.UserName.Equals(viewlogin.UserName) && p.PassWord.Equals(_mahoahelper.MaHoa(viewlogin.PassWord))).FirstOrDefault();
            return u;
        }
    }
}
using DuAnTotNghiep.Interface;
using DuAnTotNghiep.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Service
{
    public class NhanVienService : INhanVienService
    {
        protected DataContext _datacontext;
        protected IMahoaHelper _mahoahelper;

        public NhanVienService(DataContext datacontext, IMahoaHelper mahoahelper)
        {
            _datacontext = datacontext;
            _mahoahelper = mahoahelper;
        }

        public List<NhanVien> GetNhanVienAll()
        {
            List<NhanVien> list = new List<NhanVien>();
            list = _datacontext.NhanViens.ToList();
            return list;
        }

        public NhanVien GetNhanVien(int id)
        {
            NhanVien nhanvien = null;
            nhanvien = _datacontext.NhanViens.Find(id);
            return nhanvien;
        }

        public int AddNhanVien(NhanVien nhanvien)
        {
            int ret = 0;
            try
            {
                nhanvien.PassWord = _mahoahelper.MaHoa(nhanvien.PassWord);
                _datacontext.Add(nhanvien);
                _datacontext.SaveChanges();
                ret = nhanvien.NhanVienId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditNhanVien(int id, NhanVien nhanvien)
        {
            int ret = 0;
            try
            {
                NhanVien _nhanvien = null;
                _nhanvien = _datacontext.NhanViens.Find(id);
                _nhanvien.UserName = nhanvien.UserName;
                _nhanvien.FullName = nhanvien.FullName;
                _nhanvien.TenChucVu = nhanvien.TenChucVu;
                _nhanvien.NgaySinh = nhanvien.NgaySinh;
                _nhanvien.Email = nhanvien.Email;
                _nhanvien.Role = nhanvien.Role;
                _nhanvien.SuDung = nhanvien.SuDung;
                if (_nhanvien.PassWord != null)
                {
                    if(_nhanvien.PassWord == nhanvien.PassWord)
                    {
                        _nhanvien.PassWord = _nhanvien.PassWord;
                        _nhanvien.ConfirmPassWord = _nhanvien.PassWord;
                    }
                    else
                    {
                        _nhanvien.PassWord = _mahoahelper.MaHoa(nhanvien.PassWord);
                        _nhanvien.PassWord = nhanvien.PassWord;
                        _nhanvien.ConfirmPassWord = _nhanvien.PassWord;
                    }                    
                }
                _datacontext.Update(_nhanvien);
                _datacontext.SaveChanges();
                ret = nhanvien.NhanVienId;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                ret = 0;
            }
            return ret;
        }

        public NhanVien Login(ViewLogin viewlogin)
        {
            var u = _datacontext.NhanViens.Where(p => p.UserName.Equals(viewlogin.UserName) && p.PassWord.Equals(_mahoahelper.MaHoa(viewlogin.PassWord))).FirstOrDefault();
            return u;
        }

        //public IEnumerable<NhanVien> ListPaging(int page, int pageSize)
        //{
        //    return _datacontext.NhanViens.OrderByDescending(x => x.NhanVienId).ToPagedList(page, pageSize);
        //}
    }
}
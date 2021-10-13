using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DuAnTotNghiep.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        //{
        //}

        public DbSet<DonHang> DonHangs { get; set; }

        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }

        public DbSet<KhachHang> KhachHangs { get; set; }

        public DbSet<NhanVien> NhanViens { get; set; }

        public DbSet<SanPham> SanPhams { get; set; }
    }
}

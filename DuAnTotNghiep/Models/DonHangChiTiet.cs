using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    [Table("DonHangChiTiet")]
    public class DonHangChiTiet
    {
        //test commit
        [Key]
        public int ChiTietId { get; set; }

        [ForeignKey("DonHang")]
        public int DonHangId { get; set; }

        [ForeignKey("SanPham")]
        public int SanPhamId { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = ("Bạn phải nhập số lượng."))]
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = ("Bạn phải nhập thành tiền."))]
        [Display(Name = "Thành tiền")]
        public double ThanhTien { get; set; }

        [StringLength(250)]
        [Display(Name = "Ghi chú")]
        [Column(TypeName = "nvarchar(250)")]
        public string GhiChu { get; set; }

        public DonHang DonHang { get; set; }

        public SanPham SanPham { get; set; }
    }
}
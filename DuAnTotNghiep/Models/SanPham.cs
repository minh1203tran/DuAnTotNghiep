using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DuAnTotNghiep.Models
{
    public enum PhanLoai
    {
        [Display(Name = "Giày nam")]
        GiayNam = 1,
        [Display(Name = "Giày nữ")]
        GiayNu = 2
    }

    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [Display(Name = "Mã sản phẩm")]
        public int SanPhamId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm.")]
        [Display(Name = "Tên sản phẩm")]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giá."), Range(0, double.MaxValue, ErrorMessage = "Bạn phải nhập giá.")]
        [Display(Name = "Giá")]
        public double Gia { get; set; }

        [Display(Name = "Phân loại")]
        [Required(ErrorMessage = "Bạn hãy chọn phân loại."), Range(1, int.MaxValue, ErrorMessage = "Bạn hãy chọn phân loại.")]
        public PhanLoai PhanLoai { get; set; }

        [StringLength(100)]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get; set; }

        [NotMapped]
        [Display(Name = "Chọn hình")]
        public IFormFile ImageFile { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        [Column(TypeName = "nvarchar(250)")]
        public string Mota { get; set; }

        [Display(Name = " Đang phục vụ")]
        public bool TrangThai { get; set; }
    }
}

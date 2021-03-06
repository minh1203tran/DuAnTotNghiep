using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [Display(Name = "Mã nhân viên")]
        public int NhanVienId { get; set; }

        [Column(TypeName = "varchar(50)"), StringLength(50)]
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "Bạn phải nhập tên tài khoản.")]
        public string UserName { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Bạn phải nhập họ và tên.")]
        [Column(TypeName = "nvarchar(50)"), StringLength(50)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập email.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email không được bỏ trống.")]
        public string Email { get; set; }

        [Display(Name = "Chức vụ")]
        [Column(TypeName = "nvarchar(50)"), StringLength(50)]
        public string TenChucVu { get; set; }

        [Display(Name = "Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? NgaySinh { get; set; }

        [Display(Name = "Quản trị")]
        public bool Role { get; set; }

        [Display(Name = "Trạng thái")]
        public bool TrangThai { get; set; }

        [Display(Name = "Mật khẩu")]
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Display(Name = "Nhập lại mật khẩu")]
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "Mật khẩu bạn nhập lại không đúng.")]
        [NotMapped]
        public string ConfirmPassWord { get; set; }
    }
}
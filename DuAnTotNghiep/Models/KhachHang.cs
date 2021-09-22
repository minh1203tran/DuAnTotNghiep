using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int KhachHangId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bạn phải nhập tên khách hàng.")]
        [Display(Name = "Họ và tên")]
        [Column(TypeName = "nvarchar(50)")]
        public string FullName { get; set; }

        [Display(Name = "Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập số điện thoại.")]
        [Column(TypeName = "varchar(10)")]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số điện thoại của bạn không đúng.")]
        [Display(Name = "Số điện thoại")]
        public string PhoneName { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập địa chỉ email.")]
        [Column(TypeName = "nvarchar(100)"), StringLength(100)]
        [Display(Name = "Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email không được bỏ trống.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Bạn cần phải nhập mật khẩu"), Display(Name = "Mật khẩu")]
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập lại mật khẩu."), Display(Name = "Nhập lại mật khẩu")]
        [Column(TypeName = "varchar(50)"), StringLength(50)]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "Mật khẩu bạn nhập lại không đúng.")]
        public string ConfirmPassWord { get; set; }

        [StringLength(250)]
        [Column(TypeName = "nvarchar(250)")]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
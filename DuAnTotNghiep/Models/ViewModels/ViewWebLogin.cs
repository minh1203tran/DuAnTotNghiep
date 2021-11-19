using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    public class ViewWebLogin
    {
        [Required(ErrorMessage = "Vui lòng nhập email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu!")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        public string ReturnUrl { get; set; }
    }
}

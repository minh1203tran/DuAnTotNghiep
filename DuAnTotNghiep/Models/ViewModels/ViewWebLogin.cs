using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    public class ViewWebLogin
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string PassWord { get; set; }

        public string ReturnUrl { get; set; }
    }
}

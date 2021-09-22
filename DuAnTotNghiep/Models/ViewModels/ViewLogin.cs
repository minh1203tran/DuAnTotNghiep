using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    public class ViewLogin
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string PassWord { get; set; }

        public string ReturnUrl { get; set; }
    }
}

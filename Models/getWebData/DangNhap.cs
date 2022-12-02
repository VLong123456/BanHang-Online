using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banhang_online.Models.getWebData
{
    public class DangNhap
    {
        [Key]
        public string NameLogin { get; set; }
        [Required]
        public string PassLogin { get; set; }
        [Required]
        public string IdLogin { get; set; }

        
    }
}
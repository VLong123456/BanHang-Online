using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace asp_web.Models.getWebData
{
    public class AnhSanPham
    {
        [Key]
        public string IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string AnhSanPhams { get; set; }
    }
}
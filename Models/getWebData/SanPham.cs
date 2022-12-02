using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace banhang_online.Models.getWebData
{
    public class SanPham
    {
        [Key]
        public string IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string ThongTinSanPham { get; set; }
        public string GiaSanPham { get; set; }
        public string AnhSanPham { get; set; }
    }
}
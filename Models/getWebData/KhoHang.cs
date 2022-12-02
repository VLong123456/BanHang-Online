using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace asp_web.Models.getWebData
{
    public class KhoHang
    {
        [Key]
        public string IdSanPham { get; set;}
        public string TenSanPham { get; set;}
        public string ThongTinSanPham { get; set;}
        public string LoaiSanPham { get; set;}
        public string GiaSanPham { get; set;}
        public string SoLuongTon { get; set;}
        public string DiaChiKho { get; set;}
    }
}
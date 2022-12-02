using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace banhang_online.Models.getWebData
{
    public class DonHang
    {
        [Key]
        public string IdHoaDon { get; set; }
        public string IdKhachHang { get; set; }
        public string IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string ThongTinSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public string GiaSanPham { get; set; }
        public string SoLuongTon { get; set; }
    }
}
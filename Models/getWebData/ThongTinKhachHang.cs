using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp_web.Models.getWebData
{
    public class  ThongTinKhachHang
    {
    [Key]
        public string SoDienThoai {set; get;}
    [Required]
        public string TenKhachHang {set; get;}
        [Required]
        public string GioiTinh {set; get;}
    [Required]
        public string NgaySinh {set; get;}
    [Required]
        public string IdKhachHang {set; get;}
    [Required]
        public string DiaChi {set; get;}
    [Required]
        public string Email {set; get;}
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using banhang_online.Models.getWebData;
using banhang_online.Models.setDbContext;

namespace banhang_online.Controllers.Users
{
    [Route("[controller]")]
    public class SanPhamController : Controller
    {
        private readonly ILogger<SanPhamController> _logger;  // never used

        private readonly cls_DBContext _db;
        
        
        public SanPhamController(cls_DBContext settingConn)
        {
            _db = settingConn;
        }

            [HttpGet("SanPham")]
        public IActionResult SanPham()
        {          
            var img_1 = from img in _db.AnhSanPham
                        where img.IdSanPham == "1"
                        select img;
            return View( img_1 );

        }

            [HttpGet("DiDong")]
        public IActionResult SanPhamDiDong()
        {
            return View();
        }

            [HttpGet("MayTinh")]
        public IActionResult SanPhamMayTinh()
        {
            return View();
        }
        
            [HttpGet("PhamMem")]
        public IActionResult SanPhamPhanMem()
        {
            return View();
        }

    
    }
}
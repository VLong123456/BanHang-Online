using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace banhang_online.Controllers.Users
{
    [Route("[controller]")]
    public class NguoiDungController : Controller
    {
        private readonly ILogger<NguoiDungController> _logger;

        public NguoiDungController(ILogger<NguoiDungController> logger)
        {
            _logger = logger;
        }


            [HttpGet("DangNhap")]
        public IActionResult DangNhap()
        {
            return View();
        }


            [HttpGet("DangKy")]
        public IActionResult DangKy()
        {
            return View();
        }


            [HttpGet("GioHang")]
        public IActionResult GioHang()
        {
            return View();
        }

        
    }
}
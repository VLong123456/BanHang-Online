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
    public class DangNhapController : Controller
    {
        private readonly ILogger<DangNhapController> _logger;

        public DangNhapController(ILogger<DangNhapController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{id}")]
        public IActionResult DangNhap()
        {
            return View();
        }
        [HttpGet("DangKy")]
        public IActionResult DangKy()
        {
            return View();
        }

        
    }
}
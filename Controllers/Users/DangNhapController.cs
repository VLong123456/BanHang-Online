using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using banhang_online.Models.seDataViews;

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

        [HttpGet("id_1")]
        public IActionResult DangNhap()
        {
            return View();
        } 
        
        [HttpGet("id_2")]
        public IActionResult DangKy()
        {
            return View();
        }

        
    }
}
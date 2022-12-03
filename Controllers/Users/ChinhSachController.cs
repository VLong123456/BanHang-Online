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
    public class ChinhSachController : Controller
    {
        private readonly ILogger<ChinhSachController> _logger;

        public ChinhSachController(ILogger<ChinhSachController> logger)
        {
            _logger = logger;
        }


            [HttpGet("ChinhSach")]
        public IActionResult ChinhSach()
        {
            return View();
        }

            [HttpGet("BaoHanh")]
        public IActionResult ChinhSachBaoHanh()
        {
            return View();
        }

            [HttpGet("ThanhToan")]
        public IActionResult ChinhSachThanhToan()
        {
            return View();
        }

            [HttpGet("BaoMat")]
        public IActionResult ChinhSachBaoMat()
        {
            return View();
        }

    }
}
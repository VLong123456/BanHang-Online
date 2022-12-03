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
    public class GioiThieuController : Controller
    {
        private readonly ILogger<GioiThieuController> _logger;

        public GioiThieuController(ILogger<GioiThieuController> logger)
        {
            _logger = logger;
        }

        public IActionResult GioiThieu()
        {
            return View();
        }

    }
}
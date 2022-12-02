using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace banhang_online.Views.DangNhap
{
    public class DangKyModels : PageModel
    {
        private readonly ILogger<DangKyModels> _logger;

        public DangKyModels(ILogger<DangKyModels> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
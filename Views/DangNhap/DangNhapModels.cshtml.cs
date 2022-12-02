using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using banhang_online.Models.getWebData;

namespace banhang_online.Views.DangNhap
{
    public class DangNhapModels : PageModel
    {
        private readonly ILogger<DangNhapModels> _logger;

        public DangNhapModels(ILogger<DangNhapModels> logger)
        {
            _logger = logger;
        }

        

        public void OnGet()
        {
        }
    }
}
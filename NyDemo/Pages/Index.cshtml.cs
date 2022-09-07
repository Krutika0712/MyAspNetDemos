﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NyDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

       public string AuthorName { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            AuthorName = "Krutika";
        }

        public void OnGet()
        {

        }
    }
}

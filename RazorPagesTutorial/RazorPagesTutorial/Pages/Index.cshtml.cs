using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {  
            _logger = logger;
        }

        public void OnGet()
        {
            //Method that handles HTTP request for this page.
            Message = "Hello, ASP.NET Razor world! The time now is " + DateTime.Now.ToLongTimeString();
        }
    }
}

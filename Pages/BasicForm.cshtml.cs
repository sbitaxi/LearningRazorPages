
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LearningRazorPages.Pages
{
    public class BasicFormModel : PageModel
    {
        private readonly ILogger<BasicFormModel> _logger;

        public BasicFormModel(ILogger<BasicFormModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public JsonResult OnPost()
        {
            foreach(var key in Request.Form.Keys)
            {
                System.Console.WriteLine($"Key:{key} Value: {Request.Form.FirstOrDefault(item => item.Key == key).Value}");
            }
            return new JsonResult(Request.Form); 
        }
    }
}

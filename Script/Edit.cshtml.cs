using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoBookstore.Pages
{
    public class EditModel : PageModel
    {   public Book.info.Books Books { get; set; }
        private readonly IData data { get; set; }
         public EditModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using Microsoft.AspNetCore.Http;

namespace WebForm.Pages.Shared
{
    public class GiayChungNhanModel : PageModel
    {
        [BindProperty]
        public KetQuaThiDTO ketquathi { set; get; }
        
        public void OnGet()
        {

        }

        public IActionResult OnPostDetail()
        {
            HttpContext.Session.SetString("ngaythi", ketquathi.NgayThi);
            HttpContext.Session.SetString("sbd", ketquathi.SoBaoDanh);
            return RedirectToPage("/Shared/XemGiayChungNhan");
        }
        
    }
}

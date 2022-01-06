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
    public class KetQuaDiemThiModel : PageModel
    {
        [BindProperty]
        public KetQuaThiDTO ketquathi { set; get; }
        [BindProperty]
        public List<KhoaThiDTO> listKhoaThi { set; get; }
        [BindProperty]
        public string searchHoTen { set; get; }

        [BindProperty]
        public string searchvalue { set; get; }

        public IActionResult OnPostSearch()
        {
            HttpContext.Session.SetString("searchgiaychungnhan", searchvalue);
            return Page();
        }

        public IActionResult OnPostGiaychungnhan()
        {
            HttpContext.Session.SetString("sbd", ketquathi.SoBaoDanh);
            HttpContext.Session.SetString("ngaythi", ketquathi.NgayThi);
            return RedirectToPage("/Shared/XemGiayChungNhan");
        
        }

    }
}

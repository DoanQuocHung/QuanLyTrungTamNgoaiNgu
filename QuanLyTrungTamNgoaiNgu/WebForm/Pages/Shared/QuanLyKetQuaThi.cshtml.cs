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
    public class QuanLyKetQuaThiModel : PageModel
    {
        [BindProperty]
        public KetQuaThiDTO ketquathi { set; get; }
        [BindProperty]
        public List<KhoaThiDTO> listKhoaThi { set; get; }
        [BindProperty]
        public string searchHoTen { set; get; }

        [BindProperty]
        public string searchSDT { set; get; }
        [BindProperty]
        public string searchSBD { set; get; }

        public IActionResult OnPostSearch()
        {
            HttpContext.Session.SetString("searchHoTen", searchHoTen);
            HttpContext.Session.SetString("searchSDT", searchSDT);
            return Page();
        }

        public IActionResult OnPostGiaychungnhan()
        {
            HttpContext.Session.SetString("searchSBDgiaychungnhan", searchSBD);
            return RedirectToPage("/Shared/XemGiayChungNhan");
        }

    }
}

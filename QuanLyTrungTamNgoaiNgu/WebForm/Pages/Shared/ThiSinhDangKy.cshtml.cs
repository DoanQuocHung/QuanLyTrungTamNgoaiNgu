using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUS;
using DTO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace WebForm.Pages.Shared
{
    public class ThiSinhDangKyModel : PageModel
    {
        [BindProperty]
        public DangKyDTO dangky2 { set; get; }
        [BindProperty]
        public ThiSinhDTO dangky { set; get; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (new ThiSinhBUS().Insert(new ThiSinhDTO(dangky.Cccd_TS, dangky.HoTen_TS, dangky.GioiTinh_TS, dangky.NgaySinh_TS,
                dangky.NoiSinh_TS, dangky.NgayCap_TS, dangky.NoiCap_TS, dangky.Sdt_TS, dangky.Email_TS)))
            {
                HttpContext.Session.SetString("themdangky", "true");
                return Redirect("/Shared/ThiSinhDangKy");
            }
            HttpContext.Session.SetString("themdangky", "false");
            return Redirect("/Shared/ThiSinhDangKy");

            //dangky2.Cccd_TS = dangky.Cccd_TS;
            //dangky2.LePhiThi = "500,000 VND";
            //return Page();
        }
    }
}

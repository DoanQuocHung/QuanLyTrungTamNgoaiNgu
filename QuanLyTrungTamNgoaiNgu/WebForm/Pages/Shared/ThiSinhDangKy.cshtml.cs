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
            dangky2.Cccd_TS = dangky.Cccd_TS;
            dangky2.LePhiThi = "500,000 VND";
            if (new ThiSinhBUS().Exists(dangky.Cccd_TS))
            {
                if (new DangKyBUS().Insert(dangky2))
                {
                    HttpContext.Session.SetString("themdangky", "true");
                    return Redirect("/Shared/ThiSinhDangKy");
                }
                else
                {
                    HttpContext.Session.SetString("themdangky", "false");
                    return Redirect("/Shared/ThiSinhDangKy");
                }
            }
            else if (new ThiSinhBUS().Insert(dangky))
            {
                if (new DangKyBUS().Insert(dangky2))
                {
                    HttpContext.Session.SetString("themdangky", "true");
                    return Redirect("/Shared/ThiSinhDangKy");
                }
                else
                {
                    HttpContext.Session.SetString("themdangky", "false");
                    return Redirect("/Shared/ThiSinhDangKy");
                }
            }
            else
            {
                HttpContext.Session.SetString("themdangky", "false");
                return Redirect("/Shared/ThiSinhDangKy");
            }
        }
    }
}

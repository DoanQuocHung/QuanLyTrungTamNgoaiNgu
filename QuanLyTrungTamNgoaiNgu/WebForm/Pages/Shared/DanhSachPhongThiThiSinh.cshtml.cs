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
    public class DanhSachPhongThiThiSinhModel : PageModel
    {
        [BindProperty]
        public List<KhoaThiDTO> listkhoa { get; set; }
        [BindProperty]
        public List<PhongThiDTO> listphong { get; set; }
        [BindProperty]
        public string khoa { get; set; }
        [BindProperty]
        public string phong { get; set; }
        public void OnGet()
        {
            listkhoa = new KhoaThiBUS().List();
            if (HttpContext.Session.GetString("layphongthi") == "true")
            {
                khoa = HttpContext.Session.GetString("khoaphongthi");
            }
        }
        public IActionResult OnPostGetting()
        {
                HttpContext.Session.SetString("layphongthi", "true");
            HttpContext.Session.SetString("khoaphongthi", khoa);
            return Redirect("/Shared/DanhSachPhongThiThiSinh");
        }
        public IActionResult OnPostList()
        {
            HttpContext.Session.SetString("laydanhsach", "true");
            HttpContext.Session.SetString("khoaphongthi", khoa);
            HttpContext.Session.SetString("maphongthi", phong);
            return Redirect("/Shared/DanhSachPhongThiThiSinh");
        }
    }
}

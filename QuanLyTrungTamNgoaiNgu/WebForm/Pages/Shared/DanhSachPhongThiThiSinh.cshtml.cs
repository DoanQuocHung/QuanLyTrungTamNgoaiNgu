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
        [BindProperty]
        public string nghe { get; set; }
        [BindProperty]
        public string noi { get; set; }
        [BindProperty]
        public string doc { get; set; }
        [BindProperty]
        public string  viet { get; set; }
        [BindProperty]
        public string ten { get; set; }
        [BindProperty]
        public string chungchi { get; set; }
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
        public IActionResult OnPostChungchi()
        {
            HttpContext.Session.SetString("xemchungchi", "true");
            HttpContext.Session.SetString("nghe", nghe);
            HttpContext.Session.SetString("noi", noi);
            HttpContext.Session.SetString("doc", doc);
            HttpContext.Session.SetString("viet", viet);
            HttpContext.Session.SetString("ten", ten);
            HttpContext.Session.SetString("chungchi", chungchi);
            return Redirect("/Shared/XemGiayChungNhan");
        }
    }
}

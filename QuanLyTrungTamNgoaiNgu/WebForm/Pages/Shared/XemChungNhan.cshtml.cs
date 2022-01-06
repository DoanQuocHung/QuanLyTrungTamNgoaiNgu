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
    public class XemChungNhanModel : PageModel
    {
        [BindProperty]
        public string sobaodanh { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            BaiThiDTO list = new BaiThiBUS().ListBaiThi().Find(x=>x.SoBaoDanh == sobaodanh);
            ThiSinhDTO ts = new ThiSinhBUS().List().Find(x => x.Cccd_TS == list.Cccd_TS);
            PhongThiDTO phong = new PhongThiBUS().ListAll().Find(x=>x.Id_PhongThi == list.Id_PhongThi);
            HttpContext.Session.SetString("xemchungchi", "true");
            HttpContext.Session.SetString("nghe", list.DiemNghe);
            HttpContext.Session.SetString("noi", list.DiemNghe);
            HttpContext.Session.SetString("doc", list.DiemNghe);
            HttpContext.Session.SetString("viet", list.DiemNghe);
            HttpContext.Session.SetString("ten", ts.HoTen_TS);
            HttpContext.Session.SetString("chungchi", phong.TrinhDo);
            return Redirect("/Shared/XemGiayChungNhan");
        }
    }
}
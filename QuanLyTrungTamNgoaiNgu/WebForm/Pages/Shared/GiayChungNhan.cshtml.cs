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
        [BindProperty]
        public List<ThiSinhDTO> listKhoaThi { set; get; }
        public void OnGet()
        {

        }

        
    }
}

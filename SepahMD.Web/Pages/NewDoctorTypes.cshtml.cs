using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SepahMD.Core.Services;
using SepahMD.Core.ViewModels;

namespace SepahMD.Web.Pages
{
    public class NewDoctorTypeModel : PageModel
    {
        public void OnGet()
        {
        }
        private IDoctorType doctorType;
        public NewDoctorTypeModel(IDoctorType _doctortype)
        {
            doctorType = _doctortype;
        }
        [BindProperty]
        public DoctorTypeViewModel newdoctortype { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            doctorType.NewDoctorType(newdoctortype);
            return Page();
        }
    }
}

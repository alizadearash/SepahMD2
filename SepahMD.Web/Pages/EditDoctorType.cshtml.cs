using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SepahMD.Core.Services;
using SepahMD.Core.ViewModels;

namespace SepahMD.Web.Pages
{
    public class EditDoctorTypeModel : PageModel
    {
        private IDoctorType idoctorType;
        public EditDoctorTypeModel(IDoctorType _doctortype)
        {
            idoctorType = _doctortype;
        }
        [BindProperty]
        public EditDoctorTypeViewModel editDoctorType { get; set; }
        public void OnGet(int id)
        {
            ViewData["id"]=id;
            editDoctorType = idoctorType.EditDoctorTypeWithID(id);
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            idoctorType.UpdateDoctorTypeByID(id,editDoctorType);
            return Redirect("/Index");
        }
    }
}

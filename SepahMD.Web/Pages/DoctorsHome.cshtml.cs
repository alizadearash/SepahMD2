using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SepahMD.Core.Services;
using SepahMD.DataLayer.Context;
using SepahMD.DataLayer.Entities;

namespace SepahMD.Web.Pages
{
    public class DoctorsHomeModel : PageModel
    {
        IDoctorType doctorType;
        Refahi_db database;
        public DoctorsHomeModel(IDoctorType _doctorType, Refahi_db _db)
        {
            doctorType = _doctorType;   
            database = _db;
        }
        [BindProperty]
        public IEnumerable<DoctorType> showAllDoctorTypes { get; set; }
        public void OnGet()
        {
            showAllDoctorTypes = database.tblDoctorType;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SepahMD.Core.Services;
using SepahMD.DataLayer.Context;
using SepahMD.DataLayer.Entities;

namespace SepahMD.Web.Pages
{
    public class DoctorTypesListModel : PageModel
    {
        IDoctorType doctorType;
        Refahi_db database;
        public DoctorTypesListModel(IDoctorType _doctorType,Refahi_db _db)
        {
            database = _db;
            doctorType = _doctorType;
        }
        [BindProperty]
        public IEnumerable<DoctorType> showAllDoctorTypes { get; set; }
        public void OnGet()
        {
            showAllDoctorTypes = database.tblDoctorType;
        }
    }
}

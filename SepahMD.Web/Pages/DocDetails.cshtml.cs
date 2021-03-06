using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SepahMD.Core.Services;
using SepahMD.DataLayer.Context;
using SepahMD.DataLayer.Entities;

namespace SepahMD.Web.Pages
{
    public class DocDetailsModel : PageModel
    {
        IDoctor idoctor;
        Refahi_db database;
        public DocDetailsModel(IDoctor _idoctor,Refahi_db _db)
        {
            idoctor = _idoctor;
            database = _db;

        }
        [BindProperty]
        public IEnumerable<Doctors> ShowSelectedDoctors { get; set; }
        public void OnGet()
        {
            ShowSelectedDoctors = database.tblDoctors;
        }
       
       

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SepahMD.Core.Services;
using SepahMD.Core.ViewModels;

namespace SepahMD.Web.Pages
{
    public class NewCityModel : PageModel
    {
        public ICity city;
        public NewCityModel(ICity _city)
        {
                city = _city;
        }
        [BindProperty]
        public CityViewModel newcity { get; set; }  
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Error In Sending Data!!!!");
            }
            city.AddNewCity(newcity);
            return Page();
        }
        public void OnGet()
        {
        }
    }
}

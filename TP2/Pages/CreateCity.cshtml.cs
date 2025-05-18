using aula05._05.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public CreateCity CreateCity
        {
            get; set;
        }

        public void OnGet()
        {
            CreateCity = new CreateCity();
        }
        public void OnPost()
        {

            if (!string.IsNullOrEmpty(CreateCity.CityName))
            {
                Console.WriteLine(CreateCity.CityName);
            }
        }
    }
}

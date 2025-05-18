using aula05._05.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class CreateCityModel : PageModel
    {

        public String CityName { get; set; }
        public void OnPost(String cityName)
        {

            if (!string.IsNullOrEmpty(cityName))
            {
                CityName = cityName;
            }
        }
    }
}

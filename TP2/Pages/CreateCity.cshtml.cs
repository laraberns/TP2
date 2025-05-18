using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public string CityName { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O nome da cidade � obrigat�rio.")]
            [MinLength(3, ErrorMessage = "O nome da cidade deve ter no m�nimo 3 caracteres.")]
            public string CityName { get; set; }
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            CityName = Input.CityName;
        }
    }
}

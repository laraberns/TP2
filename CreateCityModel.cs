 
using System.ComponentModel.DataAnnotations;  
using aula05._05.Models;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  

namespace TP2.Pages  
{  
    public class CreateCityModel : PageModel  
    {  
        public class InputModel  
        {  
            [Required]  
            [MinLength(3)]  
            public string CityName { get; set; }  
        }  

        [BindProperty]  
        public InputModel Input { get; set; }  

        public IActionResult OnPost()  
        {  
            if (!ModelState.IsValid)  
            {  
                return Page();  
            }  

            // Process the valid city name here (e.g., save to database)  
            var cityName = Input.CityName;  

            return RedirectToPage("Success");  
        }  
    }  
}  

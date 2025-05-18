using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2.Models;

namespace TP2.Pages
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public CreateCountry Country { get; set; }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Country = new CreateCountry
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode
            };
        }
    }
}

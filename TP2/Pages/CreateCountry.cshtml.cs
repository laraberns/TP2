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
        public List<InputModel> Countries { get; set; } = new();

        public List<CreateCountry> SubmittedCountries { get; set; } = new();

        public class InputModel
        {
            public string CountryName { get; set; }

            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código deve ter exatamente 2 letras.")]
            public string CountryCode { get; set; }
        }

        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                Countries.Add(new InputModel());
            }
        }

        public void OnPost()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                var country = Countries[i];

                if (!string.IsNullOrWhiteSpace(country.CountryName) &&
                    !string.IsNullOrWhiteSpace(country.CountryCode))
                {
                    if (char.ToUpperInvariant(country.CountryName[0]) != char.ToUpperInvariant(country.CountryCode[0]))
                    {
                        ModelState.AddModelError($"Countries[{i}].CountryCode",
                            "O código deve começar com a mesma letra do nome do país.");
                    }
                }
            }

            if (!ModelState.IsValid)
            {
                return;
            }

            SubmittedCountries = Countries
                .Where(c => !string.IsNullOrWhiteSpace(c.CountryName) && !string.IsNullOrWhiteSpace(c.CountryCode))
                .Select(c => new CreateCountry
                {
                    CountryName = c.CountryName,
                    CountryCode = c.CountryCode
                }).ToList();
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class CityListModel : PageModel
    {
        public List<string> Cities { get; set; } = new()
        {
            "Rio", "São Paulo", "Brasília"
        };
    }
}

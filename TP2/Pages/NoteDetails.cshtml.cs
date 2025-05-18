using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class NoteDetailsModel : PageModel
    {
        public string Details { get; set; }

        public void OnGet(string filePath)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", filePath);

            if (System.IO.File.Exists(fullPath))
            {
                Details = System.IO.File.ReadAllText(fullPath);
            }
            else
            {
                Details = "File not found.";
            }
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class ListNotesModel : PageModel
    {
        public List<string> ListAllNotes { get; set; } = new List<string>();

        public void OnGet()
        {
            var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            if (Directory.Exists(directoryPath))
            {
                foreach (var file in Directory.GetFiles(directoryPath))
                {
                    ListAllNotes.Add(Path.GetFileName(file));
                }
            }
        }
    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public string FileName { get; set; }

        public class InputModel
        {
            public string Content { get; set; }
        }
        public void OnPost()
        {
            var timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            FileName = $"note-{timestamp}.txt";
            var filePath = Path.Combine("wwwroot", "files", FileName);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(Input.Content);
            }
        }


    }
}

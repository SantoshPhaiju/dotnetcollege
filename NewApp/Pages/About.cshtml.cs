using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Name { get; set; } = "Alisha";
        public void OnGet()
        {
            int name = 10;
            System.Console.WriteLine(name);
        }
    }
}

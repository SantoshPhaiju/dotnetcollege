using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewApp.Pages
{
    public class DashboardModel : PageModel
    {
        //name, email, address

        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? Address { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Email: {Email}");
            System.Console.WriteLine($"Address: {Address}");
            // var data = new
            // {
            //     Name = Name,
            //     Email = Email,
            //     Address = Address
            // };

            // return new JsonResult(data);
        }
    }
}

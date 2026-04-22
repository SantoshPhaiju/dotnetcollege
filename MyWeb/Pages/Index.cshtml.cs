using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Pages;

public class IndexModel : PageModel
{
    public bool IsSubmitted { get; set; }
    [BindProperty]
    [Required]
    public string? Name { get; set; }
    [BindProperty]
    [Required]
    public string? Email { get; set; }

    [BindProperty]
    [Required]
    public string? Address { get; set; }
    public void OnPost()

    {
        if (ModelState.IsValid)
        {
            IsSubmitted = true;
            // Process the form data (e.g., save to database)
            // For demonstration, we can just display the submitted data
            ViewData["Message"] = $"Name: {Name}, Email: {Email}, Address: {Address}";
            System.Console.WriteLine($"Name: {Name}, Email: {Email}, Address: {Address}");
        }
        else
        {
            IsSubmitted = false;
            ViewData["Message"] = "Please fill in all required fields.";
        }
    }
}

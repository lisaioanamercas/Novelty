using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Novelty.Pages.Auth
{
    public class RegisterModel : PageModel
    {

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public string? SuccessMessage { get; set; }

        public class InputModel
        {
            public string FullName { get; set; } = string.Empty;
            [EmailAddress]
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Mock registration - in a full app, you'd create a user, validate, etc.
            SuccessMessage = "Mocked registration successful. You can now sign in using user@library.com / password or your registered email (mock).";
            return Page();
        }
    }
}
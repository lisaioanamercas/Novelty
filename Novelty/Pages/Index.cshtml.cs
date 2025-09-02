using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Novelty.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Authorization;
    using System.Security.Claims;

    [Authorize]
    public class IndexModel : PageModel
    {
        public string Email { get; set; } = "Unknown";
        public string DisplayName { get; set; } = "User";

        public void OnGet()
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                Email = User.FindFirst(ClaimTypes.Email)?.Value ?? User.Identity.Name ?? "Unknown";
                DisplayName = User.FindFirst("DisplayName")?.Value ?? Email;
            }
        }
    }
}

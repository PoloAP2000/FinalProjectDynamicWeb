using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace FinalProject_v2_.Models
{
    public class Login : PageModel
    {
        private readonly UserDBContext _dbContext;

        public Login(UserDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public new User User { get; set; }

        public void OnGet()
        {
            // Optional: Initialize any data needed for the page
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Users.Add(User);
            await _dbContext.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}

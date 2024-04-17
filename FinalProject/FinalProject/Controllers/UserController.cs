using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class UserController : Controller
    {
        private UserDBContext _dbContext;

        public UserController(UserDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult AddUser(User u)
        {
            _dbContext.Users.Add(u);
            return View();
        }
    }
}

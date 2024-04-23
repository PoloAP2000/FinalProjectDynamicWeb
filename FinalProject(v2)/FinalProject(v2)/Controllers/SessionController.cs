using FinalProject_v2_.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class SessionController : Controller
    {
        private UserDBContext _dbContext;

        public SessionController(UserDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateSession()
        {
            return View();
        }

        public IActionResult Create(Session s)
        {
            _dbContext.Sessions.Add(s);
            return View();
        }
    }
}

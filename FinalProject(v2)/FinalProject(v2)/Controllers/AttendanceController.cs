using FinalProject_v2_.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_v2_.Controllers
{
    public class AttendanceController : Controller
    {
        private UserDBContext _dbContext;

        public AttendanceController(UserDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult RegisterAttendance(Attendee a)
        {
            _dbContext.Attendees.Add(a);
            return View();
        }
    }
}

using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel{ Name = "student", 
            DateOfBirth = new DateTime(1997,04,26)};
            return View(data);
        }
    }
}

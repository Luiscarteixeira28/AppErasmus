using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppErasmus.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

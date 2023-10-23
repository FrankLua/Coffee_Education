using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controller
{
    public class AdminController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

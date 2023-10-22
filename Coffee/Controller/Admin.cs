

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Coffee.Controller

{
    [Authorize(Roles = "Administrator")]
    public class Admin : Microsoft.AspNetCore.Mvc.Controller
    {
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return View();
        }
        public Microsoft.AspNetCore.Mvc.IActionResult Users()
        {
            return View();
        }
    }
}

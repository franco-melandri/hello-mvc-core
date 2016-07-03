using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp
{
    public class HomeController : Controller
    {
        [HttpGet("/Home/Index")]
        public IActionResult Index() => View();
    }
}
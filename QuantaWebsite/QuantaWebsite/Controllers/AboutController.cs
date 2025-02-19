using Microsoft.AspNetCore.Mvc;

namespace QuantaWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

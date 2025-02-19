using Microsoft.AspNetCore.Mvc;

namespace QuantaWebsite.Controllers
{
    public class ApplicationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

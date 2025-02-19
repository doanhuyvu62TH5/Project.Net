using Microsoft.AspNetCore.Mvc;

namespace QuantaWebsite.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

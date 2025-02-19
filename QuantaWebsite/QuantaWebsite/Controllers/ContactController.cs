using Microsoft.AspNetCore.Mvc;

namespace QuantaWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

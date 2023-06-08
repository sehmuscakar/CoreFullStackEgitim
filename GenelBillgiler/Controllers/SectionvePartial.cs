using Microsoft.AspNetCore.Mvc;

namespace GenelBillgiler.Controllers
{
    public class SectionvePartial : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult partial()
        {
            return View();
        }


    }
}

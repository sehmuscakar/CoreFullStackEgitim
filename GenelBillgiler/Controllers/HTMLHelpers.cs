using Microsoft.AspNetCore.Mvc;

namespace GenelBillgiler.Controllers
{
    public class HTMLHelpers : Controller
    {
        public IActionResult HTMLHelperskonusu()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace GenelBillgiler.Controllers
{
    public class VeriFormatlama : Controller
    {
        public IActionResult Veriformatlamakonusu()
        {
            return View();
        }
    }
}

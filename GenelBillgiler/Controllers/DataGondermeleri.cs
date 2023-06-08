using Microsoft.AspNetCore.Mvc;

namespace GenelBillgiler.Controllers
{
    public class DataGondermeleri : Controller
    {
        public IActionResult Controllertoview()
        {//controller dan view a veri gönderimi

            ViewBag.kategoriad = "Yazılım";
            ViewData["UrunAdi"] = "Yenova Tablet 2023";
            TempData["urunfiyati"] = 8562;
            return View();
        }

        public IActionResult Viewtocontroller()
        {//view dan controller a veri gönderimi

            ViewBag.kategoriad = "Yazılım";
            ViewData["UrunAdi"] = "Yenova Tablet 2023";
            TempData["urunfiyati"] = 8562;
            return View();
        }
    }
}

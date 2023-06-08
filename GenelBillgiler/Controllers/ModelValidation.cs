using GenelBillgiler.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenelBillgiler.Controllers
{
    public class ModelValidation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid)//validasyonlarımızı kontrol edeğei blog
            {
                ViewBag.Uyebilgi = $"Üye Adı :{uye.Ad} <hr> soyadı : {uye.Soyad} <hr> Email: {uye.Email}";
            }

            return View();
        }
    }
}

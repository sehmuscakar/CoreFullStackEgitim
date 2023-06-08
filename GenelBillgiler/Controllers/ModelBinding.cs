using Microsoft.AspNetCore.Mvc;
using GenelBillgiler.Models;
namespace GenelBillgiler.Controllers
{
    public class ModelBinding : Controller
    {
        public IActionResult Index()
        {

            var sayfamodeli = new AnasayfaViewModel
            {
                AdresNesnesi= new Adres
                {
                Sehir="Batman",
                İlce="Merkez",
                AcıkAdres="gültepe mah."
                },

                KullaniciNesnesi=new Kullanici
                {
                    Ad="şehmus",
                    Soyad="çakar",
                    Email="deneme@gmail.com"
                }

            };

            return View(sayfamodeli);
        }
        //basında httpget yoksa da o get işlemi yapar
        public IActionResult kullanici()
        {
            Kullanici kullanici = new Kullanici()//models deki kullanici classı
            {
                Ad="Şehmus",Soyad="kara",Email="deneme@gmail.com"
            };
            return View(kullanici);
        }
        [HttpPost]//burda verileri pst lama işlemi yapıyoruz
        public IActionResult kullanici(Kullanici kullanici)//modeli burda kullandık
        {
            ViewBag.Mesaj = "Kullanıcı adı,şifre" + kullanici.KullaniciAdi+" "+kullanici.Sifre;
            ViewData["Vdata"] = "Kullanıcı adı soyad" + kullanici.Ad + " " + kullanici.Soyad;
            TempData["Tdata"] = "Email" + kullanici.Email;
            return View();
        }

      
        public IActionResult Adres()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Adres(Adres adres)
        {
            ViewBag.Mesaj = "Şehir" + adres.Sehir;
            ViewData["Vdata"] = "İlçe" + adres.İlce;
            TempData["Tdata"] = "Açık adres" + adres.AcıkAdres;
            return View();
        }
    }
}

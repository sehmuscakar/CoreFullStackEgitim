using GenelBillgiler.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenelBillgiler.Controllers
{
    public class ViewResult : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public RedirectResult Index2()
        {
            return Redirect("/Home/Index");// buraya yönlendirir.home controller,Index action istediğimiz yere gider 
        }

        public RedirectToRouteResult Index3()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 5 });// name ismi Default ,controller Home,id=5 ;program.ccs deki route yollarını veriyoruz.
        }

        public PartialViewResult KategrileriPartiallaGetir()
        {
            return PartialView("_KateegoriPartial");
        }

        public PartialViewResult KategrileriModelPartiallaGetir()
        {
            List<string> kategoriler = new List<string>()
            {
                    "Bilgisiyar",
                    "Monitorler",
                    "Klavyeler",
                    "Mousler",
                    "Laptoplar",
                    "Aksesuarlar",

            };

            return PartialView("_KateegoriPartial2",kategoriler);
        }

        //public FileResult PdfDosyaIndir()
        //{
        //    string dosyayolu = Server.MapPath();


        //    return new FilePathResult();
        //}



        //public FileStreamResult PdfDosyaIndir()
        //{
        //    string dosyayolu = Server.MapPath();


        //    return new FilePathResult();
        //}


        //public JavaScriptResult JsResult()
        //{
        //    string js = "alert('JsResult çalıştı')";

        //    return 
        //}


        public JsonResult Index4()
        {
            Kullanici kullanici = new Kullanici()
            {
                Id = 9,
                Ad = "Şehmus",
                Soyad = "Çakar",
                KullaniciAdi="admin",
                Sifre= "7272",

            };
            return Json(kullanici);
        }

      

        public ContentResult XmlContentResult()
        {
            var xml = @" 
            <Kullanicilar>
            <Kullanici>
                  <Id>9</Id>
                  <Ad>Şehmus</Ad>
                  <Soyad>Çakar</Soyad>
                  <Email>null</Email>
               
            </Kullanici>
             <Kullanici>
                  <Id>10</Id>
                  <Ad>Yavuz</Ad>
                  <Soyad>Kara</Soyad>
                  <Email>null</Email>
               
            </Kullanici>
            </Kullanicilar>";

            return Content(xml);
        }

    }
}

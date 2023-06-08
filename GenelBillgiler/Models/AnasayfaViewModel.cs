namespace GenelBillgiler.Models
{
    public class AnasayfaViewModel// bo model i kullanan view e birden falza model tanımlanacak 
    {
        public Kullanici KullaniciNesnesi { get; set; } // ilgili class lareı buraya tanımladık,bir sayfada birden fazla model kullanımı 

        public Adres AdresNesnesi { get; set; }
    }
}

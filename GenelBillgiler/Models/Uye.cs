using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GenelBillgiler.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required]
        //zorunlu, ad girilmesi lazım
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        [EmailAddress()]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required, DisplayName("TC Kimlik Numarası")]
        [MinLength(11,ErrorMessage ="TC Kimlik Numarası minimum 11 karekter olmalıdır")]
        [MaxLength(11,ErrorMessage ="TC Kimlik Numarası max 11 karekter olmalıdır")]
        public string TCKimlikNo { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Required]
        [DisplayName("Şifre"),DataType(DataType.Password)]
        [StringLength(100,MinimumLength =5)]
        public string Sifre { get; set; }
        [DisplayName("Şifre Tekrar"), DataType(DataType.Password)]
        [Compare("Sifre")]
        public string SifreTekrar { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}"), DisplayName("Doğum Tarihi"),DataType(dataType:DataType.Date)]
        public DateTime DogumTarihi { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace CoreProject.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Soyadınızı Girin")] public string ImageURL { get; set; }
        [Required(ErrorMessage = "Lütfen Görsel Ekleyiniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar  Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = " Şifreler birbiriyle uyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen  Mail Girin")]
        public string Mail { get; set; }
   
    }
}

using System.ComponentModel.DataAnnotations;

namespace KaracadanWebApp.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Kullanıcı ismi gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string FullName { get; set; }

        [Display(Name = "Tel No:")]
        //[RegularExpression(@"^(0(\d{3}) (\d{3}) (\d{2}) (\d{2}))$", ErrorMessage = "Telefon numarası uygun formatta değil")]
        [Required(ErrorMessage = "Telefon Numarası gereklidir.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

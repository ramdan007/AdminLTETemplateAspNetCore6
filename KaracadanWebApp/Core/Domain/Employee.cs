﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace KaracadanWebApp.Core.Domain
{
    public class Employee : BaseEntity
    {

        [Required(ErrorMessage = "İsim Alanı Zorunludur")]
        [StringLength(100, ErrorMessage = "İsim En Fazla 100 Karakter Olabilir")]
        public string FullName { get; set; }

        [StringLength(100, ErrorMessage = "Email Alanı En Fazla 100 Karakter Olabilir")]
        [EmailAddress(ErrorMessage = "Email Formatını Doğru Giriniz")]
        [Required(ErrorMessage = "Email Alanı Zorunludur")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Zorunludur")]
        public string Password { get; set; }

        [StringLength(100, ErrorMessage = "Telefon Numarası En Fazla 100 Karakter Olabilir")]
        public string PhoneNumber { get; set; }

    }
}

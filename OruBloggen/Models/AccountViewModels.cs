using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OruBloggen.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Kod")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Kom ihåg den här webbläsaren?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Epost")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

        [Display(Name = "Kom ihåg mig?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Epost")]
        public string Email { get; set; }

        [Required]
        //[RegularExpression("/^[a-z ,.'-]+$/i",ErrorMessage = "FEL NAMN")]
        [Display(Name = "Förnamn")]
        public string Firstname { get; set; }

        [Required]
        //[RegularExpression("/^[a-z ,.'-]+$/i", ErrorMessage = "FEL NAMN")]
        [Display(Name = "Efternamn")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Födelsedatum")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        [Display(Name = "Telefonnummer")]
        public int Phonenumber { get; set; }

        [Display(Name = "Profilbild")]
        public string ImagePath { get; set; }

        [Required]
        [Display(Name = "Arbetslag")]
        public string Team { get; set; }

        [Display(Name = "Befattning")]
        public string Position { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "{0}et måste vara minst {2} tecken långt.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenord")]
        [Compare("Password", ErrorMessage = "Lösenorden stämmer inte överens. Försök igen.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Epost")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0}et måste vara minst {2} tecken långt.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenordet")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenord")]
        [Compare("Password", ErrorMessage = "Lösenorden stämmer inte överens. Försök igen.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}

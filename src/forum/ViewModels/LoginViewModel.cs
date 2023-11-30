using System.ComponentModel.DataAnnotations;

namespace NetCoreBBS.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "nom d'utilisateur")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "mot de passe")]
        public string Password { get; set; }

        [Display(Name = "mémoriser le statut de connexion")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "nom d'utilisateur")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "{0} doit être supérieur à {2} bits", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmez le mot de passe")]
        [Compare("Password", ErrorMessage = "Deux mots de passe sont incohérents")]
        public string ConfirmPassword { get; set; }
    }

}
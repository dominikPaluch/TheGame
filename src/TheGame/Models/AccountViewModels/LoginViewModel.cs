using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheGame.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} jest wymagany")]
        [EmailAddress(ErrorMessage = "Email niepoprawny.")]
        [Display(Name = "Email")]
        // [RegularExpression("d{10}",ErrorMessage = "Passssss")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} jest wymagane.")]
        [StringLength(25,
            ErrorMessage = "{0} musi mieć przynajmniej {2} i maksymalnie {1} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}

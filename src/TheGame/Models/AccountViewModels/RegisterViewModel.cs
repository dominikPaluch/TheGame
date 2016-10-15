using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheGame.Models.AccountViewModels
{
    public class RegisterViewModel
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

        //gdy hasło podane bez znaków np kropka, komunikat po angielsku
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} jest wymagane.")]
        [Display(Name = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Hasła do siebie nie pasują.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Nick")]
        [Required(ErrorMessage = "{0} jest wymagany.")]
        [StringLength(25, 
            ErrorMessage = "Podaj {0} z zakresu od {2} do {1} znaków.", MinimumLength = 3)]
        public string Nick { get; set; }

        [Display(Name = "Imie")]
        [Required(ErrorMessage = "{0} jest wymagane.")]
        [StringLength(25,
            ErrorMessage = "Podaj {0} z zakresu od {2} do {1} znaków.", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "{0} jest wymagane.")]
        [StringLength(40,
            ErrorMessage = "Podaj {0} z zakresu od {2} do {1} znaków.", MinimumLength = 3)]
        public string LastName { get; set; }

        //[Display(Name = "Data urodzenia")]
        //[Required(ErrorMessage = "{0} jest wymagana.")]
        //[DataType(DataType.Date),
        // DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DateOfBirth { get; set; }
    }
}

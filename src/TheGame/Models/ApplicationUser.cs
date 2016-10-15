using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TheGame.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "Nick")]
        [Required(ErrorMessage = "Nie podałeś Nicku!")]
        [StringLength(25,
            ErrorMessage = "Podaj {0} z zakresu od {2} do {1} znaków.", MinimumLength = 3)]
        public string Nick { get; set; }

        [Display(Name = "Imie")]
        [StringLength(25,
            ErrorMessage = "Podaj {0} z zakresu od {2} do {1} znaków.", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [StringLength(40,
            ErrorMessage = "Podaj {0} z zakresu od {2} do {1} znaków.", MinimumLength = 3)]
        public string LastName { get; set; }

        //[Display(Name = "Data urodzenia")]
        //[Required(ErrorMessage = "Nie podałeś daty urodzenia!")]
        //[DataType(DataType.Date),
        // DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DateOfBirth { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Address { get; set; }
        public DateTime AddedDate { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}

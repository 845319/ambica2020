using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace signup.Models
{
    [MetadataType(typeof(Usermetadata))]
    public partial class User
    {
     
    }
    public class Usermetadata
    {
        [Display(Name = "Firstname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Firstname required")]
        public string Firstname { get; set; }

        [Display(Name = "Lastname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Lastname required")]
        public string Lastname { get; set; }

        [Display(Name = "Email Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Id required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Date of Birth ")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:mm/dd/yyyy}")]
        public string Dob { get; set; }



        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 characters required ")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
       [Compare("Password",ErrorMessage ="password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    }

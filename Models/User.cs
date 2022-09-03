//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PathToJannah.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int U_ID { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [DisplayName("Username")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Mobile Number is Required")]

        public string Mobile { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is Required")]
        public string Pass { get; set; }


        [DataType(DataType.Password)]
        [DisplayName("Confirm_Password")]
        [Compare("Pass")]
        public string ConfirmPass { get; set; }



        public string LoginErrorMessage { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace IdentityBhrDev.ViewModel
{
    public class RegisterVM
    {
        //public RegisterVM()
        //{
        //    State = new List<Itemlist>() {
        //new Itemlist { Text = "Uttar Pradesh", Value = 1 },
        //new Itemlist { Text = "Delhi", Value = 2 },
        //new Itemlist { Text = "Bihar", Value = 3 },
        //new Itemlist { Text = "Punjab", Value = 4 },
        //new Itemlist { Text = "Gujarat", Value = 5 },
        //};
        //}


        [Required(ErrorMessage = "Please Enter Email")] //default error message => " email not entered"
        [EmailAddress]
        public string Email { get; set; } = default! ;

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "Password did not match")]
        public string ConfirmPassword { get; set; } = default ! ;

        [Required(ErrorMessage = "Please Enter First Name")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        public string lName { get; set; }


        [Required(ErrorMessage = "Please Enter phone nymber")]
        public int phone { get; set; }

        [Required(ErrorMessage = "Please Enter Date of Birth")]
        public string DOB { get; set; }
        public string Referral { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter State")]

        //public List<Itemlist> State { get; set; }
        //public List<SelectListItem> States { set; get; }
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }

    }

    //public class Itemlist
    //{
    //    public string Text { get; set; }
    //    public int Value { get; set; }
    //}
}

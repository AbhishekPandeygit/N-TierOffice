using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; } 
        public string fName { get; set; }
        public string lName { get; set; }

        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }

        public string DOB { get; set; }
        public string Referral { get; set; }
        public string Address { get; set; }

        public string State { get; set; }
        public string Location { get; set; }

    }
}

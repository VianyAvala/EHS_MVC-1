using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EHS_MVC.Models
{
    public class UserDetailsViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the User Name")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "User name should be minimum of 3 characters and maximum of 50 characters")]
        public string UserName { get; set; }

        public byte[] PasswordSalt { get; set; }

        public byte[] PasswordHash { get; set; }

        [Required(ErrorMessage = "Please enter the Email Address")]
        [EmailAddress(ErrorMessage = "please enter a valid email address")]
        public string Email { get; set; }


        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Required]
        public string Role { get; set; }

        public ICollection<HouseViewModel> Houses { get; set; }

    }
}
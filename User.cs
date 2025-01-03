using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotations
{
    internal class User
    {
        [Required(ErrorMessage = "Id is required")]
        [Range(100,999,ErrorMessage ="Id should be of 3 length")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required!")]
        [StringLength(25,MinimumLength = 4,ErrorMessage ="Name should minimum contains 4 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage="Email is not valid!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [Phone(ErrorMessage ="Enter valid Phone number")]
        public string Phone { get; set; }

    }
}

using ClassLibraryTournaments.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibraryTournaments
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 9)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
 //       [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevFrom.API.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "UserName is required!")]
        [MaxLength(200,ErrorMessage="Max length is 200!"),MinLength(3,ErrorMessage="Min length is 3!")]
        public string UserName { get; set; }    
        
        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6,ErrorMessage="Min length is 6!")]        
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnowAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; } 
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos {get; set;} 

    }
}
using System.ComponentModel.DataAnnotations;

namespace DevFrom.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "UserName is required!")]
        [MaxLength(200,ErrorMessage="Max length is 200!"),MinLength(3,ErrorMessage="Min length is 3!")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6,ErrorMessage="Min length is 6!")] 
        public string Password { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Models.Request
{
    public class SignInDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
    }
}
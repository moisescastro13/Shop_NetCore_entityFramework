using System.ComponentModel.DataAnnotations;

namespace Models.Request
{
    public class SignUpDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
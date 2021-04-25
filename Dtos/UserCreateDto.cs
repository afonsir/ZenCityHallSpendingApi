using System.ComponentModel.DataAnnotations;

namespace ZenCityHallSpendingApi.Dtos
{
    public class UserCreateDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }

        [Required]
        public string Role { get; set; }
    }
}

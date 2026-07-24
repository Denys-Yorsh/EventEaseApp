using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models;

public class RegistrationModel
{
    [Required(ErrorMessage = "Имя обязательно для заполнения")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный адрес электронной почты")]
    public string Email { get; set; } = string.Empty;
}
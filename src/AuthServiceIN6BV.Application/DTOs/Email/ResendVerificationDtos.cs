using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BV.Aplication.DTOs.Email;

public class ResendVerificationDto
{
    [Required]
    [EmailAddress]
    public string Email {get; set; } = string.Empty;
}
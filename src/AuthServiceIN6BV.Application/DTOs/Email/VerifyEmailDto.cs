using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace AuthServiceIN6BV.Aplication.DTOs.Email;

public class VerifyEmailDto
{
    public string Token {get; set;} = string.Empty;
}
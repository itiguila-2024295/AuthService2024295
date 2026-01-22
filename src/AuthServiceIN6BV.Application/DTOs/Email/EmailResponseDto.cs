using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BV.Aplication.DTOs.Email;

public class EmailResponseDto
{
    public bool Succes {get; set;}
    public string Message {get; set;} = string.Empty;
    public object? Data {get; set;}
}
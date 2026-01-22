using AuthServiceIN6BV.Domain.Entities;

namespace AuthServiceIN6BV.Aplication.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken (User user);
}
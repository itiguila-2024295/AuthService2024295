
using AuthServiceIN6BV.Domain.Entities;

namespace AuthServiceIN6BV.Domain.Interface;

public interface IUserRepository
{
    Task<User> CreateAsync(User user);
    Task<User> GetByIdAsync(string id);
    Task<User?> GetByEmail(string email);
    Task<User?> GetByUsernameAsync(string username);
    Task<User?> GetByEmailVerificationTokenAsync(string token);
    Task<User?> GetByPasswordResetTokenAsync (string token);
    Task<bool> ExistsByEmailAsync (string email);
    Task<bool> ExistsByUsernameAsync (string username);
    Task<User> UpdateAsycn (User user);
    Task<bool> DeleteAsynct (string id);
    Task UpdateUserRoleAsync (string userId, string roleId);
}

using System.Globalization;

namespace AuthServiceIN6BV.Domain.Constancs;

public static class RoleConstas
{
    public const string ADMIN_ROLE = "ADMIN_ROLE";  
    public const string USER_ROLE = "USER_ROLE";

    public static readonly string [] AllowedRoles = [ADMIN_ROLE, USER_ROLE];
    
}
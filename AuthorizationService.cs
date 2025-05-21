
public class AuthorizationService
{
    public static bool HasAccess(User user, string requiredRole)
    {
        return user != null && user.Role == requiredRole;
    }
}

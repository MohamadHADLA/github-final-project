
using BCrypt.Net;

public class AuthService
{
    public static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }

    public bool AuthenticateUser(string username, string password)
    {
        var user = GetUserFromDatabase(username); // Fetch user from DB
        if (user == null) return false;

        return VerifyPassword(password, user.HashedPassword);
    }

    private User GetUserFromDatabase(string username)
    {
        // Placeholder for database retrieval logic
        return new User { Username = username, HashedPassword = HashPassword("SecurePass123!"), Role = "user" };
    }
}

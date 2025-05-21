
using NUnit.Framework;

[TestFixture]
public class TestAuthentication
{
    [Test]
    public void TestPasswordHashingAndVerification()
    {
        string password = "SecurePass123!";
        string hash = AuthService.HashPassword(password);

        Assert.IsTrue(AuthService.VerifyPassword(password, hash));
        Assert.IsFalse(AuthService.VerifyPassword("WrongPass", hash));
    }

    [Test]
    public void TestInvalidLogin()
    {
        var result = new AuthService().AuthenticateUser("nonexistent", "password");
        Assert.IsFalse(result);
    }
}


using NUnit.Framework;

[TestFixture]
public class TestAuthorization
{
    [Test]
    public void TestAdminAccess()
    {
        var adminUser = new User { Username = "admin", Role = "admin" };
        var result = AuthorizationService.HasAccess(adminUser, "admin");
        Assert.IsTrue(result);
    }

    [Test]
    public void TestUserAccessDenied()
    {
        var normalUser = new User { Username = "user", Role = "user" };
        var result = AuthorizationService.HasAccess(normalUser, "admin");
        Assert.IsFalse(result);
    }
}

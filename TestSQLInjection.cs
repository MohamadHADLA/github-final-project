
using NUnit.Framework;

[TestFixture]
public class TestSQLInjection
{
    [Test]
    public void TestInjectionBlocked()
    {
        string maliciousInput = "' OR '1'='1";
        var result = new AuthService().AuthenticateUser(maliciousInput, "anyPassword");
        Assert.IsFalse(result); // Should not authenticate
    }
}

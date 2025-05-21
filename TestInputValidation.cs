
using NUnit.Framework;

[TestFixture]
public class TestInputValidation
{
    [Test]
    public void TestForSQLInjection()
    {
        string maliciousInput = "'; DROP TABLE Users; --";
        string sanitized = InputSanitizer.Sanitize(maliciousInput);
        Assert.IsFalse(sanitized.Contains("DROP TABLE"));
    }

    [Test]
    public void TestForXSS()
    {
        string maliciousScript = "<script>alert('XSS')</script>";
        string sanitized = InputSanitizer.Sanitize(maliciousScript);
        Assert.IsFalse(sanitized.Contains("<script>"));
        Assert.IsTrue(sanitized.Contains("&lt;script&gt;"));
    }

    [Test]
    public void TestValidEmail()
    {
        Assert.IsTrue(InputSanitizer.IsValidEmail("user@example.com"));
        Assert.IsFalse(InputSanitizer.IsValidEmail("user@@example..com"));
    }

    [Test]
    public void TestValidUsername()
    {
        Assert.IsTrue(InputSanitizer.IsValidUsername("user_123"));
        Assert.IsFalse(InputSanitizer.IsValidUsername("user<script>"));
    }
}

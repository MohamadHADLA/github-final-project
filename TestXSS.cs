
using NUnit.Framework;

[TestFixture]
public class TestXSS
{
    [Test]
    public void TestXSSSanitization()
    {
        string input = "<script>alert('XSS')</script>";
        string sanitized = System.Net.WebUtility.HtmlEncode(input);
        Assert.IsFalse(sanitized.Contains("<script>"));
        Assert.IsTrue(sanitized.Contains("&lt;script&gt;"));
    }
}

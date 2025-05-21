
using System;
using System.Text.RegularExpressions;

public static class InputSanitizer
{
    public static string Sanitize(string input)
    {
        return System.Net.WebUtility.HtmlEncode(input.Trim());
    }

    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public static bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, @"^[A-Za-z0-9_]{3,20}$");
    }
}

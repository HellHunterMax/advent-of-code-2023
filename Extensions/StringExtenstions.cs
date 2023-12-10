namespace advent_of_code;

public static class StringExtenstions
{
    public static string ReverseString(this string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

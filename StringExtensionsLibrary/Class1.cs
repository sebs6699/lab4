namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            return char.IsUpper(input[0]);
        }
    }
}

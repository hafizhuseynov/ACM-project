namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpace(this string source)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    result = result.Trim();
                    if (char.IsUpper(letter)) result += " ";
                    result += letter;
                }
            }
            return result.Trim();
        }
    }
}

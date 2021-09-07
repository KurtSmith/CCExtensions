using System;
using System.Text.RegularExpressions;

namespace CCExtensions
{
    public static class CCExtensions
    {
        public static string ObfuscateCC(this string str)
        {
            //remove all whitespace
            var sanitized = Regex.Replace(str, @"\s+", "").Trim();
            if (sanitized.Length != 16)
                throw new Exception("Password must contain 16 numbers");

            // Sanity check throw if not numeric

            Int64.Parse(sanitized);

            return sanitized.Replace(sanitized.Substring(0, 12), "************");
        }
    }
}

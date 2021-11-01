using System;
using System.Linq;

namespace bruteforce
{
    public static class Constants
    {
        public static string Chars = "abcdefghij0123456789";
        public static int PwdLength = 6;

        public static string RandomizeString(string s)
        {
            var r = new Random();
            var randoString = new string(s.ToCharArray()
                                            .OrderBy(i => (r.Next(3) % 3) != 0).ToArray());
            return randoString;
        }
    }
}
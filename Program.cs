using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace bruteforce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordered guessing");
            Console.WriteLine("4-character passwords");

            for (int i = 0; i < 20; i++)
            {
                Constants.PwdLength = 4;
                OrderGuesser4.Guess();
            }

            Console.WriteLine("Ordered guessing");
            Console.WriteLine("6-character passwords");
            for (int i = 0; i < 20; i++)
            {
                Constants.PwdLength = 6;
                OrderGuesser6.Guess();
            }


            Console.WriteLine("Random guessing");
            Console.WriteLine("4-character passwords");
            for (int i = 0; i < 20; i++)
            {
                Constants.PwdLength = 4;
                RngGuesser4.Guess();
            }

            Console.WriteLine("Random guessing");
            Console.WriteLine("4-character passwords");
            for (int i = 0; i < 20; i++)
            {
                Constants.PwdLength = 6;
                RngGuesser6.Guess();
            }


            Console.WriteLine("Ordered guessing");
            Console.WriteLine("8-character passwords");
            for (int i = 0; i < 20; i++)
            {
                Constants.PwdLength = 8;
                OrderGuesser8.Guess();
            }

            Console.WriteLine("Random guessing");
            Console.WriteLine("8-character passwords");
            for (int i = 0; i < 20; i++)
            {
                Constants.PwdLength = 8;
                RngGuesser8.Guess();
            }

            return;

            // var pwd_length = Constants.PwdLength;
            // var availableCharsCount = Constants.Chars.Length;
            // var rand = new Random();

            // StringBuilder sbPassword = new StringBuilder(Constants.PwdLength);
            // var maxIdx = availableCharsCount - 1;

            // for (int i = 0; i < pwd_length; i++)
            // {
            //     var randIdx = rand.Next(0, maxIdx);
            //     sbPassword.Append(Constants.Chars[randIdx]);
            // }

            // string pwd = sbPassword.ToString();
            // Console.WriteLine($"Password is: {pwd}");

            // string guess = null;
            // var sw = new Stopwatch();

            // sw.Start();
            // for (int a = 0; a < availableCharsCount; a++)
            // {
            //     for (int b = 0; b < availableCharsCount; b++)
            //     {
            //         for (int c = 0; c < availableCharsCount; c++)
            //         {
            //             for (int d = 0; d < availableCharsCount; d++)
            //             {
            //                 for (int e = 0; e < availableCharsCount; e++)
            //                 {
            //                     for (int f = 0; f < availableCharsCount; f++)
            //                     {
            //                         if (Constants.Chars[a] == pwd[0] && Constants.Chars[b] == pwd[1] && Constants.Chars[c] == pwd[2] && Constants.Chars[d] == pwd[3] && Constants.Chars[e] == pwd[4] && Constants.Chars[f] == pwd[5])
            //                         {
            //                             sw.Stop();
            //                             Console.WriteLine($"Password found...{pwd} == {guess}");
            //                             break;
            //                         }
            //                     }
            //                 }
            //             }
            //         }
            //     }
            // }
            // Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds} ms");
        }

        private static string RandomizeString(string s)
        {
            var r = new Random();
            var randoString = new string(s.ToCharArray()
                                            .OrderBy(i => (r.Next(3) % 3) != 0).ToArray());
            return randoString;
        }

    }

    public static class StringExtensions
    {
        public static string Shuffle(this string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
    }
}

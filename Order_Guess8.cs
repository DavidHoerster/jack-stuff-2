using System;
using System.Diagnostics;
using System.Text;

namespace bruteforce
{
    public static class OrderGuesser8
    {
        public static void Guess()
        {
            var pwd_length = Constants.PwdLength;
            var availableCharsCount = Constants.Chars.Length;
            var rand = new Random();

            StringBuilder sbPassword = new StringBuilder(Constants.PwdLength);
            var maxIdx = availableCharsCount - 1;

            for (int i = 0; i < pwd_length; i++)
            {
                var randIdx = rand.Next(0, maxIdx);
                sbPassword.Append(Constants.Chars[randIdx]);
            }

            string pwd = sbPassword.ToString();
            Console.WriteLine($"Password is: {pwd}");

            string guess = null;
            var sw = new Stopwatch();

            sw.Start();
            for (int a = 0; a < availableCharsCount; a++)
            {
                for (int b = 0; b < availableCharsCount; b++)
                {
                    for (int c = 0; c < availableCharsCount; c++)
                    {
                        for (int d = 0; d < availableCharsCount; d++)
                        {
                            for (int e = 0; e < availableCharsCount; e++)
                            {
                                for (int f = 0; f < availableCharsCount; f++)
                                {
                                    for (int g = 0; g < availableCharsCount; g++)
                                    {
                                        for (int h = 0; h < availableCharsCount; h++)
                                        {
                                            if (Constants.Chars[a] == pwd[0] && Constants.Chars[b] == pwd[1] && Constants.Chars[c] == pwd[2] && Constants.Chars[d] == pwd[3] && Constants.Chars[e] == pwd[4] && Constants.Chars[f] == pwd[5] && Constants.Chars[g] == pwd[6] && Constants.Chars[h] == pwd[7])
                                            {
                                                sw.Stop();
                                                var ms = sw.ElapsedMilliseconds;
                                                Console.WriteLine($"Password found...{pwd} == {guess}");
                                                Console.WriteLine($"Elapsed time: {ms} ms");
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
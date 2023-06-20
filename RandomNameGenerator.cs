using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterConverter
{
    public static class RandomNameGenerator
    {
        private static readonly char[] _alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz".ToCharArray();
        private static readonly string[] _prefixes = new string[] { "von", "der", "de", "du", "la", "le" };
        private static readonly Random _random = new();

        public static string GenerateFullName()
        {
            List<string> nameParts = new()
            {
                GeneratePartName()
            };

            while (_random.Next(10) > 5)
            {
                nameParts.Add(PrefixInRandomRegister());
            }

            nameParts.Add(GeneratePartName());

            return string.Join(" ", nameParts);
        }

        private static string PrefixInRandomRegister()
        {
            string prefix = _prefixes[_random.Next(_prefixes.Length)];
            StringBuilder sb = new();

            foreach (char sign in prefix)
            {
                _ = _random.Next(10) > 5 ? sb.Append(char.ToUpper(sign)) : sb.Append(sign);
            }

            return sb.ToString();
        }

        private static string GeneratePartName()
        {
            int length = _random.Next(5, 15);
            StringBuilder sb = new();

            for (int i = 0; i < length; ++i)
            {
                _ = sb.Append(_alphabet[_random.Next(_alphabet.Length)]);
            }

            return sb.ToString();
        }
    }
}
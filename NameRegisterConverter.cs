using System.Collections.Generic;
using System.Linq;

namespace RegisterConverter
{
    public static class NameRegisterConverter
    {
        private static readonly string[] _prefixes = new string[] { "von", "der", "de", "du", "la", "le" };
        public static string Convert(string input)
        {
            string[] inputParts = input.ToLower(System.Globalization.CultureInfo.CurrentCulture).Split(" ");
            List<string> nameParts = new(inputParts.Length);

            foreach (string inputPart in inputParts)
            {
                if (string.IsNullOrEmpty(inputPart))
                {
                    continue;
                }

                if (_prefixes.Contains(inputPart))
                {
                    nameParts.Add(inputPart);
                }
                else
                {
                    nameParts.Add($"{char.ToUpper(inputPart[0])}{inputPart[1..]}");
                }
            }

            return string.Join(" ", nameParts);
        }
    }
}
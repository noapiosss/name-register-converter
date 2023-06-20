using System;
using RegisterConverter;

// Random assets with prefixes
//
// Console.WriteLine("{0,-40} {1,1} {2,-40}", "Input:", "|", "Output:");
// Console.WriteLine("-----------------------------------------------------------------------------------");
//
// for (int i = 0; i < 20; ++i)
// {
//     string input = RandomNameGenerator.GenerateName();
//     Console.WriteLine("{0,-40} {1,1} {2,-40}", input, "|", NameRegisterConverter.Convert(input));
// }

Console.Write("Write full name: ");
string input = Console.ReadLine();
Console.WriteLine($"Correct register: {NameRegisterConverter.Convert(input)}");
using System;
using RegisterConverter;

// for (int i = 0; i < 20; ++i)
// {
//     string input = RandomNameGenerator.GenerateFullName();
//     Console.WriteLine("{0,-35} {1,-2} {2,-35}", input, "=>", NameRegisterConverter.Convert(input));
// }

Console.Write("Write full name: ");
string input = Console.ReadLine();
Console.WriteLine($"Correct register: {NameRegisterConverter.Convert(input)}");
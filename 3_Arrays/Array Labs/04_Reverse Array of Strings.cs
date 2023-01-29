
string[] letters = Console.ReadLine()
    .Split(" ")
    .ToArray();

letters = letters
    .Reverse()
    .ToArray();

Console.WriteLine(string.Join(" ",letters));


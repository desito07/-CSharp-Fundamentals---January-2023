int[] inputNumbers = Console.ReadLine() // 10 20 30
    .Split()
    .Select(int.Parse)
    .ToArray();

// 10 20 30 40 => 30 50 70 40 => 80 120 70 40 => 200 120 70 40 

for (int i = 0; i < inputNumbers.Length - 1; i++)
{
    for (int j = 0; j < inputNumbers.Length - 1 - i; j++)
    {
        inputNumbers[j] = inputNumbers[j] + inputNumbers[j + 1];  
    }
}
Console.WriteLine(inputNumbers[0]);

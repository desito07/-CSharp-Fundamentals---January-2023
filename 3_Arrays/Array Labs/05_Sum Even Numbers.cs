

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int current = numbers[i];
    if (current % 2 == 0)
    {
        sum += current;
    }
}
Console.WriteLine(sum);

//  Алтернатива

//int numbers = Console.ReadLine()
//    .Split(" ")
//    .Select(int.Parse)
//    .Where(x => x % 2 == 0)
//    .Sum();
//Console.WriteLine(numbers);

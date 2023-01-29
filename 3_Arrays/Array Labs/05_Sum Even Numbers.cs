

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int current = numbers[i];
    if(current % 2 == 0)
    {
        sum += current;
    }
}
Console.WriteLine(sum);

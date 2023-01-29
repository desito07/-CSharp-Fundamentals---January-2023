
int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sumEven = 0;
int sumOdd = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int current = numbers[i];
    if (current % 2 == 0)
    {
        sumEven += current;
    }
    else
    {
        sumOdd += current;
    }
}
int diff = sumEven - sumOdd;
Console.WriteLine(diff);

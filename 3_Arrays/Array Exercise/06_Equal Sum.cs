int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

int leftSum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum -= numbers[i];
    if(leftSum == sum)
    {
        Console.WriteLine(i);
        return;
    }

    leftSum += numbers[i];
}
Console.WriteLine("no");

﻿





int[] num1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();



int[] num2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool areSame = true;


for (int i = 0; i < num1.Length; i++)
{
    sum += num1[i];
    if (num1[i] != num2[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        areSame = false;
    break;
    }
}
if (areSame)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}



int[] inputNum = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
int rotation = int.Parse(Console.ReadLine());



for (int j = 0; j < rotation; j++)
{
    int firstElement = inputNum[0];

    for (int i = 0; i < inputNum.Length - 1; i++)
    {
        inputNum[i] = inputNum[i + 1];
    }
    inputNum[inputNum.Length - 1] = firstElement;
}

Console.WriteLine(string.Join(" ", inputNum));

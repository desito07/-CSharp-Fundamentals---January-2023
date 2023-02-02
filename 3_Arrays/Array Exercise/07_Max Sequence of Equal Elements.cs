int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int longestSequenceStartIndex = 0;
int longestSequenceLength = 0;

for (int i = 1; i < numbers.Length; i++)
{
    int currentSequenceStartIndex = i - 1;
    int currentSequesnceLength = 1;

    while ( i < numbers.Length && numbers[i] == numbers[i - 1])
    {
        currentSequesnceLength++;
        i++;
    }

    if(currentSequesnceLength > longestSequenceLength)
    {
        longestSequenceLength = currentSequesnceLength;
        longestSequenceStartIndex = currentSequenceStartIndex;
    }
}

for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLength; i++)
{
    Console.Write($"{numbers[i]} ");
}

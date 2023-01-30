int[] inputNumbers = Console.ReadLine() // 10 20 30
    .Split()
    .Select(int.Parse)
    .ToArray();

//int[] condensedArray = new int[0];


for (int i = 0; i < inputNumbers.Length - 1; i++)
{

    //condensedArray = inputNumbers; // 10 20 30

    for (int j = 0; j < inputNumbers.Length - 1 - i; j++)
    {
        inputNumbers[j] = inputNumbers[j] + inputNumbers[j + 1];  
    }

    //inputNumbers = condensedArray;
    
}
Console.WriteLine(inputNumbers[0]);

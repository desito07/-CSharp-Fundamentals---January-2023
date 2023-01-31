

string[] firstArray = Console.ReadLine().Split();
string[] secondArray = Console.ReadLine().Split();

for (int i = 0; i < secondArray.Length; i++)
{
    string current = secondArray[i];

    for (int j = 0; j < firstArray.Length; j++)
    {
        if(current == firstArray[j])
        {
            Console.WriteLine(current + " ");
        }
    }
}

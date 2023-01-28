int n = int.Parse(Console.ReadLine()); // 3

int[] array = new int[n]; // [0, 0, 0]

for (int i = 0; i < array.Length; i++)
{
    int current = int.Parse(Console.ReadLine());
    array[i] = current;
}

// без метода .Reversed();

//for (int i = array.Length - 1; i >= 0; i--)
//{
//    Console.Write(array[i] + " ");
//}


int[] reversed = array.Reverse().ToArray();

for (int i = 0; i < reversed.Length; i++)
{
    Console.Write(reversed[i] + " ");
}


int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    {

     int current = int.Parse(Console.ReadLine());
     array[i] = current;
   }

for (int i = array.Length - 1; i >= 0; i--)
   {
    Console.Write(array[i] + " ");
   }
       

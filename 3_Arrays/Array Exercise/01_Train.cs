
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
   
int sum = 0; 

for (int i = 0; i < numbers.Length; i++)
{
    int current = int.Parse(Console.ReadLine());
    numbers[i] = current;
    sum += current;
    
}
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(sum);





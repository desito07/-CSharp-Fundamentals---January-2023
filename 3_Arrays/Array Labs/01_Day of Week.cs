

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int intOfDaysOfWeek = int.Parse(Console.ReadLine());

if(intOfDaysOfWeek >= 1 && intOfDaysOfWeek <= 7)
{
    Console.WriteLine(days[intOfDaysOfWeek - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}
// Demo Lab 
// ==================================
string[] arrayNames = { "Desi", "Pesho", "Stephan", "Gosho", "Kiro" };

Console.WriteLine(arrayNames[0]);
Console.WriteLine(arrayNames[1]);
Console.WriteLine(arrayNames[2]);
Console.WriteLine(arrayNames[arrayNames.Length - 1]);
Console.WriteLine(arrayNames.Length);

// ===================================
// масивите трябва да са от един и същи тип данни
string[] arrayOfNames = { 1, 2 };

int[] numbers = new int[10];

// ===================================
string[] wagons = new string[4];

wagons[0] = "A";
wagons[1] = "B";
wagons[2] = "C";
wagons[3] = "D";

//wagons[4] = "E";
Console.WriteLine(wagons[3]);
Console.WriteLine(wagons[-1]);

//// =================================

// създаване на масив
int[] numbers2 = { 1, 2, 3 };
int[] numbers3 = new int[3] { 1, 2, 3 };

// ====================================
int[] numbers = new int[5];
int[] numbers = new int[10];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

Console.WriteLine(numbers[3]);
for (int i = 0; i < numbers.Length; i++)
{
    // да напълниш масива
    numbers[i] = i;
    //numbers[i] = i + 1;
    //Console.WriteLine(i);
    Console.WriteLine(i + 1);
}

// да смениш елементите 
numbers[0] = 23;

for (int i = 0; i < numbers.Length; i++)
{
    // да принтираш
    Console.WriteLine(numbers[i]);
}

// ====================================

int[] numbers1 = { 10, 20, 30, 40 };

numbers1[0] = numbers1[1] + numbers1[2]; // 10 = 20 + 30 вече ще стане 50

Console.WriteLine(numbers1[0]);

// ===================================

int n = int.Parse(Console.ReadLine());    //четем число от конзолата

int[] numbers = new int[n];  // създаваме нов масив с елементи от числото 

for (int i = 0; i < numbers.Length; i++) // въртим цикъл и четем всеки от тези елементи
{
    int input = int.Parse(Console.ReadLine());  // четем всяко число от поредицата 
    numbers[i] = input;  // презаписваме и пълним в масива
}

Console.WriteLine("-----");
for (int i = 0; i < numbers.Length; i++)  // въртим втори цикъл за вече напълнения масив
{
    Console.WriteLine(numbers[i]);  // принтираме числата от масива
}

// =========================================

string input = "12 20 30 12 44"; // четем от конзолата инпут стринг

string[] numberAsString = input.Split(); // създава се нов масив като се цепи инпута на отделните елементи и се присвояват в масива
                                         // ["12", "20", "30", "12", "44"]

// Split - връща масив с елементите вътре и място между тях

int[] integers = new int[numberAsString.Length]; // създаваме нов масив от числа като ползваме дължината на стринг масива

for (int i = 0; i < numberAsString.Length; i++) // въртим цикъл през дължината на стринг масива и презаписваме всяко i  като число и пълним масива с числа като добавяме единица на всяко и после принтираме на конзилата числата от интиджър масива
{
    integers[i] = int.Parse(numberAsString[i]) + 1;
    Console.WriteLine(integers[i]);
}

// ============================================

string input = "12, 20, 30, 12, 44";
string[] inputArray = input.Split(", "); // Split-a разделя стринг-а на елементите според, което сме му казали и ни връща същите тези елементи разделени

int[] numbers = inputArray  // ["12", "20", "30", "12", "44"]
    .Select(int.Parse) // x=> int.Parse  [12, 20, 30, 12, 44]
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i] + 1);  // 13, 21, 31, 13, 45
}

// това цялото може да се запише така:

int[] test = Console.ReadLine() // "12, 20, 30, 12, 44"
    .Split(", ")
    .Select(int.Parse)
    .ToArray(); // [12, 20, 30, 12, 44]

//при повече разстояния между елементите

string input = "12    30    44";
string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] numbers = array
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// =========================================

//.Split - ще раздели елементите по някакъв начин един от друг
//.Select - ще ги парсне от стринг в числа
//.ToArray -  ще ги направи в стринг

// =========================================
  .Join

string[] names = { "Pesho", "Stoyan", "Ivan" };

Console.WriteLine(string.Join(", ", names));

 // ==========================================

string[] numbers = { "40", "30", "20", "10" };

foreach (var current in numbers)
{
    Console.WriteLine(current);
}

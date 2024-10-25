//--------------- Level 1 ---------------

var numList = new List<int>();
int sumOfNumList = 0;

Console.WriteLine("Enter your name:");
string name = Console.ReadLine()!;

Console.WriteLine("Enter your hobby:");
string hobby = Console.ReadLine()!;

if (hobby.Contains("code"))
{
    Console.WriteLine($"{name}, it sounds like you enjoy coding!");
} 
else if(hobby.Contains("Movies"))
{
    Console.WriteLine($"{name}, that sounds like a fun hobby!");
}

Console.WriteLine("Enter your first favorite number:");
int favNum1 = int.Parse(Console.ReadLine()!);
numList.Add(favNum1);

Console.WriteLine("Enter your second favorite number:");
int favNum2 = int.Parse(Console.ReadLine()!);
numList.Add(favNum2);

Console.WriteLine("Enter your third favorite number:");
int favNum3 = int.Parse(Console.ReadLine()!);
numList.Add(favNum3);

for(int i = 0; i < numList.Count; i++)
{
    sumOfNumList += numList[i];
}

Console.WriteLine($"{name}, the sum of your favorite numbers are {sumOfNumList}.");

if(sumOfNumList > 100)
{
    Console.WriteLine("The sum of your favorite numbers are greater than 100!");
}
else if(sumOfNumList <= 100)
{
    Console.WriteLine("The sum of your favorite numbers is 100 or less.");
}

// --------------- Level 2 ---------------

// var colors = new List<string>();
// var animals = new List<string>();

// Console.WriteLine("Enter your name:");
// string name = Console.ReadLine()!;

// Console.WriteLine("Enter your age:");
// int age = int.Parse(Console.ReadLine()!);

// if (age >= 18)
// {
//     Console.WriteLine($"Hello {name}, you are an adult.");
// }

// Console.WriteLine("Enter your first favorite color:");
// string favCol1 = Console.ReadLine()!;
// colors.Add(favCol1);

// Console.WriteLine("Enter your second favorite color:");
// string favCol2 = Console.ReadLine()!;
// colors.Add(favCol2);

// Console.WriteLine("Enter your third favorite color:");
// string favCol3 = Console.ReadLine()!;
// colors.Add(favCol3);

// Console.WriteLine($"{name}, your favorite colors are:");

// foreach (string color in colors)
// {
//     Console.WriteLine(color);
// }
// if (colors.Contains("blue"))
// {
//     Console.WriteLine($"You have entered blue as one of your favorite colors! That's a popular choice.");
// }

// Console.WriteLine();
// Console.WriteLine("--- LEVEL 2 ---");
// Console.WriteLine();

// while (true)
// {
//     Console.Write("Enter animal (or done): ");
//     string input = Console.ReadLine()!;

//     if (input == "done")
//     {
//         break;
//     }

//     animals.Add(input);
// }

// string result = string.Join(", ", animals);
// Console.WriteLine($"The animals:{result}");
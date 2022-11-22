// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Welcome in calculator");
string drive = "yes";
while (drive == "yes")
{
    Console.WriteLine("Write 1. number: ");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Write 2. number: ");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Choose operation:");
    Console.WriteLine("1 - count");
    Console.WriteLine("2 - subtraction");
    Console.WriteLine("3 - multiplication");
    Console.WriteLine("4 - division");
    int choise = int.Parse(Console.ReadLine());
    double result = 0;
    switch (choise)
    {
        case 1:
            result = a + b;
            break;
        case 2:
            result = a - b;
            break;
        case 3:
            result = a * b;
            break;
        case 4:
            result = a / b;
            break;
    }
    if ((choise > 0) && (choise < 5))
    {
        Console.WriteLine("Result: " + result);
    }
    else
    {
        Console.WriteLine("You entered the wrong choice!");
    }
    Console.WriteLine("Would you like to enter another example? [yes/no]");
    drive = Console.ReadLine();
}
Console.WriteLine("Thanks and bye");
Console.ReadKey();
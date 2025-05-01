using System;
 
class Program
{
    static double AddNumbers(double a, double b)
    {
        return a + b;
    }

    static void DisplayGreeting()
    {
        Console.WriteLine("Hello Bob, how are you?");
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // This is a test.
        // This is a second change.

        // Console.Write("Input your first name: ");
        // string firstName = Console.ReadLine();
        // Console.Write("Input your Last name: ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");

        // int x = 10;
        // if (x == 10)
        // {
        //     Console.WriteLine("X is 10");
        // }

        // Console.WriteLine("Hey how are you?");

        // Console.WriteLine("Hey betty how are you?");

        // Console.WriteLine("I am doing great.");

        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"Hello Bob {i}");
        // }

        // int x = 0;
        // x++;
        // int y = x;
        // int y = x++;
        // Console.WriteLine(y);
        // Console.WriteLine(x);
        // y = ++x;
        // Console.WriteLine(y);
        // x--;
        // Console.WriteLine($"{x++}");
        // Console.WriteLine(x);

        // List<int> myNumbers = new List<int>();   
        // myNumbers.Add(10);
        // myNumbers.Add(99);
        // myNumbers.Add(-123);
        // int total = 0;

        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        //     total += i;
        // }

        // Console.WriteLine(total);

        double total = AddNumbers(123.4546, 987.1234);
        Console.WriteLine(total);
        Console.WriteLine(AddNumbers(234, 432));

        DisplayGreeting();

    }
}
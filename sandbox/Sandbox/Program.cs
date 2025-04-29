using System;
 
class Program
{
    static double AddNumbers(double a, double b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // This is a test.
        // This is a second change.

        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input your Last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");

        int x = 10;
        if (x == 10)
        {
            Console.WriteLine("X is 10");
        }

        List<int> myNumbers = new List<int>();
        myNumbers.Add(10);
        myNumbers.Add(20);
        myNumbers.Add(30);
        myNumbers.Add(40);
        int total = 0;
        foreach (int number in myNumbers)
        {
            Console.WriteLine(number);
            total += number;
        }
        Console.WriteLine($"{total}");

        double finalTotal = AddNumbers(total, 100);
        Console.WriteLine($"{finalTotal}");

        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("" + i);
        }

        // this is a test comment.

    }
}
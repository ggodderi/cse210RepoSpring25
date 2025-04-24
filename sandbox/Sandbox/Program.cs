using System;
 
class Program
{
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

    }
}
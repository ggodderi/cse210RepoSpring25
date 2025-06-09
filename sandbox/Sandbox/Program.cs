using System;
using System.Diagnostics.Tracing;
using System.IO.Compression;


class Program
{
    private static void Main(string[] args)
    {
        int sleepTime =450;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(20);
        string animationString = "-/-\\_";
        string animationString2 = ":(:)";
        string animationString3 = "(-_-)(^_^)";
        int count = 0;

        Console.Write("Waiting: ");
        while (DateTime.Now < futureTime)
        {
            // Console.Write(".");
            // Console.Write("+");
            Console.Write(animationString3[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b     \b\b\b\b\b");
            Console.Write(animationString3[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b     \b\b\b\b\b");
            count += animationString3.Length;
            // Console.Write("-");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b \b");
        }
        // Circle myCircle = new Circle(10);
        // // myCircle.SetRadius(10);
        // // myCircle._radius = -10;
        // Console.WriteLine($"{myCircle.GetRadius()}");
        // // Circle myCircle2 = new Circle();
        // // myCircle2.SetRadius(20);
        // // Console.WriteLine($"{myCircle2.GetRadius()}");

            // Console.WriteLine($"{myCircle.GetArea()}");
            // // Console.WriteLine($"{myCircle2.GetArea()}");

            // Cylinder myCylinder = new Cylinder(100, 8);
            // // myCylinder.SetHeight(10);
            // // myCylinder.SetCircle(myCircle);
            // Console.WriteLine($"{myCylinder.GetVolume()}");
    }
}
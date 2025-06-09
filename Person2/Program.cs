﻿class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Croker", 23, "Bat");
        // Console.WriteLine(myPoliceMan.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 43, "Knife");
        Console.WriteLine(myDoctor.GetDoctorInformation());

    }
}

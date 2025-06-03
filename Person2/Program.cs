class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Croker", 23);
        Console.WriteLine(myPoliceMan.GetPersonInformation());
    }
}

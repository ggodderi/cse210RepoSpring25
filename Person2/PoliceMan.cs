class PoliceMan : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;

    public PoliceMan(string firstName, string lastName,
        int age, string weapons, int hoursWorked, double hourlyWage)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hoursWorked = hoursWorked;
        _hourlyWage = hourlyWage;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override string GetPersonInformation()
    {
        return $"I am a Police Man: Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override double GetPay()
    {
        double pay = 0;
        if (_hoursWorked > 40)
        {
            pay = 40 * _hourlyWage;
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        else
        {
            pay = _hourlyWage * _hoursWorked;
        }

        return pay;
    } 
}
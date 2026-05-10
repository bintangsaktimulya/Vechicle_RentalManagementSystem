class Vechile
{
    protected string _name;
    protected double _dailyRate;
    protected string _licensePlate;
    protected bool _isAvailable;

    public Vechile(string name, double daily_rate, string license_plate)
    {
        _name = name;
        _dailyRate = daily_rate;
        _licensePlate = license_plate;
        _isAvailable = true;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("The value can not be empty");
            }
            else
            {
                _name = value;
            }
        }
    }

    public double DailyRate
    {
        get { return _dailyRate; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("The value can not be less than  zero");
            }
            else
            {
                _dailyRate = value;
            }
        }
    }

    public string LicensePlate
    {
        get { return _licensePlate; }
    }

    public bool IsAvailable
    {
        get { return _isAvailable; }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{Name} \t|{LicensePlate} \t|{DailyRate} / day \t|{(IsAvailable ? "Available" : "Not Available")} \t");
    }

    public double CalculateCost(int days)
    {
        return DailyRate * days;
    }

    public void SetAvailablility()
    {
        _isAvailable = !_isAvailable;
    }
}
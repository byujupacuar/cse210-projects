public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distanceKm) : base(date, minutes)
    {
        _distance = distanceKm;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / _distance;
}
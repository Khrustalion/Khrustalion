namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Train
{
    private double Mass { get; }

    private double Speed { get; set; }

    private double Acceleration { get; set; }

    private double MaxForce { get; }

    public Train(double mass, double speed, double acceleration, double maxForce)
    {
        Mass = mass;
        Speed = speed;
        Acceleration = acceleration;
        MaxForce = maxForce;
    }

    public bool ApplyForce(double force)
    {
        if (force > MaxForce) return false;
        Acceleration += force / Mass;
        return true;
    }

    public bool Standing()
    {
        return (Speed == 0 && Acceleration <= 0) || Speed < 0;
    }

    public void Iteration(double precision)
    {
        Speed += Acceleration * precision;
    }
}

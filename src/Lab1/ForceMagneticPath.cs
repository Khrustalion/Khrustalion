namespace Itmo.ObjectOrientedProgramming.Lab1;

public class ForceMagneticPath : ISectionRoad
{
    public double Duration { get; set; }

    private double Force { get; set; } = 0;

    public ForceMagneticPath(double force, double duration)
    {
        Duration = duration;
        Force = force;
    }

    public bool Passing(Train train, double precision)
    {
        if (!train.ApplyForce(Force)) return false;

        double time = 0;
        while (time < Duration)
        {
            if (train.Standing()) return false;

            train.Iteration(precision);

            time += precision;
        }

        return true;
    }
}
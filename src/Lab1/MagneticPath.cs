namespace Itmo.ObjectOrientedProgramming.Lab1;

public class MagneticPath : ISectionRoad
{
    public double Duration { get; set; }

    public MagneticPath(double duration)
    {
        Duration = duration;
    }

    public bool Passing(Train train, double precision)
    {
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
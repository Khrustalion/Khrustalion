namespace Itmo.ObjectOrientedProgramming.Lab1;

public interface ISectionRoad
{
    public double Duration { get; set; }

    public bool Passing(Train train, double precision);
}
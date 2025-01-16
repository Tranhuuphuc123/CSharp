using System;

public abstract class Dongvat
{
    public abstract string Name { get; }
    public abstract void Makesound();
}

public class Cho : Dongvat
{
    public override string Name
    {
        get
        {
            return "Dog";
        }
    }

    public override void Makesound()
    {
        Console.WriteLine("Gau Gau");
    }
}


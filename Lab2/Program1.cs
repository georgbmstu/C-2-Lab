using System;

class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void Study()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void Read()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void Write()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Relax();
        }
    }
}

class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxing");
    }
}
class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excellent pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Excellent pupil is relaxing");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Good pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil is relaxing");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad pupil is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil is relaxing");
    }
}

class Program1
{
    static void Main()
    {
        ClassRoom classRoom1 = new ClassRoom(new ExcellentPupil(), new GoodPupil());
        classRoom1.Study();
        classRoom1.Read();
        classRoom1.Write();
        classRoom1.Relax();

        Console.WriteLine();

        ClassRoom classRoom2 = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil());
        classRoom2.Study();
        classRoom2.Read();
        classRoom2.Write();
        classRoom2.Relax();

        Console.WriteLine();

        ClassRoom classroom3 = new ClassRoom(new Pupil(), new GoodPupil(), new ExcellentPupil(), new BadPupil());
        classroom3.Study();
        classroom3.Read();
        classroom3.Write();
        classroom3.Relax();
    }
}

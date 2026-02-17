//S -> Single Respinsibility Principal.
class GetStudent
{
    public int getStudent()
    {
        return 310;
    }
}
class studentDisplay
{
    public void displayStudent()
    {
        Console.WriteLine("Atharv");
    }
}

//Open & Closed Principal.

// class Discount{
//   public double Calculate(double amount)
//     {
//         return amount + amount;
//     }
// }

// class StudentDiscount : Discount
// {
//     public override double Calculate(double amount)
//     {
//         return amount * 0.25;
//     }
// }

//Liskov Subtitution Principal
abstract class Bird
{
    public abstract void Eat();
}

abstract class FlyingBird : Bird
{
    public abstract void Fly();
}

class Sparrow : FlyingBird
{
    public override void Eat()
    {
        // eating logic
        Console.WriteLine("Sparrow Eat");
    }

    public override void Fly()
    {
        // flying logic
        Console.WriteLine("Sparrow Fly");
    }
}

class Ostrich : Bird
{
    public override void Eat()
    {
        // eating logic
        Console.WriteLine("Ostrich can eat.");
    }
}



class Program
{
    public static void Main(string[] args)
    {
        studentDisplay stdDis = new studentDisplay();
        stdDis.displayStudent();

        GetStudent getId = new GetStudent();
        int id = getId.getStudent();
        Console.WriteLine("Id = " + id);

        // StudentDiscount studentDiscount = new StudentDiscount();
        // Console.WriteLine(studentDiscount.Calculate(20000));

        Sparrow sparrow = new Sparrow();
        sparrow.Eat();
        sparrow.Fly();  

        Ostrich ostrich = new Ostrich();   
        ostrich.Eat();

    }
}

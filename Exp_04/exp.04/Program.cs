//Calculator using Delegate
//using System;

//class Program
//{
//    delegate int Calc(int a, int b);

//    static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sub(int a, int b)
//    {
//        return a - b;
//    }

//    static int Mul(int a, int b)
//    {
//        return a * b;
//    }

//    static int Div(int a, int b)
//    {
//        return a / b;
//    }

//    static int Mod(int a, int b)
//    {
//        return a % b;
//    }

//    static void Main()
//    {
//        Calc c;

//        c = Add;
//        Console.WriteLine("Addition: " + c(10, 5));

//        c = Sub;
//        Console.WriteLine("Subtraction: " + c(10, 5));

//        c = Mul;
//        Console.WriteLine("Multiplication: " + c(10, 5));

//        c = Div;
//        Console.WriteLine("Division: " + c(10, 5));

//        c = Mod;
//        Console.WriteLine("Modulus: " + c(10, 5));
//    }
//}




//Multicast Delegate Example
//using System;

//class Program
//{
//    delegate void Show();

//    static void Hello()
//    {
//        Console.WriteLine("Hello");
//    }

//    static void Welcome()
//    {
//        Console.WriteLine("Welcome");
//    }

//    static void Main()
//    {
//        Show s = Hello;
//        s += Welcome;

//        s();
//    }
//}




//Replace Method with Lambda Expression
//using System;

//class Program
//{
//    // Normal Method
//    static int Square(int x)
//    {
//        return x * x;
//    }

//    static void Main()
//    {
//        // Calling normal method
//        Console.WriteLine("Using Normal Method:");
//        Console.WriteLine(Square(5));

//        // Lambda Expression
//        Func<int, int> square = x => x * x;

//        Console.WriteLine("Using Lambda Expression:");
//        Console.WriteLine(square(5));
//    }
//}





//Sort List Using Lambda
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 5, 2, 8, 1 };

//        numbers.Sort((a, b) => a.CompareTo(b));

//        foreach (int n in numbers)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}





//Where Delegates & Lambda are Used in Industry

//Delegates used for:
//1.Event handling
//2.Callback methods
//3.Asynchronous programming

//Lambda expressions used for
//1.LINQ queries
//2.Sorting / filtering collections
//3.Writing short functions quickly





//What is LINQ Queries
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6 };

//        var result = numbers.Where(n => n % 2 == 0);

//        foreach (var n in result)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}
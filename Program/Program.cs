//////using System;

//////class Program
//////{
//////    // Step 1: Declare Delegate
//////    public delegate void MyDelegate();

//////    // Step 2: Create Methods
//////    public static void Method1()
//////    {
//////        Console.WriteLine("Method 1 Called");
//////    }

//////    public static void Method2()
//////    {
//////        Console.WriteLine("Method 2 Called");
//////    }

//////    static void Main()
//////    {
//////        // Step 3: Create Delegate Object
//////        MyDelegate del = Method1;

//////        // Step 4: Add another method (Multicast)
//////        del += Method2;

//////        // Step 5: Invoke Delegate
//////        del();   // Calls Method1 and Method2
//////    }
//////}



////using System;

////class Program
////{
////    static void Main()
////    {
////        Action del = () => Console.WriteLine("Lambda 1");
////        del += () => Console.WriteLine("Lambda 2");

////        del();
////    }
////}


//using System;
//using System.Collections.Generic;

//class Student
//{
//    public string Name;
//    public int Marks;
//}

//class Program
//{
//    static void Main()
//    {
//        List<Student> list = new List<Student>
//        {
//            new Student { Name="Tej", Marks=80 },
//            new Student { Name="Ram", Marks=65 },
//            new Student { Name="Amit", Marks=90 }
//        };

//        // Sort by Marks
//        list.Sort((s1, s2) => s1.Marks.CompareTo(s2.Marks));

//        foreach (var s in list)
//            Console.WriteLine(s.Name + " " + s.Marks);
//    }
//}

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 10, 15, 20 };

        var result = numbers.Where(n => n > 10);

        foreach (var n in result)
            Console.WriteLine(n);
    }
}





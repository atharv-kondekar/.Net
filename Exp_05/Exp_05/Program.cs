//Run Program in Synchronous Way
//using System;
//using System.Threading;

//class Program
//{
//    static void Work1()
//    {
//        Console.WriteLine("Work1 started");
//        Thread.Sleep(2000);
//        Console.WriteLine("Work1 finished");
//    }

//    static void Work2()
//    {
//        Console.WriteLine("Work2 started");
//        Thread.Sleep(2000);
//        Console.WriteLine("Work2 finished");
//    }

//    static void Main()
//    {
//        Work1();
//        Work2();
//    }
//}






//Convert to Asynchronous Way
//using System;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Work1()
//    {
//        Console.WriteLine("Work1 started");
//        await Task.Delay(2000);
//        Console.WriteLine("Work1 finished");
//    }

//    static async Task Work2()
//    {
//        Console.WriteLine("Work2 started");
//        await Task.Delay(2000);
//        Console.WriteLine("Work2 finished");
//    }

//    static async Task Main()
//    {
//        await Work1();
//        await Work2();
//    }
//}






//Replace Thread.Sleep with Task.Delay
//using System;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main()
//    {
//        Console.WriteLine("Program started");

//        await ShowMessage();

//        Console.WriteLine("Program finished");
//    }

//    static async Task ShowMessage()
//    {
//        Console.WriteLine("Waiting for 3 seconds...");

//        await Task.Delay(3000);   // Replaces Thread.Sleep(3000)

//        Console.WriteLine("3 seconds completed");
//    }
//}



//Create Method Returning Task
//using System;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task ShowMessage()
//    {
//        await Task.Delay(2000);
//        Console.WriteLine("Hello after delay");
//    }

//    static async Task Main()
//    {
//        await ShowMessage();
//    }
//}

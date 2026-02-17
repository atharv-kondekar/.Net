//using System;

//class Program
//{
    
//    public delegate void NotifyDelegate();

    
//    public static void Message1()
//    {
//        Console.WriteLine("Message 1 received");
//    }

//    public static void Message2()
//    {
//        Console.WriteLine("Message 2 received");
//    }

//    public static void Message3()
//    {
//        Console.WriteLine("Message 3 received");
//    }

//    static void Main(string[] args)
//    {
        
//        NotifyDelegate del = Message1;
//        del += Message2;
//        del += Message3;

      
//        del();
//    }
//}



using System;
delegate int NumberChanger(int n);
namespace DelegateAppl
{

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
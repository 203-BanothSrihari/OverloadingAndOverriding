using System;

namespace OverloadingAndOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloaing ab = new MethodOverloaing();
            int num1=ab.Add(5, 6, 2);
            int num2=ab.Add(78, 56);
            Console.WriteLine("the addition of first method  :" + num1);
            Console.WriteLine("the addition of second method : " + num2);
        }
    }
}

// constructor建構方法
using System;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person(159.2, 22, "小白");
         

            Person person2 = new Person(169.7, 15, "小黑");
        
            Console.WriteLine(person1.name);
            Console.WriteLine(person2.age);
        }
    }
}
